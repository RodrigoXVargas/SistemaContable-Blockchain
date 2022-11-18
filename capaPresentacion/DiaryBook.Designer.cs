namespace capaPresentacion
{
    partial class DiaryBook
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
            this.dgSeat = new System.Windows.Forms.DataGridView();
            this.dgMoves = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoves)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bBack.Location = new System.Drawing.Point(13, 301);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(82, 26);
            this.bBack.TabIndex = 11;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(71, 19);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(189, 23);
            this.dateFrom.TabIndex = 10;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(323, 19);
            this.dateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(183, 23);
            this.dateTo.TabIndex = 9;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(286, 21);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(30, 19);
            this.labelTo.TabIndex = 8;
            this.labelTo.Text = "To:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(13, 21);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(49, 19);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "From:";
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bStart.Location = new System.Drawing.Point(578, 19);
            this.bStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(82, 22);
            this.bStart.TabIndex = 6;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // dgSeat
            // 
            this.dgSeat.AllowUserToAddRows = false;
            this.dgSeat.AllowUserToDeleteRows = false;
            this.dgSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeat.Location = new System.Drawing.Point(13, 68);
            this.dgSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgSeat.Name = "dgSeat";
            this.dgSeat.ReadOnly = true;
            this.dgSeat.RowHeadersWidth = 51;
            this.dgSeat.RowTemplate.Height = 29;
            this.dgSeat.Size = new System.Drawing.Size(358, 201);
            this.dgSeat.TabIndex = 12;
            this.dgSeat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSeat_CellContentClick);
            this.dgSeat.SelectionChanged += new System.EventHandler(this.dgSeat_SelectionChanged);
            // 
            // dgMoves
            // 
            this.dgMoves.AllowUserToAddRows = false;
            this.dgMoves.AllowUserToDeleteRows = false;
            this.dgMoves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMoves.Location = new System.Drawing.Point(394, 68);
            this.dgMoves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgMoves.Name = "dgMoves";
            this.dgMoves.ReadOnly = true;
            this.dgMoves.RowHeadersWidth = 51;
            this.dgMoves.RowTemplate.Height = 29;
            this.dgMoves.Size = new System.Drawing.Size(386, 201);
            this.dgMoves.TabIndex = 13;
            // 
            // DiaryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 393);
            this.Controls.Add(this.dgMoves);
            this.Controls.Add(this.dgSeat);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.bStart);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DiaryBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiaryBook";
            this.Load += new System.EventHandler(this.DiaryBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoves)).EndInit();
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
        private DataGridView dgSeat;
        private DataGridView dgMoves;
    }
}