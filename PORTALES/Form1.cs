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

namespace PORTALES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCONSULTA01.FlatAppearance.BorderColor = btnCONSULTA01.BackColor;
            btnCONSULTA02.FlatAppearance.BorderColor = btnCONSULTA03.BackColor;
            btnCONSULTA03.FlatAppearance.BorderColor = btnCONSULTA03.BackColor;
            dgvCONSULTAS.BorderStyle = BorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCONSULTA01_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;

                // Crear un SqlDataAdapter y asociarlo con el procedimiento almacenado "ConsultaOrden"
                // Conectar.Conexion() es una función que devuelve una conexión a la base de datos
                da = new SqlDataAdapter("PORTALES01", Conectar.Conexion());

                // Crear un DataTable para almacenar los resultados de la consulta
                dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Asignar el DataTable como origen de datos para el DataGridView
                dgvCONSULTAS.DataSource = dt;
                AjustarAnchoDataGridView();
                CentrarDataGridView();

            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier excepción que pueda ocurrir durante la ejecución
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCONSULTA02_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;

                // Crear un SqlDataAdapter y asociarlo con el procedimiento almacenado "ConsultaOrden"
                // Conectar.Conexion() es una función que devuelve una conexión a la base de datos
                da = new SqlDataAdapter("PORTALES02", Conectar.Conexion());

                // Crear un DataTable para almacenar los resultados de la consulta
                dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Asignar el DataTable como origen de datos para el DataGridView
                dgvCONSULTAS.DataSource = dt;
                AjustarAnchoDataGridView();
                CentrarDataGridView();

            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier excepción que pueda ocurrir durante la ejecución
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCONSULTA03_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;

                // Crear un SqlDataAdapter y asociarlo con el procedimiento almacenado "ConsultaOrden"
                // Conectar.Conexion() es una función que devuelve una conexión a la base de datos
                da = new SqlDataAdapter("PORTALES03", Conectar2.Conexion());

                // Crear un DataTable para almacenar los resultados de la consulta
                dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Asignar el DataTable como origen de datos para el DataGridView
                dgvCONSULTAS.DataSource = dt;
                AjustarAnchoDataGridView();
                CentrarDataGridView();

            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier excepción que pueda ocurrir durante la ejecución
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvCONSULTAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AjustarAnchoDataGridView()
        {
            int totalWidth = 0;
            foreach (DataGridViewColumn column in dgvCONSULTAS.Columns)
            {
                totalWidth += column.Width;
            }

            // Ajustar el ancho del DataGridView
            dgvCONSULTAS.Width = totalWidth + dgvCONSULTAS.RowHeadersWidth + 2; // Añadir ancho de los encabezados de fila y un poco de espacio extra
        }
        private void CentrarDataGridView()
        {
            int x = (this.ClientSize.Width - dgvCONSULTAS.Width) / 2; // Calcular la posición horizontal

            // Asegurarse de que el DataGridView no se salga del margen izquierdo del formulario
            x = Math.Max(x, 0);

            dgvCONSULTAS.Left = x; // Establecer la nueva posición horizontal del DataGridView
        }
    }
}
