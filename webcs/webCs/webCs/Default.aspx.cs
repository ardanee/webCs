using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCs
{
   public partial class _Default : System.Web.UI.Page
   {
      
      protected void Page_Load(object sender, EventArgs e)
      {
         try
         {
            BLL.ClsIdiomas clsIdiomas = new BLL.ClsIdiomas();
           System.Data.DataTable x = new System.Data.DataTable() ;
           x.Columns.Add("Columna1"); x.Columns.Add("Columna2"); x.Columns.Add("Columna3");
           x.Rows.Add("Valor1", "Valor2", "Valor3");
           x.Rows.Add("Valor4", "Valor5", "Valor6");
           x.Rows.Add("Valor7", "Valor8", "Valor9");
            //x = clsIdiomas.consultarTabla("SELECT 1 FROM TblSasss");

           Response.Write(clsHelper.dataTable2Json(x));
         }
         catch (Exception ex) {
                clsHelper.mostrarError ("Load",ex, this);
         }
      }
   }
}
