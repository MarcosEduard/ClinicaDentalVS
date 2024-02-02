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

namespace FormularioSinParametro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando el formulario se carga
            // Puedes agregar lógica adicional si es necesario
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento que se ejecuta cuando se hace clic en una celda del DataGridView
            // Puedes agregar lógica adicional si es necesario
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;

                // Crear un SqlDataAdapter y asociarlo con el procedimiento almacenado "ConsultaOrden"
                // Conectar.Conexion() es una función que devuelve una conexión a la base de datos
                da = new SqlDataAdapter("ConsultaOrden", Conectar.Conexion());

                // Crear un DataTable para almacenar los resultados de la consulta
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
    }
}
