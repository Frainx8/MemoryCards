namespace MemoryCards
{
    partial class StartPage
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
            this.AddCardsbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LearnCardsbtn = new System.Windows.Forms.Button();
            this.WatchCardsbtn = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCardsbtn
            // 
            this.AddCardsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCardsbtn.Location = new System.Drawing.Point(93, 65);
            this.AddCardsbtn.Name = "AddCardsbtn";
            this.AddCardsbtn.Size = new System.Drawing.Size(174, 50);
            this.AddCardsbtn.TabIndex = 0;
            this.AddCardsbtn.Text = "Добавить карточки";
            this.AddCardsbtn.UseVisualStyleBackColor = true;
            this.AddCardsbtn.Click += new System.EventHandler(this.AddCardsbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сегодня изучено";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LearnCardsbtn
            // 
            this.LearnCardsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LearnCardsbtn.Location = new System.Drawing.Point(319, 65);
            this.LearnCardsbtn.Name = "LearnCardsbtn";
            this.LearnCardsbtn.Size = new System.Drawing.Size(174, 50);
            this.LearnCardsbtn.TabIndex = 4;
            this.LearnCardsbtn.Text = "Учить карточки";
            this.LearnCardsbtn.UseVisualStyleBackColor = true;
            // 
            // WatchCardsbtn
            // 
            this.WatchCardsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchCardsbtn.Location = new System.Drawing.Point(539, 65);
            this.WatchCardsbtn.Name = "WatchCardsbtn";
            this.WatchCardsbtn.Size = new System.Drawing.Size(174, 50);
            this.WatchCardsbtn.TabIndex = 5;
            this.WatchCardsbtn.Text = "Посмотреть карточки";
            this.WatchCardsbtn.UseVisualStyleBackColor = true;
            this.WatchCardsbtn.Click += new System.EventHandler(this.WatchCardsbtn_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(431, 224);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(23, 24);
            this.labelN.TabIndex = 6;
            this.labelN.Text = "Н";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(460, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "карточек";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.WatchCardsbtn);
            this.Controls.Add(this.LearnCardsbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCardsbtn);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCardsbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LearnCardsbtn;
        private System.Windows.Forms.Button WatchCardsbtn;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label label3;
    }
}