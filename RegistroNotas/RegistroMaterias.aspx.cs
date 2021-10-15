using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RegistroNotas
{
    public partial class RegistroMaterias : System.Web.UI.Page
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
                query = "INSERT INTO Materia(Nombre,Docente) VALUES" +
                        "('" + txtNombre.Text + "', '" + txtDocente.Text + "')";

                //Declaramos el comando
                comando = new SqlCommand(query, con);

                //Abrimos conexion
                con.Open();

                int result = comando.ExecuteNonQuery();

                if (result >= 1)
                {
                    txtNombre.Text = "";
                    txtDocente.Text = "";
                    lblResultado.Text = "Valores agregados correctamente";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ ex);
                lblResultado.Text = "Ha habido un error";
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Inicializamos
                con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = RegistroNotas05L; Integrated Security = True");

                //Creamos la query
                query = "SELECT * FROM Materia";

                //Creamos un comando
                comando = new SqlCommand(query, con);

                //Abrimos la conexion
                con.Open();

                //Guardamos el dataset
                SqlDataReader dataset = comando.ExecuteReader();

                //Leemos el dataset
                while (dataset.Read())
                {
                    TableRow tr = new TableRow(); //Es similar al document.creatElement('tr');
                    TableCell[] td = new TableCell[3]; //document.createElemente('td')
                    Label[] lblTabla = new Label[3]; //documento.createElement('label')

                    //Inicializamos los arreglos
                    for (int i = 0; i < 3; i++)
                    {
                        td[i] = new TableCell();
                        lblTabla[i] = new Label();
                    }

                    //Manejamos el dataset
                    lblTabla[0].Text = dataset["IdMateria"].ToString();
                    td[0].Controls.Add(lblTabla[0]); //td.appendChild(lbltaba)
                    tr.Controls.Add(td[0]); //tr.appendChild(td)

                    lblTabla[1].Text = dataset["Nombre"].ToString();
                    td[1].Controls.Add(lblTabla[1]); //td.appendChild(lbltaba)
                    tr.Controls.Add(td[1]); //tr.appendChild(td)

                    lblTabla[2].Text = dataset["Docente"].ToString();
                    td[2].Controls.Add(lblTabla[2]); //td.appendChild(lbltaba)
                    tr.Controls.Add(td[2]); //tr.appendChild(td)


                    tblDatos.Controls.Add(tr); //tblDatos.appendChild(tr);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}