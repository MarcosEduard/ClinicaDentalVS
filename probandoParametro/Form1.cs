using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace probandoParametro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;

                // Obtener el valor del parámetro desde un TextBox o cualquier otro control
                string customerID = txtParametro.Text;

                // Crear una instancia de SqlDataAdapter con el nombre del procedimiento almacenado y la conexión
                da = new SqlDataAdapter("ConsultaOrdenParametro", Conectar.Conexion());

                // Especificar que el comando es un Stored Procedure
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro al comando
                da.SelectCommand.Parameters.AddWithValue("@CustomerID", customerID);

                // Crear un DataTable para almacenar los resultados
                dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);    

                // Asignar el DataTable como origen de datos para el DataGridView
                dgvCustomers.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier excepción que pueda ocurrir durante la ejecución
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
