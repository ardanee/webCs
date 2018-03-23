using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
//using System.Web.HttpResponse;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;


namespace webCs.pages
{
   /// <summary>
   /// Summary description for WebService1
   /// </summary>
   [System.Web.Script.Services.ScriptService()]
   [WebService(Namespace = "http://tempuri.org/")]
   [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
   [System.ComponentModel.ToolboxItem(false)]
   // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
   // [System.Web.Script.Services.ScriptService]
   public class WebService1 : System.Web.Services.WebService
   {

      [WebMethod]
      public string prueba(string nombre)
      {
         DataTable dt = new DataTable();
         dt.Columns.Add("col1"); dt.Columns.Add("col2"); dt.Columns.Add("col3");
         dt.Rows.Add(nombre,"Dato2", "Dato3");
         dt.Rows.Add("Dato4", "Dato5", "Dato6");
         dt.Rows.Add("Dato7", "Dato8", "Dato9");
         return DataTableToJSON(dt);
      }

       [WebMethod]
      public string DataTableToJSON(DataTable table)
{
    List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
    foreach (DataRow row in table.Rows)
    {
        Dictionary<string, object> dict = new Dictionary<string, object>();
        foreach (DataColumn col in table.Columns)
        {
            dict[col.ColumnName] = row[col];
        }

        list.Add(dict);
    }
    var serializer = new JavaScriptSerializer();
    return serializer.Serialize(list);
} 

   }

   
}
