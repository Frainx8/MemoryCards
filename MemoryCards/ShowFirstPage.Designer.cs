namespace MemoryCards
{
    partial class ShowFirstPage
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
            this.btnBack = new System.Windows.Forms.Button();
            this.Showbtn = new System.Windows.Forms.Button();
            this.labelFirstPage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(16, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(232, 62);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Showbtn
            // 
            this.Showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Showbtn.Location = new System.Drawing.Point(420, 478);
            this.Showbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Showbtn.Name = "Showbtn";
            this.Showbtn.Size = new System.Drawing.Size(232, 62);
            this.Showbtn.TabIndex = 8;
            this.Showbtn.Text = "Показать";
            this.Showbtn.UseVisualStyleBackColor = true;
            this.Showbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFirstPage
            // 
            this.labelFirstPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstPage.Location = new System.Drawing.Point(3, 18);
            this.labelFirstPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstPage.Name = "labelFirstPage";
            this.labelFirstPage.Size = new System.Drawing.Size(493, 238);
            this.labelFirstPage.TabIndex = 9;
            this.labelFirstPage.Text = "FirstPage";
            this.labelFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.labelFirstPage);
            this.groupBox1.Location = new System.Drawing.Point(278, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 259);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // ShowFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Showbtn);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowFirstPage";
            this.Text = "ShowFirstPage";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button Showbtn;
        private System.Windows.Forms.Label labelFirstPage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}