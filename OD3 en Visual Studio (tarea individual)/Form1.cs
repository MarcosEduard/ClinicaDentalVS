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

namespace OD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += Form1_SizeChanged;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            CentrarDataGridView();
        }

        private void CentrarDataGridView()
        {
            int x = (this.ClientSize.Width - dgvConsultas.Width) / 2; // Calcular la posición horizontal

            // Asegurarse de que el DataGridView no se salga del margen izquierdo del formulario
            x = Math.Max(x, 0);

            dgvConsultas.Left = x; // Establecer la nueva posición horizontal del DataGridView
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }


        private void btnConsulta01_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;

                // Crear un SqlDataAdapter y asociarlo con el procedimiento almacenado "ConsultaOrden"
                // Conectar.Conexion() es una función que devuelve una conexión a la base de datos
                da = new SqlDataAdapter("probando", Conectar.Conexion());

                // Crear un DataTable para almacenar los resultados de la consulta
                dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Asignar el DataTable como origen de datos para el DataGridView
                dgvConsultas.DataSource = dt;
                AjustarAnchoDataGridView();
            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier excepción que pueda ocurrir durante la ejecución
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConsulta02_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;

                // Crear un SqlDataAdapter y asociarlo con el procedimiento almacenado "ConsultaOrden"
                // Conectar.Conexion() es una función que devuelve una conexión a la base de datos
                da = new SqlDataAdapter("CONSULTA02", Conectar.Conexion());

                // Crear un DataTable para almacenar los resultados de la consulta
                dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Asignar el DataTable como origen de datos para el DataGridView
                dgvConsultas.DataSource = dt;
                AjustarAnchoDataGridView();
            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier excepción que pueda ocurrir durante la ejecución
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConsulta03_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;

                // Crear un SqlDataAdapter y asociarlo con el procedimiento almacenado "ConsultaOrden"
                // Conectar.Conexion() es una función que devuelve una conexión a la base de datos
                da = new SqlDataAdapter("CONSULTA03", Conectar2.Conexion());

                // Crear un DataTable para almacenar los resultados de la consulta
                dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Asignar el DataTable como origen de datos para el DataGridView
                dgvConsultas.DataSource = dt;
                AjustarAnchoDataGridView();
            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier excepción que pueda ocurrir durante la ejecución
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AjustarAnchoDataGridView()
        {
            int totalWidth = 0;
            foreach (DataGridViewColumn column in dgvConsultas.Columns)
            {
                totalWidth += column.Width;
            }

            // Ajustar el ancho del DataGridView
            dgvConsultas.Width = totalWidth + dgvConsultas.RowHeadersWidth + 2; // Añadir ancho de los encabezados de fila y un poco de espacio extra
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void dgvConsultas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
