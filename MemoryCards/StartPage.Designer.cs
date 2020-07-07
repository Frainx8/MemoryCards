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
            this.LearnCardsbtn = new System.Windows.Forms.Button();
            this.WatchCardsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCardsbtn
            // 
            this.AddCardsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCardsbtn.Location = new System.Drawing.Point(103, 241);
            this.AddCardsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCardsbtn.Name = "AddCardsbtn";
            this.AddCardsbtn.Size = new System.Drawing.Size(232, 62);
            this.AddCardsbtn.TabIndex = 0;
            this.AddCardsbtn.Text = "Добавить карточки";
            this.AddCardsbtn.UseVisualStyleBackColor = true;
            this.AddCardsbtn.Click += new System.EventHandler(this.AddCardsbtn_Click);
            // 
            // LearnCardsbtn
            // 
            this.LearnCardsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LearnCardsbtn.Location = new System.Drawing.Point(404, 241);
            this.LearnCardsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.LearnCardsbtn.Name = "LearnCardsbtn";
            this.LearnCardsbtn.Size = new System.Drawing.Size(232, 62);
            this.LearnCardsbtn.TabIndex = 4;
            this.LearnCardsbtn.Text = "Учить карточки";
            this.LearnCardsbtn.UseVisualStyleBackColor = true;
            this.LearnCardsbtn.Click += new System.EventHandler(this.LearnCardsbtn_Click);
            // 
            // WatchCardsbtn
            // 
            this.WatchCardsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchCardsbtn.Location = new System.Drawing.Point(698, 241);
            this.WatchCardsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.WatchCardsbtn.Name = "WatchCardsbtn";
            this.WatchCardsbtn.Size = new System.Drawing.Size(232, 62);
            this.WatchCardsbtn.TabIndex = 5;
            this.WatchCardsbtn.Text = "Посмотреть карточки";
            this.WatchCardsbtn.UseVisualStyleBackColor = true;
            this.WatchCardsbtn.Click += new System.EventHandler(this.WatchCardsbtn_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.WatchCardsbtn);
            this.Controls.Add(this.LearnCardsbtn);
            this.Controls.Add(this.AddCardsbtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCardsbtn;
        private System.Windows.Forms.Button LearnCardsbtn;
        private System.Windows.Forms.Button WatchCardsbtn;
    }
}