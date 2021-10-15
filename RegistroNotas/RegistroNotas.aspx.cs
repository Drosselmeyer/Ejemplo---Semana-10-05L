using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RegistroNotas
{
    public partial class RegistroNotas : System.Web.UI.Page
    {
        //Variables globales
        SqlConnection con = null;
        string query = "";
        SqlCommand comando = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Creamos la cadena conexion
                con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = RegistroNotas05L; Integrated Security = True");

                //Creamos la query
                query = "INSERT INTO Notas(IdAlumno,IdMateria,Nota) VALUES" +
                        "(" + (ddlAlumno.SelectedIndex+1)  + "," + (ddlMaterias.SelectedIndex + 1) + ","+Convert.ToDouble(txtNota.Text)+")";

                //Declaramos el comando
                comando = new SqlCommand(query, con);

                //Abrimos conexion
                con.Open();

                int result = comando.ExecuteNonQuery();

                if (result >= 1)
                {
                    txtNota.Text = "";
                    lblResultado.Text = "Valores agregados correctamente";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                lblResultado.Text = "Ha habido un error";
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}