using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RegistroNotas
{
    public partial class RegistroAlumno : System.Web.UI.Page
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
                //Inicializamos
                con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = RegistroNotas05L; Integrated Security = True");

                //Creamos la query
                query = "INSERT INTO Alumno(Nombre, Grado,Seccion) VALUES" +
                        "('" + txtNombre.Text + "','" + txtGrado.Text + "','" + txtSeccion.Text + "')";

                //Creamos un comando
                comando = new SqlCommand(query, con);

                //Abrimos la conexion
                con.Open();

                //Ejecutamos el comando
                int resultado = comando.ExecuteNonQuery();

                if (resultado >= 1)
                {
                    txtNombre.Text = "";
                    txtGrado.Text = "";
                    txtSeccion.Text = "";

                    lblResultado.Text = "Datos ingresados correctamente";
                }
            }
            catch(SqlException ex)
            {
                lblResultado.Text = "Ha habido un error";
                Console.WriteLine("Error: "+ex);
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
                query = "SELECT * FROM Alumno";

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
                    TableCell[] td = new TableCell[4]; //document.createElemente('td')
                    Label[] lblTabla = new Label[4]; //documento.createElement('label')

                    //Inicializamos los arreglos
                    for (int i = 0; i < 4; i++)
                    {
                        td[i] = new TableCell();
                        lblTabla[i] = new Label();
                    }

                    //Manejamos el dataset
                    lblTabla[0].Text = dataset["IdAlumno"].ToString();
                    td[0].Controls.Add(lblTabla[0]); //td.appendChild(lbltaba)
                    tr.Controls.Add(td[0]); //tr.appendChild(td)

                    lblTabla[1].Text = dataset["Nombre"].ToString();
                    td[1].Controls.Add(lblTabla[1]); //td.appendChild(lbltaba)
                    tr.Controls.Add(td[1]); //tr.appendChild(td)

                    lblTabla[2].Text = dataset["Grado"].ToString();
                    td[2].Controls.Add(lblTabla[2]); //td.appendChild(lbltaba)
                    tr.Controls.Add(td[2]); //tr.appendChild(td)

                    lblTabla[3].Text = dataset["Seccion"].ToString();
                    td[3].Controls.Add(lblTabla[3]); //td.appendChild(lbltaba)
                    tr.Controls.Add(td[3]); //tr.appendChild(td)

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