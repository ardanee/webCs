using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using webCs.BLL;

namespace webCs.pages
{
   public partial class WebForm1 : System.Web.UI.Page
   {
      private ClsIdiomas Cls = new ClsIdiomas();
      protected void Page_Load(object sender, EventArgs e)
      {
         try
         {
            if (!IsPostBack)
            {
               ViewState["id"] = 0;
            }


         }
         catch (Exception ex)
         {
            Response.Write(ex.Message);
         }

      }

      protected void lnkEdit_Click(object sender, EventArgs e)
      {
         GridViewRow r;

         try
         {
            r = (GridViewRow)((Control)sender).Parent.Parent;
            ViewState["id"] = r.Cells[0].Text;
            txtNombre.Text = r.Cells[1].Text;
         }
         catch (Exception)
         {
            throw;
         }
      }

      void limpiarControles()
      {
         try
         {
            ViewState["id"] = 0;
            txtNombre.Text = string.Empty;
         }
         catch (Exception)
         { throw; }
      }

      protected void btnBuscar_Click(object sender, EventArgs e)
      {
         try
         {
            grdIdiomas.DataSource = Cls.buscar(txtNombre.Text);
            grdIdiomas.DataBind();
         }
         catch (Exception ex)
         {
            Response.Write(ex.Message);
         }
      }

      protected void btnGrabar_Click(object sender, EventArgs e)
      {
         try
         {
            int id = Convert.ToInt32( ViewState["id"]);
            Cls.grabarModificar(txtNombre.Text, id);
            Response.Write("Proceso ejecutado con exito");
            limpiarControles();
            btnBuscar_Click(sender, e);
         }
         catch (Exception ex)
         { Response.Write(ex.Message); }
      }

      //End Class
   }
}