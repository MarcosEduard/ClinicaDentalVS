
namespace TrabajoFinalOD3
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLISTARCONSULTAS = new System.Windows.Forms.TextBox();
            this.btnCONSULTAS = new System.Windows.Forms.Button();
            this.dgvCONSULTAS = new System.Windows.Forms.DataGridView();
            this.txtParametro1 = new System.Windows.Forms.TextBox();
            this.txtParametro2 = new System.Windows.Forms.TextBox();
            this.lblPARAMETROS = new System.Windows.Forms.LinkLabel();
            this.lxlCONSULTA = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCONSULTAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLISTARCONSULTAS
            // 
            this.txtLISTARCONSULTAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLISTARCONSULTAS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtLISTARCONSULTAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLISTARCONSULTAS.Location = new System.Drawing.Point(237, 306);
            this.txtLISTARCONSULTAS.Name = "txtLISTARCONSULTAS";
            this.txtLISTARCONSULTAS.Size = new System.Drawing.Size(270, 22);
            this.txtLISTARCONSULTAS.TabIndex = 0;
            // 
            // btnCONSULTAS
            // 
            this.btnCONSULTAS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCONSULTAS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCONSULTAS.Location = new System.Drawing.Point(535, 247);
            this.btnCONSULTAS.Name = "btnCONSULTAS";
            this.btnCONSULTAS.Size = new System.Drawing.Size(235, 141);
            this.btnCONSULTAS.TabIndex = 1;
            this.btnCONSULTAS.Text = "CLICK!!!";
            this.btnCONSULTAS.UseVisualStyleBackColor = false;
            this.btnCONSULTAS.Click += new System.EventHandler(this.btnCONSULTAS_Click);
            // 
            // dgvCONSULTAS
            // 
            this.dgvCONSULTAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCONSULTAS.BackgroundColor = System.Drawing.Color.White;
            this.dgvCONSULTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCONSULTAS.Location = new System.Drawing.Point(424, 31);
            this.dgvCONSULTAS.Name = "dgvCONSULTAS";
            this.dgvCONSULTAS.Size = new System.Drawing.Size(346, 171);
            this.dgvCONSULTAS.TabIndex = 2;
            this.dgvCONSULTAS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCONSULTAS_CellContentClick);
            // 
            // txtParametro1
            // 
            this.txtParametro1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtParametro1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtParametro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro1.Location = new System.Drawing.Point(12, 281);
            this.txtParametro1.Name = "txtParametro1";
            this.txtParametro1.Size = new System.Drawing.Size(173, 22);
            this.txtParametro1.TabIndex = 3;
            this.txtParametro1.Visible = false;
            this.txtParametro1.TextChanged += new System.EventHandler(this.txtParametro1_TextChanged);
            // 
            // txtParametro2
            // 
            this.txtParametro2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtParametro2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtParametro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro2.Location = new System.Drawing.Point(12, 348);
            this.txtParametro2.Name = "txtParametro2";
            this.txtParametro2.Size = new System.Drawing.Size(173, 22);
            this.txtParametro2.TabIndex = 4;
            this.txtParametro2.Visible = false;
            this.txtParametro2.TextChanged += new System.EventHandler(this.txtParametro2_TextChanged);
            // 
            // lblPARAMETROS
            // 
            this.lblPARAMETROS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPARAMETROS.AutoSize = true;
            this.lblPARAMETROS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPARAMETROS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPARAMETROS.LinkColor = System.Drawing.Color.Black;
            this.lblPARAMETROS.Location = new System.Drawing.Point(9, 248);
            this.lblPARAMETROS.Name = "lblPARAMETROS";
            this.lblPARAMETROS.Size = new System.Drawing.Size(103, 16);
            this.lblPARAMETROS.TabIndex = 5;
            this.lblPARAMETROS.TabStop = true;
            this.lblPARAMETROS.Text = "PARAMETRO";
            this.lblPARAMETROS.Visible = false;
            this.lblPARAMETROS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPARAMETROS_LinkClicked);
            // 
            // lxlCONSULTA
            // 
            this.lxlCONSULTA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lxlCONSULTA.AutoSize = true;
            this.lxlCONSULTA.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lxlCONSULTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lxlCONSULTA.LinkColor = System.Drawing.Color.Black;
            this.lxlCONSULTA.Location = new System.Drawing.Point(234, 268);
            this.lxlCONSULTA.Name = "lxlCONSULTA";
            this.lxlCONSULTA.Size = new System.Drawing.Size(160, 16);
            this.lxlCONSULTA.TabIndex = 6;
            this.lxlCONSULTA.TabStop = true;
            this.lxlCONSULTA.Text = "INGRESE CONSULTA";
            this.lxlCONSULTA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(-6, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 237);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajoFinalOD3.Properties.Resources.logosRecurso_1logo_od3_2021;
            this.pictureBox1.Location = new System.Drawing.Point(32, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lxlCONSULTA);
            this.Controls.Add(this.lblPARAMETROS);
            this.Controls.Add(this.txtParametro2);
            this.Controls.Add(this.txtParametro1);
            this.Controls.Add(this.dgvCONSULTAS);
            this.Controls.Add(this.btnCONSULTAS);
            this.Controls.Add(this.txtLISTARCONSULTAS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCONSULTAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLISTARCONSULTAS;
        private System.Windows.Forms.Button btnCONSULTAS;
        private System.Windows.Forms.DataGridView dgvCONSULTAS;
        private System.Windows.Forms.TextBox txtParametro1;
        private System.Windows.Forms.TextBox txtParametro2;
        private System.Windows.Forms.LinkLabel lblPARAMETROS;
        private System.Windows.Forms.LinkLabel lxlCONSULTA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}