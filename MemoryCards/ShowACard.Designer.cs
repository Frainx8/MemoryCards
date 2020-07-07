namespace MemoryCards
{
    partial class ShowACard
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
            this.btnDontRem = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.labelFirstPage = new System.Windows.Forms.Label();
            this.labelSecondPage = new System.Windows.Forms.Label();
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
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDontRem
            // 
            this.btnDontRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDontRem.Location = new System.Drawing.Point(304, 478);
            this.btnDontRem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDontRem.Name = "btnDontRem";
            this.btnDontRem.Size = new System.Drawing.Size(232, 62);
            this.btnDontRem.TabIndex = 9;
            this.btnDontRem.Text = "Не помню";
            this.btnDontRem.UseVisualStyleBackColor = true;
            this.btnDontRem.Click += new System.EventHandler(this.btnDontRem_Click);
            // 
            // btnRem
            // 
            this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRem.Location = new System.Drawing.Point(544, 478);
            this.btnRem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(232, 62);
            this.btnRem.TabIndex = 10;
            this.btnRem.Text = "Помню";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // labelFirstPage
            // 
            this.labelFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstPage.Location = new System.Drawing.Point(7, 63);
            this.labelFirstPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstPage.Name = "labelFirstPage";
            this.labelFirstPage.Size = new System.Drawing.Size(485, 47);
            this.labelFirstPage.TabIndex = 11;
            this.labelFirstPage.Text = "FirstPage";
            this.labelFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondPage
            // 
            this.labelSecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondPage.Location = new System.Drawing.Point(7, 129);
            this.labelSecondPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecondPage.Name = "labelSecondPage";
            this.labelSecondPage.Size = new System.Drawing.Size(485, 40);
            this.labelSecondPage.TabIndex = 12;
            this.labelSecondPage.Text = "SecondPage";
            this.labelSecondPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.labelFirstPage);
            this.groupBox1.Controls.Add(this.labelSecondPage);
            this.groupBox1.Location = new System.Drawing.Point(291, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 259);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // ShowACard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnDontRem);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowACard";
            this.Text = "ShowACard";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDontRem;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Label labelFirstPage;
        private System.Windows.Forms.Label labelSecondPage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}