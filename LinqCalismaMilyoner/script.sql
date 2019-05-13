USE [Yarisma_DB]
GO
/****** Object:  StoredProcedure [dbo].[RasgeleSoru]    Script Date: 16.4.2014 11:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RasgeleSoru]
as
select top 10 * from view_Ayrintilar order by NEWID()

GO
/****** Object:  StoredProcedure [dbo].[SoruEkle]    Script Date: 16.4.2014 11:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SoruEkle]
(
@SoruMetni nvarchar(250),
@A nvarchar(100),
@B nvarchar(100),
@C nvarchar(100),
@D nvarchar(100),
@SoruDogruCevap character
)
as
begin
insert into Sorular(SoruMetni) values(@SoruMetni)
insert into SoruSıkları(A,B,c,D) values(@A,@B,@C,@D)
insert into SoruDogruSık(DogruSık) values(@SoruDogruCevap)
end

GO
/****** Object:  StoredProcedure [dbo].[SoruGuncelle]    Script Date: 16.4.2014 11:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SoruGuncelle]
(
@SoruID int,
@SoruMetni nvarchar(250),
@DogruSık character,
@SıkA nvarchar(100),
@SıkB nvarchar(100),
@SıkC nvarchar(100),
@SıkD nvarchar(100)
)
as
begin
update Sorular set SoruMetni = @SoruMetni where Sorular.SoruID =@SoruID
update SoruSıkları set A = @SıkA,B = @SıkB,C = @SıkC,D=@SıkD where SoruSıkları.SoruID = @SoruID
update SoruDogruSık set DogruSık = @DogruSık where SoruDogruSık.SoruID = @SoruID
end

GO
/****** Object:  StoredProcedure [dbo].[SoruSil]    Script Date: 16.4.2014 11:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SoruSil]
(
@id int
)
as
begin
delete from Sorular where Sorular.SoruID =@id 
end

GO
/****** Object:  Table [dbo].[SoruDogruSık]    Script Date: 16.4.2014 11:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SoruDogruSık](
	[SoruID] [int] IDENTITY(1,1) NOT NULL,
	[DogruSık] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sorular]    Script Date: 16.4.2014 11:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sorular](
	[SoruID] [int] IDENTITY(1,1) NOT NULL,
	[SoruMetni] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK__Sorular__233D9609CC398693] PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SoruSıkları]    Script Date: 16.4.2014 11:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoruSıkları](
	[SoruID] [int] IDENTITY(1,1) NOT NULL,
	[A] [nvarchar](50) NOT NULL,
	[B] [nvarchar](50) NOT NULL,
	[C] [nvarchar](50) NOT NULL,
	[D] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Ayrintilar]    Script Date: 16.4.2014 11:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_Ayrintilar]
AS
SELECT        dbo.Sorular.SoruID, dbo.SoruDogruSık.DogruSık, dbo.SoruSıkları.A, dbo.SoruSıkları.B, dbo.SoruSıkları.C, dbo.Sorular.SoruMetni, dbo.SoruSıkları.D
FROM            dbo.SoruDogruSık INNER JOIN
                         dbo.Sorular ON dbo.SoruDogruSık.SoruID = dbo.Sorular.SoruID INNER JOIN
                         dbo.SoruSıkları ON dbo.SoruDogruSık.SoruID = dbo.SoruSıkları.SoruID AND dbo.Sorular.SoruID = dbo.SoruSıkları.SoruID


GO
SET IDENTITY_INSERT [dbo].[SoruDogruSık] ON 

INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (1, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (2, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (3, N'c')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (4, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (5, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (6, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (7, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (8, N'c')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (9, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (10, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (11, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (12, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (13, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (14, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (15, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (16, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (17, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (18, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (19, N'c')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (20, N'c')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (21, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (22, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (23, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (24, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (25, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (26, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (27, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (28, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (29, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (30, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (31, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (32, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (33, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (34, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (35, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (36, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (37, N'c')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (38, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (39, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (40, N'a')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (41, N'd')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (42, N'b')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (43, N'c')
INSERT [dbo].[SoruDogruSık] ([SoruID], [DogruSık]) VALUES (44, N'a')
SET IDENTITY_INSERT [dbo].[SoruDogruSık] OFF
SET IDENTITY_INSERT [dbo].[Sorular] ON 

INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (1, N'Adını Büyük İskenderin kız kardeşinden alan kent hangisidir ?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (2, N'Hangi köpek ırkı adını üreticisi olan kişiden almıştır')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (3, N'Hangileri 1912''den 1948''e kadar olimpiyat müsabakalarında yer almıştır?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (4, N'İtalyancadan dilimize geçen ve kökeninin anlamı meydan, çarşı olan kelime hangisidir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (8, N'1958''de Gerald Holtom''ın yaptığı barış sembolü neyi protesto etmek için tasarlanmıştır?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (9, N'Eski Roma''da gladyatör dövüşlerinin yapıldığı "arena"nın kelime anlamı nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (11, N'“Sezar’ın hakkı Sezar’a” sözü kime aittir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (12, N'Hangisi para üzerine resmi basılan bilinen ilk gerçek kişidir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (14, N'“Onun sayesinde” sözündeki “saye” nin kelime anlamı nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (19, N'Descartes, hangisini "ruhun oturduğu yer" sözüyle tanımlamıştır?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (20, N' İpek, örümcek, sincap hangi hayvanın türleridir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (21, N'Herkesin yararı için hangi kuruluşun sloganıdır?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (22, N'Geçtiğimiz günlerde Rusya''da bir sumo güreşçisi hangisini çalarken yakalanmıştır?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (23, N'Tıbbi bir terim olan "diastema" hangisini ifade eder?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (24, N'fransızcadan dilimize geçen bonkörün kelime anlamı nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (25, N'Arapçadan dilimize geçen tuhafiye kelimesindeki tuhafın anlamı nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (26, N'"Eli belinde, koç başı" hangisinde kullanılan motiflerdir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (27, N'Peyzaj mimarlığı sözündeki fransızcadan dilimize geçen peyzaj kelimesinin anlamı nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (29, N'VIII. Henry''nin aşkı uğruna tüm ülkeyi katolik klisesinden ayırıp Anglikan klisesine dahil etmesine neden olan kadın kimdir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (30, N'Eski Türk savaşçılarının tamamen kazıdıkları başlarında bıraktıkları bir parça saça Farsçada verilen ad nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (31, N'Arkeolog Wilhelm König''in Bağdat''ta ortaya çıkardığı yaklaşık iki bin yıllık nesne ne olarak bilinir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (32, N'Ocak ayında hangi ülkede yaşanan bir olayda "Şiir mi daha üstündür, düz yazı mı?" tartışması cinayetle sonuçlanmıştır?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (33, N'Eski Türkçe kaynaklı gömlek kelimesinin kökeninin anlamı nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (34, N'Semeresini vermek deyiminde geçen semere kelimesinin anlamı nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (35, N'Dilimize Fransızcadan geçen ve yemek listesi anlamında kullanılan menü kelimesinin kökeninin anlamı nedir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (36, N'İngiliz Parlamentosu''nda milletvekilliği yaparken sadece bir kez söz alıp rüzgardan rahatsız olduğu için pencerenin kapatılmasını istediği söylenen bilim adamı kimdir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (37, N'Geçtiğimiz günlerde hangi avrupa ülkesinde 2 mahkum, psikolojik sorunlarımız var, çözer çözmez geri döneceğiniz yazan bir not bırakarak kaçmıştır?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (38, N'Bir şarkı çalınır ya da söylenirken yapılan nota yanlışlığına ne ad verilir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (39, N'Hangi hayvanın ağaç gövdelerini çiğneyerek, kendi kazdığı su çukurlarını kurumasın diye onlara kapak olarak kullandığı gözlemlenmiştir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (40, N'Yeni doğan bebeklerin parmak izi henüz oluşmadığı için, nerelerinden iz alınır?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (41, N'Avrupa''nın batısında yer almasına rağmen 72 yıldır hatalı bir biçimde Orta Avrupa saat diliminde yer alan ülke hangisidir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (42, N'Eski Mısırlılar, mumyalama işlemi sırasında hangi organı çıkarıp mumyalamadan atarlar?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (43, N'Küba''ya ticaret ambargosu getirmesinden hemen önce 1200 tane Küba purosu alarak stok yapan ABD başkanı kimdir?')
INSERT [dbo].[Sorular] ([SoruID], [SoruMetni]) VALUES (44, N'Kökeni Farsça olan ve Türkçe dahil birçok dile olduğu gibi geçen gerçek ve mecaz anlamı aynı şekilde kullanılan hayvan hangisidir?')
SET IDENTITY_INSERT [dbo].[Sorular] OFF
SET IDENTITY_INSERT [dbo].[SoruSıkları] ON 

INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (1, N'Delhi', N'Selanik', N'Bağdat', N'Viyana')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (2, N'Mastiff', N'Saint Bernard', N'Rottweiler', N'Doberman')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (3, N'Askeri tatbikatlar', N'Sihirbazlık', N'Sanat dalları', N'Hayvan terbiyeciliği')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (4, N'Piyasa', N'Park', N'Trafik', N'Borsa')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (7, N'Köpek havlaması sesi', N'Su damlası sesi', N'Saat saniyesinin sesi', N'Kapıya vurma sesi')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (8, N'Vietnam Savaşı', N'Soykırım', N'Nükleer silahlanma', N'Kore savaşı')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (9, N'Kavga', N'Kum', N'Kan', N'Kılıç')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (10, N'Boris Pasternak', N'Mihail Şolohov', N'Aleksandr Soljenitsin', N'Maksim Gorki')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (11, N'Hz. İsa', N'Büyük İskender', N'Jül Sezar', N'Hz. Ömer')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (12, N'Kraliçe I.Elizabeth', N'Jules Cesar', N'Napoleon Bonaparte', N'Büyük İskender')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (13, N'Zeus', N'Apollon', N'Hermes', N'Metis')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (14, N' Rüzgar', N'Koltuk', N'Merdiven', N'Gölge')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (15, N'Bangladeş', N'Katar', N'Brunei', N'Suudi Arabistan')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (16, N'Şair', N'Casus', N'Güzellik Kraliçesi', N'Opera Sanatçısı')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (17, N'Bangladeş', N'Katar', N'Brunei', N'Suudi Arabistan')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (18, N'Bangladeş', N'Katar', N'Brunei', N'Suudi Arabistan')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (19, N'Gözyaşı bezi', N'Öd kesesi', N'Epifiz bezi', N'Aşil tendonu')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (20, N'Penguen', N'Baykuş', N'Maymun', N'Sincap')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (21, N'NASA', N'UNICEF', N'Interpol', N'Birleşmiş Milletler')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (22, N'İnek', N'ATM', N'Sokak Lambası', N'Matruşka bebek')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (23, N'İki gözün farklı renkte olması', N'İki diş arasındaki açıklık', N'Düz tabanlık', N'Şaşılık')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (24, N'İyi kalpli', N'İnce ruhlu', N'Alçak gönüllü', N'Güvenilir')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (25, N'Antika', N'Maskot', N'Süs', N'Boncuk')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (26, N'Halı', N'Çini', N'Kaftan', N'Ebru')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (27, N'Manzara', N'Sokak', N'Bahçe', N'Çerçeve')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (28, N'Caterina de Mecini', N'Merie Antoinette', N'Lady Godiva', N'Anne Boleyn')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (29, N'Caterina de Mecini', N'Merie Antoinette', N'Lady Godiva', N'Anne Boleyn')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (30, N'Sırma', N'Kahkül', N'Topuz', N'Sarık')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (31, N'Pil', N'Ampul', N'Dürbün', N'Vantilatör')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (32, N'İsveç', N'Fransa', N'Norveç', N'Rusya')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (33, N'Sırt', N'Göğüs', N'Kol', N'Omuz')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (34, N'Meyve', N'Ödül', N'Çiçek', N'Bereket')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (35, N'Çeşit', N'Lezzet', N'Tercih', N'Küçük')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (36, N'Michael Faraday', N'James Watt', N'Alexander Flaming', N'Isaac Newton')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (37, N'İsveç', N'Fransa', N'İtalya', N'İspanya')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (38, N'Falso', N'Tonga', N'Fire', N'Tapon')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (39, N'Fil', N'Maymun', N'Zürafa', N'Deve')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (40, N'Topuk', N'Avuç', N'Kulak Memesi', N'Diz Kapağı')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (41, N'Fransa', N'İrlanda', N'Portekiz', N'İspanya')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (42, N'Göz', N'Beyin', N'Kalp', N'Dil')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (43, N'Lyndon Johnson', N'Jimmy Carter', N'John F. Kenedy', N'
Richard Nixon')
INSERT [dbo].[SoruSıkları] ([SoruID], [A], [B], [C], [D]) VALUES (44, N'Çakal', N'Kurt', N'Sazan', N'Diz Kapağı')
SET IDENTITY_INSERT [dbo].[SoruSıkları] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SoruDogruSık"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sorular"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SoruSıkları"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Ayrintilar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Ayrintilar'
GO
