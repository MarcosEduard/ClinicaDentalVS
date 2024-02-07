
namespace PORTALES
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCONSULTAS = new System.Windows.Forms.DataGridView();
            this.btnCONSULTA01 = new System.Windows.Forms.Button();
            this.btnCONSULTA02 = new System.Windows.Forms.Button();
            this.btnCONSULTA03 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCONSULTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCONSULTAS
            // 
            this.dgvCONSULTAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCONSULTAS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCONSULTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCONSULTAS.Location = new System.Drawing.Point(218, 32);
            this.dgvCONSULTAS.Name = "dgvCONSULTAS";
            this.dgvCONSULTAS.Size = new System.Drawing.Size(311, 204);
            this.dgvCONSULTAS.TabIndex = 0;
            this.dgvCONSULTAS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCONSULTAS_CellContentClick);
            // 
            // btnCONSULTA01
            // 
            this.btnCONSULTA01.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCONSULTA01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCONSULTA01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTA01.Location = new System.Drawing.Point(58, 299);
            this.btnCONSULTA01.Name = "btnCONSULTA01";
            this.btnCONSULTA01.Size = new System.Drawing.Size(145, 82);
            this.btnCONSULTA01.TabIndex = 1;
            this.btnCONSULTA01.Text = "CONSULTA 01 (PROYECTO)";
            this.btnCONSULTA01.UseVisualStyleBackColor = false;
            this.btnCONSULTA01.Click += new System.EventHandler(this.btnCONSULTA01_Click);
            // 
            // btnCONSULTA02
            // 
            this.btnCONSULTA02.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCONSULTA02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCONSULTA02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTA02.Location = new System.Drawing.Point(297, 299);
            this.btnCONSULTA02.Name = "btnCONSULTA02";
            this.btnCONSULTA02.Size = new System.Drawing.Size(145, 82);
            this.btnCONSULTA02.TabIndex = 2;
            this.btnCONSULTA02.Text = "CONSULTA 02 (PROYECTO)";
            this.btnCONSULTA02.UseVisualStyleBackColor = false;
            this.btnCONSULTA02.Click += new System.EventHandler(this.btnCONSULTA02_Click);
            // 
            // btnCONSULTA03
            // 
            this.btnCONSULTA03.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCONSULTA03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCONSULTA03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULTA03.Location = new System.Drawing.Point(531, 299);
            this.btnCONSULTA03.Name = "btnCONSULTA03";
            this.btnCONSULTA03.Size = new System.Drawing.Size(145, 82);
            this.btnCONSULTA03.TabIndex = 3;
            this.btnCONSULTA03.Text = "CONSULTA 03 (NOTHWIND)";
            this.btnCONSULTA03.UseVisualStyleBackColor = false;
            this.btnCONSULTA03.Click += new System.EventHandler(this.btnCONSULTA03_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-6, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 200);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCONSULTA03);
            this.Controls.Add(this.btnCONSULTA02);
            this.Controls.Add(this.btnCONSULTA01);
            this.Controls.Add(this.dgvCONSULTAS);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCONSULTAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCONSULTAS;
        private System.Windows.Forms.Button btnCONSULTA01;
        private System.Windows.Forms.Button btnCONSULTA02;
        private System.Windows.Forms.Button btnCONSULTA03;
        private System.Windows.Forms.Panel panel1;
    }
}

