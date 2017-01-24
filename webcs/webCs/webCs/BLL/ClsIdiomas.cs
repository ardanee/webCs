using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace webCs.BLL
{
   public class ClsIdiomas : ClsDb
   {
      public DataTable buscar(string criterio)
      {
         DataTable res = new DataTable();
         string consulta = "Select IdIdioma, Nombre FROM TblIdioma WHERE Nombre LIKE '%" + criterio + "%'";
         try
         {
            res = consultarTabla(consulta);
            return res;
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }

      public void grabarModificar(string nombre, int id = 0) {
         string consulta;
         try
         {
            consulta = "IF EXISTS(SELECT 1 FROM TblIdioma WHERE IdIdioma = " + id.ToString() + @")  
                            BEGIN  
                               UPDATE TblIdioma SET Nombre  = " + send(nombre) + @" WHERE IdIdioma = " + id.ToString() + @"  
                             END  
                             ELSE BEGIN  
                              INSERT TblIdioma(Nombre) VALUES(" + send(nombre) + @") 
                             END ";
            ejecutarConsulta(consulta);
         }
         catch (Exception)
         {
            throw;
         }
      }

   }
}