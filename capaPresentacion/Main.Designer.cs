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
            this.btnCarga.Location = new System.Drawing.Point(38, 35);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(289, 28);
            this.btnCarga.TabIndex = 0;
            this.btnCarga.Text = "Carga de Datos";
            this.btnCarga.UseVisualStyleBackColor = true;
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.Location = new System.Drawing.Point(38, 101);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Size = new System.Drawing.Size(289, 27);
            this.btnLibroDiario.TabIndex = 1;
            this.btnLibroDiario.Text = "Libro Diario";
            this.btnLibroDiario.UseVisualStyleBackColor = true;
            // 
            // btnLibroMayor
            // 
            this.btnLibroMayor.Location = new System.Drawing.Point(38, 164);
            this.btnLibroMayor.Name = "btnLibroMayor";
            this.btnLibroMayor.Size = new System.Drawing.Size(289, 25);
            this.btnLibroMayor.TabIndex = 2;
            this.btnLibroMayor.Text = "Libro Mayor";
            this.btnLibroMayor.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 212);
            this.Controls.Add(this.btnLibroMayor);
            this.Controls.Add(this.btnLibroDiario);
            this.Controls.Add(this.btnCarga);
            this.MaximumSize = new System.Drawing.Size(372, 251);
            this.MinimumSize = new System.Drawing.Size(372, 251);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCarga;
        private Button btnLibroDiario;
        private Button btnLibroMayor;
    }
}