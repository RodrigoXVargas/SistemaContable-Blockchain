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
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bBack.Location = new System.Drawing.Point(30, 400);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(94, 29);
            this.bBack.TabIndex = 11;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(81, 25);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(215, 27);
            this.dateFrom.TabIndex = 10;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(369, 25);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(209, 27);
            this.dateTo.TabIndex = 9;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(327, 28);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(36, 22);
            this.labelTo.TabIndex = 8;
            this.labelTo.Text = "To:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(15, 28);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(60, 22);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "From:";
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bStart.Location = new System.Drawing.Point(660, 25);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(94, 29);
            this.bStart.TabIndex = 6;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // DiaryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.bStart);
            this.Name = "DiaryBook";
            this.Text = "DiaryBook";
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
    }
}