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
            this.nameAccCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLedgerTot)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(30, 383);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(94, 29);
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
            this.dgLedgerTot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameAccCol,
            this.debeCol,
            this.haberCol,
            this.totCol});
            this.dgLedgerTot.Location = new System.Drawing.Point(30, 52);
            this.dgLedgerTot.Name = "dgLedgerTot";
            this.dgLedgerTot.ReadOnly = true;
            this.dgLedgerTot.RowHeadersWidth = 51;
            this.dgLedgerTot.RowTemplate.Height = 29;
            this.dgLedgerTot.Size = new System.Drawing.Size(578, 265);
            this.dgLedgerTot.TabIndex = 1;
            // 
            // nameAccCol
            // 
            this.nameAccCol.HeaderText = "Name";
            this.nameAccCol.MinimumWidth = 6;
            this.nameAccCol.Name = "nameAccCol";
            this.nameAccCol.ReadOnly = true;
            this.nameAccCol.Width = 150;
            // 
            // debeCol
            // 
            this.debeCol.HeaderText = "Debe";
            this.debeCol.MinimumWidth = 6;
            this.debeCol.Name = "debeCol";
            this.debeCol.ReadOnly = true;
            this.debeCol.Width = 125;
            // 
            // haberCol
            // 
            this.haberCol.HeaderText = "Haber";
            this.haberCol.MinimumWidth = 6;
            this.haberCol.Name = "haberCol";
            this.haberCol.ReadOnly = true;
            this.haberCol.Width = 125;
            // 
            // totCol
            // 
            this.totCol.HeaderText = "Total";
            this.totCol.MinimumWidth = 6;
            this.totCol.Name = "totCol";
            this.totCol.ReadOnly = true;
            this.totCol.Width = 125;
            // 
            // LedgerTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 451);
            this.Controls.Add(this.dgLedgerTot);
            this.Controls.Add(this.bBack);
            this.Name = "LedgerTotal";
            this.Text = "LedgerTotal";
            this.Load += new System.EventHandler(this.LedgerTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLedgerTot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bBack;
        private DataGridView dgLedgerTot;
        private DataGridViewTextBoxColumn nameAccCol;
        private DataGridViewTextBoxColumn debeCol;
        private DataGridViewTextBoxColumn haberCol;
        private DataGridViewTextBoxColumn totCol;
    }
}