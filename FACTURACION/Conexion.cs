using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace FACTURACION
{
    internal class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion() 
        {
            try 
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=FACTURACION_INV;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("No se conectó con la base de datos: "+ex.ToString());
            }
        }

        public string insertar(int ID, string COD_PRODUCTO, string NOMBRE, string PRECIO) //cantidad vendida queda pendiente 
        {
            string salida = "Se inserto";
            try 
            {
                cmd = new SqlCommand("Insert into PRODUCTO(ID,COD_PRODUCTO,NOMBRE,PRECIO) values("+ID+",'"+COD_PRODUCTO+"','"+NOMBRE+"','"+PRECIO+"')",cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                salida = "No se conecto: " +ex.ToString();
            }
            return salida;
        }
           
        public int productoRegistrado(int ID)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Producto where ID="+ID+"", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read()) 
                {
                    contador++; 
                }
                dr.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show ("No se pudo consultar: "+ex.ToString());
            }
            return contador;
        }
    }
}
