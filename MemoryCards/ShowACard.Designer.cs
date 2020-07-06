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
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 50);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDontRem
            // 
            this.btnDontRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDontRem.Location = new System.Drawing.Point(228, 388);
            this.btnDontRem.Name = "btnDontRem";
            this.btnDontRem.Size = new System.Drawing.Size(174, 50);
            this.btnDontRem.TabIndex = 9;
            this.btnDontRem.Text = "Не помню";
            this.btnDontRem.UseVisualStyleBackColor = true;
            // 
            // btnRem
            // 
            this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRem.Location = new System.Drawing.Point(408, 388);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(174, 50);
            this.btnRem.TabIndex = 10;
            this.btnRem.Text = "Помню";
            this.btnRem.UseVisualStyleBackColor = true;
            // 
            // labelFirstPage
            // 
            this.labelFirstPage.AutoSize = true;
            this.labelFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstPage.Location = new System.Drawing.Point(355, 159);
            this.labelFirstPage.Name = "labelFirstPage";
            this.labelFirstPage.Size = new System.Drawing.Size(89, 24);
            this.labelFirstPage.TabIndex = 11;
            this.labelFirstPage.Text = "FirstPage";
            // 
            // labelSecondPage
            // 
            this.labelSecondPage.AutoSize = true;
            this.labelSecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondPage.Location = new System.Drawing.Point(355, 200);
            this.labelSecondPage.Name = "labelSecondPage";
            this.labelSecondPage.Size = new System.Drawing.Size(120, 24);
            this.labelSecondPage.TabIndex = 12;
            this.labelSecondPage.Text = "SecondPage";
            // 
            // ShowACard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSecondPage);
            this.Controls.Add(this.labelFirstPage);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnDontRem);
            this.Controls.Add(this.btnBack);
            this.Name = "ShowACard";
            this.Text = "ShowACard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDontRem;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Label labelFirstPage;
        private System.Windows.Forms.Label labelSecondPage;
    }
}