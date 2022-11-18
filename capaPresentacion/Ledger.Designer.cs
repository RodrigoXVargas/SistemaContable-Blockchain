namespace capaPresentacion
{
    partial class Ledger
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
            this.bBack = new System.Windows.Forms.Button();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.comboCuentas = new System.Windows.Forms.ComboBox();
            this.dgLedger = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bTot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bBack.Location = new System.Drawing.Point(15, 396);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(94, 33);
            this.bBack.TabIndex = 17;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(81, 25);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(215, 27);
            this.dateFrom.TabIndex = 16;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(369, 25);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(209, 27);
            this.dateTo.TabIndex = 15;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(327, 28);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(36, 22);
            this.labelTo.TabIndex = 14;
            this.labelTo.Text = "To:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(15, 28);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(60, 22);
            this.labelFrom.TabIndex = 13;
            this.labelFrom.Text = "From:";
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bStart.Location = new System.Drawing.Point(15, 229);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(94, 35);
            this.bStart.TabIndex = 12;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // comboCuentas
            // 
            this.comboCuentas.FormattingEnabled = true;
            this.comboCuentas.Items.AddRange(new object[] {
            "TODO"});
            this.comboCuentas.Location = new System.Drawing.Point(619, 24);
            this.comboCuentas.Name = "comboCuentas";
            this.comboCuentas.Size = new System.Drawing.Size(151, 28);
            this.comboCuentas.TabIndex = 18;
            this.comboCuentas.SelectedIndexChanged += new System.EventHandler(this.comboCuentas_SelectedIndexChanged);
            // 
            // dgLedger
            // 
            this.dgLedger.AllowUserToAddRows = false;
            this.dgLedger.AllowUserToDeleteRows = false;
            this.dgLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLedger.Location = new System.Drawing.Point(142, 92);
            this.dgLedger.Name = "dgLedger";
            this.dgLedger.ReadOnly = true;
            this.dgLedger.RowHeadersWidth = 51;
            this.dgLedger.RowTemplate.Height = 29;
            this.dgLedger.Size = new System.Drawing.Size(630, 223);
            this.dgLedger.TabIndex = 19;
            this.dgLedger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLedger_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "La suma del debe de esta cuenta es: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "La suma del haber de esta cuenta es: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "La suma total de esta cuenta es: ";
            // 
            // bTot
            // 
            this.bTot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bTot.Location = new System.Drawing.Point(678, 396);
            this.bTot.Name = "bTot";
            this.bTot.Size = new System.Drawing.Size(94, 33);
            this.bTot.TabIndex = 24;
            this.bTot.Text = "Totales";
            this.bTot.UseVisualStyleBackColor = true;
            this.bTot.Click += new System.EventHandler(this.bTot_Click);
            // 
            // Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.bTot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLedger);
            this.Controls.Add(this.comboCuentas);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.bStart);
            this.Name = "Ledger";
            this.Text = "Ledger";
            this.Load += new System.EventHandler(this.Ledger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLedger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bBack;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private Label labelTo;
        private Label labelFrom;
        private Button bStart;
        private ComboBox comboCuentas;
        private DataGridView dgLedger;
        private DataGridViewTextBoxColumn debeCol;
        private DataGridViewTextBoxColumn haberCol;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bTot;
    }
}