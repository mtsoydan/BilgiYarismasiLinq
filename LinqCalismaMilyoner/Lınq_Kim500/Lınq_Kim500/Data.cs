using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.SqlClient;
using System.Text;
using System.Data;

using System.Threading.Tasks;

namespace Lınq_Kim500
{
  public  class Data
  {
      DataClasses1DataContext mydt = new DataClasses1DataContext();
      List<Veriler.listview_Sorular> lw= new List<Veriler.listview_Sorular>();
      public  List<Veriler.listview_Sorular> SoruGetir()
      {
          DataClasses1DataContext mydc = new DataClasses1DataContext();
          var sorgu = from sorum in mydc.view_Ayrintilars select sorum;
          foreach (var item in sorgu)
          {
              Veriler.listview_Sorular sorularım = new Veriler.listview_Sorular();
              sorularım.soruID = item.SoruID;
              sorularım.soruMetni = item.SoruMetni;
              sorularım.SıkA = item.A;
              sorularım.SıkB = item.B;
              sorularım.SıkC = item.C;
              sorularım.SıkD = item.D;
              sorularım.dogruSık =  item.DogruSık.ToString();
              lw.Add(sorularım);
          }
          return lw;
      }
      public Veriler.listview_Sorular SoruGetir(int ID)
      {
          DataClasses1DataContext mydc = new DataClasses1DataContext();
          Veriler.listview_Sorular sorularım = new Veriler.listview_Sorular();
          var sorgu = from m in mydc.view_Ayrintilars where m.SoruID == ID select m;
          foreach (var item in sorgu)
          {
              sorularım.soruID = item.SoruID;
              sorularım.soruMetni = item.SoruMetni;
              sorularım.SıkA = item.A;
              sorularım.SıkB = item.B;
              sorularım.SıkC = item.C;
              sorularım.SıkD = item.D;
              sorularım.dogruSık = item.DogruSık.ToString();
          }
          return sorularım;
      }
      public List<Veriler.listview_Sorular> SoruGetir(string text)
      {
          DataClasses1DataContext mydc = new DataClasses1DataContext();
          //var sorgu = (from sorum in mydc.view_Ayrintilars where sorum.SoruMetni.StartsWith(text) select sorum);
          var sorgu2 = from a in mydc.Sorulars
                       from b in mydc.SoruSıklarıs
                       from c in mydc.SoruDogruSıks
                       //where a.SoruID == b.SoruID && a.SoruID == c.SoruID && a.SoruMetni.StartsWith(text)
                       //where a.SoruID == b.SoruID && a.SoruID == c.SoruID && a.SoruMetni.Contains(text)
                       where a.SoruID == b.SoruID && a.SoruID == c.SoruID && SqlMethods.Like(a.SoruMetni ,"%"+text+"%")
                       select new
                       {
                           a.SoruID,
                           a.SoruMetni,
                           b.A,
                           b.B,
                           b.C,
                           b.D,
                           c.DogruSık
                       };
          foreach (var item in sorgu2)
          {
              Veriler.listview_Sorular sorularım = new Veriler.listview_Sorular();
              sorularım.soruID = item.SoruID;
              sorularım.soruMetni = item.SoruMetni;
              sorularım.SıkA = item.A;
              sorularım.SıkB = item.B;
              sorularım.SıkC = item.C;
              sorularım.SıkD = item.D;
              sorularım.dogruSık = item.DogruSık.ToString();
              lw.Add(sorularım);
          }
          return lw;
          //Veriler.listview_Sorular sorularım = new Veriler.listview_Sorular();
          //sorularım.soruID = sorgu.SoruID;
          //sorularım.soruMetni = sorgu.SoruMetni;
          //sorularım.SıkA = sorgu.A;
          //sorularım.SıkB = sorgu.B;
          //sorularım.SıkC = sorgu.C;
          //sorularım.SıkD = sorgu.D;
          //sorularım.dogruSık = sorgu.DogruSık.ToString();
          //lw.Add(sorularım);
          //return lw;
      }
      public DataTable YarismaSorulari()
      {
            DataTable dttable = new DataTable();
            var sorgu = from deneme in mydt.RasgeleSoru() select deneme;
            dttable.Columns.Add(new DataColumn("SoruID", typeof(int)));
            dttable.Columns.Add(new DataColumn("SoruMetni", typeof(string)));
            dttable.Columns.Add(new DataColumn("A", typeof(string)));
            dttable.Columns.Add(new DataColumn("B", typeof(string)));
            dttable.Columns.Add(new DataColumn("C", typeof(string)));
            dttable.Columns.Add(new DataColumn("D", typeof(string)));
            dttable.Columns.Add(new DataColumn("DogruSık", typeof(string)));
            sorgu.ToList().ForEach((RasgeleSoruResult) =>
            {
                DataRow newRow = dttable.NewRow();
                newRow.SetField<int>("SoruID", RasgeleSoruResult.SoruID);
                newRow.SetField<string>("SoruMetni", RasgeleSoruResult.SoruMetni);
                newRow.SetField<string>("A", RasgeleSoruResult.A);
                newRow.SetField<string>("B", RasgeleSoruResult.B);
                newRow.SetField<string>("C", RasgeleSoruResult.C);
                newRow.SetField<string>("D", RasgeleSoruResult.D);
                newRow.SetField<string>("DogruSık", RasgeleSoruResult.DogruSık.ToString());
                dttable.Rows.Add(newRow);
            });
            return dttable;
      }
      public void SoruSil(int temp)
      {
              mydt.SoruSil(temp);
              mydt.SubmitChanges(); 
      }
  }
}
