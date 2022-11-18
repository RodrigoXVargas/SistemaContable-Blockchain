namespace capaPresentacion
{
    partial class LedgerTotal
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
            this.dgLedgerTot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLedgerTot)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(26, 287);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(82, 22);
            this.bBack.TabIndex = 0;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // dgLedgerTot
            // 
            this.dgLedgerTot.AllowUserToAddRows = false;
            this.dgLedgerTot.AllowUserToDeleteRows = false;
            this.dgLedgerTot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLedgerTot.Location = new System.Drawing.Point(12, 39);
            this.dgLedgerTot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgLedgerTot.Name = "dgLedgerTot";
            this.dgLedgerTot.ReadOnly = true;
            this.dgLedgerTot.RowHeadersWidth = 51;
            this.dgLedgerTot.RowTemplate.Height = 29;
            this.dgLedgerTot.Size = new System.Drawing.Size(556, 199);
            this.dgLedgerTot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL DE TODAS LAS CUENTAS";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(434, 284);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 3;
            // 
            // LedgerTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 338);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLedgerTot);
            this.Controls.Add(this.bBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LedgerTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LedgerTotal";
            this.Load += new System.EventHandler(this.LedgerTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLedgerTot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bBack;
        private DataGridView dgLedgerTot;
        private Label label1;
        private TextBox txtTotal;
    }
}