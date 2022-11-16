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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_NewMovement = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_NewAccount = new System.Windows.Forms.Button();
            this.btn_newSeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha del Asiento";
            // 
            // date_Seat
            // 
            this.date_Seat.Location = new System.Drawing.Point(139, 37);
            this.date_Seat.Name = "date_Seat";
            this.date_Seat.Size = new System.Drawing.Size(200, 23);
            this.date_Seat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carga de Movimientos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(189, 132);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_NewMovement
            // 
            this.btn_NewMovement.Location = new System.Drawing.Point(189, 175);
            this.btn_NewMovement.Name = "btn_NewMovement";
            this.btn_NewMovement.Size = new System.Drawing.Size(134, 23);
            this.btn_NewMovement.TabIndex = 5;
            this.btn_NewMovement.Text = "Cargar Movimiento";
            this.btn_NewMovement.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(418, 279);
            this.dataGridView1.TabIndex = 6;
            // 
            // btn_NewAccount
            // 
            this.btn_NewAccount.Location = new System.Drawing.Point(12, 175);
            this.btn_NewAccount.Name = "btn_NewAccount";
            this.btn_NewAccount.Size = new System.Drawing.Size(133, 23);
            this.btn_NewAccount.TabIndex = 7;
            this.btn_NewAccount.Text = "Cargar nueva Cuenta";
            this.btn_NewAccount.UseVisualStyleBackColor = true;
            this.btn_NewAccount.Click += new System.EventHandler(this.btn_NewAccount_Click);
            // 
            // btn_newSeat
            // 
            this.btn_newSeat.Location = new System.Drawing.Point(537, 342);
            this.btn_newSeat.Name = "btn_newSeat";
            this.btn_newSeat.Size = new System.Drawing.Size(109, 23);
            this.btn_newSeat.TabIndex = 8;
            this.btn_newSeat.Text = "Cargar Asiento";
            this.btn_newSeat.UseVisualStyleBackColor = true;
            // 
            // new_Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btn_newSeat);
            this.Controls.Add(this.btn_NewAccount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_NewMovement);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_Seat);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(816, 440);
            this.MinimumSize = new System.Drawing.Size(816, 440);
            this.Name = "new_Seat";
            this.Text = "Carga de Asiento";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker date_Seat;
        private Label label2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button btn_NewMovement;
        private DataGridView dataGridView1;
        private Button btn_NewAccount;
        private Button btn_newSeat;
    }
}