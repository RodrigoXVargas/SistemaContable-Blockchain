namespace capaPresentacion
{
    partial class new_Seat
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
            this.label1 = new System.Windows.Forms.Label();
            this.date_Seat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cuentas = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.debeHaber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_newSeat = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha del Asiento";
            // 
            // date_Seat
            // 
            this.date_Seat.Location = new System.Drawing.Point(134, 37);
            this.date_Seat.Name = "date_Seat";
            this.date_Seat.Size = new System.Drawing.Size(388, 23);
            this.date_Seat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Asiento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuentas,
            this.debeHaber,
            this.monto});
            this.dataGridView1.Location = new System.Drawing.Point(18, 117);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(504, 235);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(504, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(504, 235);
            this.dataGridView1.TabIndex = 6;
            // 
            // cuentas
            // 
            this.cuentas.HeaderText = "Cuentas";
            this.cuentas.MinimumWidth = 6;
            this.cuentas.Name = "cuentas";
            this.cuentas.Width = 150;
            // 
            // debeHaber
            // 
            this.debeHaber.HeaderText = "Debe / Haber";
            this.debeHaber.MinimumWidth = 6;
            this.debeHaber.Name = "debeHaber";
            this.debeHaber.Width = 150;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.Width = 150;
            // 
            // btn_newSeat
            // 
            this.btn_newSeat.Location = new System.Drawing.Point(413, 372);
            this.btn_newSeat.Name = "btn_newSeat";
            this.btn_newSeat.Size = new System.Drawing.Size(109, 23);
            this.btn_newSeat.TabIndex = 8;
            this.btn_newSeat.Text = "Cargar Asiento";
            this.btn_newSeat.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 372);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 23);
            this.textBox1.TabIndex = 10;
            // 
            // new_Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 407);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btn_newSeat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_Seat);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(550, 446);
            this.MinimumSize = new System.Drawing.Size(550, 446);
            this.Name = "new_Seat";
            this.Text = "Carga de Asiento";
            this.Load += new System.EventHandler(this.new_Seat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker date_Seat;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btn_newSeat;
        private Button btnVolver;
        private Button button1;
        private DataGridViewComboBoxColumn cuentas;
        private DataGridViewComboBoxColumn debeHaber;
        private DataGridViewTextBoxColumn monto;
        private TextBox textBox1;
    }
}