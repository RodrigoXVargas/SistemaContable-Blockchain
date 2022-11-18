namespace capaPresentacion
{
    partial class Main
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
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnLibroDiario = new System.Windows.Forms.Button();
            this.btnLibroMayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(38, 23);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(289, 28);
            this.btnCarga.TabIndex = 0;
            this.btnCarga.Text = "Carga de Datos";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.Location = new System.Drawing.Point(38, 82);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Size = new System.Drawing.Size(289, 27);
            this.btnLibroDiario.TabIndex = 1;
            this.btnLibroDiario.Text = "Libro Diario";
            this.btnLibroDiario.UseVisualStyleBackColor = true;
            this.btnLibroDiario.Click += new System.EventHandler(this.btnLibroDiario_Click);
            // 
            // btnLibroMayor
            // 
            this.btnLibroMayor.Location = new System.Drawing.Point(38, 145);
            this.btnLibroMayor.Name = "btnLibroMayor";
            this.btnLibroMayor.Size = new System.Drawing.Size(289, 25);
            this.btnLibroMayor.TabIndex = 2;
            this.btnLibroMayor.Text = "Libro Mayor";
            this.btnLibroMayor.UseVisualStyleBackColor = true;
            this.btnLibroMayor.Click += new System.EventHandler(this.btnLibroMayor_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 208);
            this.Controls.Add(this.btnLibroMayor);
            this.Controls.Add(this.btnLibroDiario);
            this.Controls.Add(this.btnCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(372, 247);
            this.MinimumSize = new System.Drawing.Size(372, 247);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCarga;
        private Button btnLibroDiario;
        private Button btnLibroMayor;
        private Button bSalir;
    }
}