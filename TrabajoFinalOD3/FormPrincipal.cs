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

    namespace TrabajoFinalOD3
    {
        public partial class FormPrincipal : Form
        {
            public FormPrincipal()
            {
                InitializeComponent();
            dgvCONSULTAS.BorderStyle = BorderStyle.None;
            btnCONSULTAS.FlatAppearance.BorderColor = btnCONSULTAS.BackColor;
            txtLISTARCONSULTAS.BorderStyle = BorderStyle.None;
            txtParametro1.BorderStyle = BorderStyle.None;
            txtParametro2.BorderStyle = BorderStyle.None;

        }



            private void btnCONSULTAS_Click(object sender, EventArgs e)
            {
                // Declaración de objetos SqlDataAdapter y DataTable
                SqlDataAdapter da;
                DataTable dt;
                string textoConsulta = txtLISTARCONSULTAS.Text;
                string A = "";

            if (textoConsulta== "ODONTÓLOGO CON SALARIO SUPERIOR Y MINIMO DE CITAS")
            {
                txtParametro1.Visible = true;
                txtParametro2.Visible = true;
                lblPARAMETROS.Visible = true;


            }
            if (textoConsulta == "PACIENTE CON TRATAMIENTO ESPECÍFICO" ||
                textoConsulta == "MATERIALES AGOTADOS" ||
                textoConsulta == "PROMEDIO DE CUOTAS POR ODONTÓLOGO" ||
                textoConsulta == "TRATAMIENTOS PENDIENTES" ||
                textoConsulta == "SUCURSALES CON MÁS MATERIAL" ||
                textoConsulta == "ÁREAS CON POCOS EMPLEADOS")
            {
                txtParametro1.Visible = true;
                lblPARAMETROS.Visible = true;
            }
            string Primero = txtParametro1.Text;
            string Segundo = txtParametro2.Text;
            switch (textoConsulta)
                {
                    case "SALDOS PENDIENTES":
                        A = "SPCONSULTA01";
                        break;
                    case "CUOTAS VENCIDAS":
                        A = "SPCONSULTA02";
                        break;
                    case "NINGUNA COMPRA ":
                        A = "SPCONSULTA03";
                        break;
                    case "TOP 5 DENTISTAS":
                        A = "SPCONSULTA04";
                        break;
                    case "NINGÚN TRATAMIENTO":
                        A = "SPCONSULTA05";
                        break;
                    case "MATERIALES EN ALMACENES":
                        A = "SPCONSULTA06";
                        break;
                    case "PROVINCIAS CON MÁS TRATAMIENTOS":
                        A = "SPCONSULTA07";
                        break;
                    case "ODONTÓLOGO CON MAYOR PACIENTES":
                        A = "SPCONSULTA08";
                        break;
                    case "SUMA DE CUOTAS DE LOS PACIENTES":
                        A = "SPCONSULTA09";
                        break;
                    case "ODONTÓLOGOS CON MÁS ATENCIONES":
                        A = "SPCONSULTA10";
                        break;
                    case "PIEZAS DENTALES RECURRENTES":
                        A = "SPCONSULTA11";
                        break;
                    case "TRATAMIENTOS FRECUENTES":
                        A = "SPCONSULTA12";
                        break;
                    case "TRANSACCIONES E INGRESOS":
                        A = "SPCONSULTA13";
                        break;
                    case "PRODUCTOS VENDIDOS":
                        A = "SPCONSULTA14";
                        break;
                    case "ODONTÓLOGO CON SALARIO SUPERIOR Y MINIMO DE CITAS":
                        A = "CPCONSULTA01";
                        break;
                    case "PACIENTE CON TRATAMIENTO ESPECÍFICO":
                        A = "CPCONSULTA02";
                        break;
                    case "MATERIALES AGOTADOS":
                        A = "CPCONSULTA03";
                        break;
                    case "PROMEDIO DE CUOTAS POR ODONTÓLOGO":
                        A = "CPCONSULTA04";
                        break;
                    case "TRATAMIENTOS PENDIENTES":
                        A = "CPCONSULTA05";
                        break;
                    case "SUCURSALES CON MÁS MATERIAL":
                        A = "CPCONSULTA06";
                        break;
                    case "ÁREAS CON POCOS EMPLEADOS":
                        A = "CPCONSULTA07";
                        break;

                    default:
                        // Mostrar un mensaje de error si no se seleccionó ninguna consulta válida
                        MessageBox.Show("Por favor, seleccione una consulta válida.");
                        return; // Salir del método sin ejecutar el resto del código
                }
            
            if (txtParametro1.Visible == true)
            {
                if (txtParametro1.Visible == true && txtParametro2.Visible == true)
                {
                    // Crear una instancia de SqlDataAdapter con el nombre del procedimiento almacenado y la conexión
                    da = new SqlDataAdapter(A, Conectar.Conexion());

                    // Especificar que el comando es un Stored Procedure
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro al comando
                    da.SelectCommand.Parameters.AddWithValue("@Primero", Primero);
                    da.SelectCommand.Parameters.AddWithValue("@Segundo", Segundo);

                    // Crear un DataTable para almacenar los resultados
                    dt = new DataTable();

                    // Llenar el DataTable con los resultados de la consulta
                    da.Fill(dt);

                    // Asignar el DataTable como origen de datos para el DataGridView
                    dgvCONSULTAS.DataSource = dt;
                    AjustarAnchoDataGridView();
                    CentrarDataGridView();
                }
                else
                {
                    // Crear una instancia de SqlDataAdapter con el nombre del procedimiento almacenado y la conexión
                    da = new SqlDataAdapter(A, Conectar.Conexion());

                    // Especificar que el comando es un Stored Procedure
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro al comando
                    da.SelectCommand.Parameters.AddWithValue("@Primero", Primero);

                    // Crear un DataTable para almacenar los resultados
                    dt = new DataTable();

                    // Llenar el DataTable con los resultados de la consulta
                    da.Fill(dt);

                    // Asignar el DataTable como origen de datos para el DataGridView
                    dgvCONSULTAS.DataSource = dt;
                    AjustarAnchoDataGridView();
                    CentrarDataGridView();
                }
            }
            else
            {
                // Crear un SqlDataAdapter y asociarlo con el procedimiento almacenado "ConsultaOrden"
                // Conectar.Conexion() es una función que devuelve una conexión a la base de datos
                da = new SqlDataAdapter(A, Conectar.Conexion());

                // Crear un DataTable para almacenar los resultados de la consulta
                dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Asignar el DataTable como origen de datos para el DataGridView
                dgvCONSULTAS.DataSource = dt;
                AjustarAnchoDataGridView();
                CentrarDataGridView();
            }
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
            // Obtener la posición horizontal del botón
            int buttonX = btnCONSULTAS.Location.X;
            int buttonWidth = btnCONSULTAS.Width;

            // Calcular la posición horizontal del DataGridView centrado con respecto al botón
            int dgvX = buttonX + (buttonWidth - dgvCONSULTAS.Width) / 2;

            // Asegurarse de que el DataGridView no se salga del margen izquierdo del formulario
            dgvX = Math.Max(dgvX, 0);

            // Establecer la nueva posición horizontal del DataGridView
            dgvCONSULTAS.Left = dgvX;
        }


        private void dgvCONSULTAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void txtParametro1_TextChanged(object sender, EventArgs e)
            {
               
            }

            private void txtParametro2_TextChanged(object sender, EventArgs e)
            {
                
                
            }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblPARAMETROS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
