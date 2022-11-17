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
            this.btn_newSeat = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cuentas = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.debeHaber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha del Asiento";
            // 
            // date_Seat
            // 
            this.date_Seat.Location = new System.Drawing.Point(153, 49);
            this.date_Seat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_Seat.Name = "date_Seat";
            this.date_Seat.Size = new System.Drawing.Size(368, 27);
            this.date_Seat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(500, 263);
            this.dataGridView1.TabIndex = 6;
            // 
            // btn_newSeat
            // 
            this.btn_newSeat.Location = new System.Drawing.Point(21, 456);
            this.btn_newSeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_newSeat.Name = "btn_newSeat";
            this.btn_newSeat.Size = new System.Drawing.Size(125, 31);
            this.btn_newSeat.TabIndex = 8;
            this.btn_newSeat.Text = "Cargar Asiento";
            this.btn_newSeat.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(435, 456);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 31);
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
            this.textBox1.Location = new System.Drawing.Point(170, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 27);
            this.textBox1.TabIndex = 10;
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
            // new_Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 524);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btn_newSeat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_Seat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(930, 571);
            this.MinimumSize = new System.Drawing.Size(930, 571);
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