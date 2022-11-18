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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameAccCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(227, 270);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(82, 22);
            this.bBack.TabIndex = 0;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameAccCol,
            this.debeCol,
            this.haberCol,
            this.totCol});
            this.dataGridView1.Location = new System.Drawing.Point(26, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(508, 199);
            this.dataGridView1.TabIndex = 1;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LedgerTotal";
            this.Text = "LedgerTotal";
            this.Load += new System.EventHandler(this.LedgerTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bBack;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameAccCol;
        private DataGridViewTextBoxColumn debeCol;
        private DataGridViewTextBoxColumn haberCol;
        private DataGridViewTextBoxColumn totCol;
    }
}