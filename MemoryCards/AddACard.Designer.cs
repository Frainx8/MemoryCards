namespace MemoryCards
{
    partial class AddACard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.addACardbtn = new System.Windows.Forms.Button();
            this.AddFirstbox = new System.Windows.Forms.RichTextBox();
            this.AddSecondbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(381, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить карточку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(137, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Карточка спереди";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(137, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Карточка сзади";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(57, 455);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(232, 62);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // addACardbtn
            // 
            this.addACardbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addACardbtn.Location = new System.Drawing.Point(771, 455);
            this.addACardbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addACardbtn.Name = "addACardbtn";
            this.addACardbtn.Size = new System.Drawing.Size(232, 62);
            this.addACardbtn.TabIndex = 6;
            this.addACardbtn.Text = "Добавить";
            this.addACardbtn.UseVisualStyleBackColor = true;
            this.addACardbtn.Click += new System.EventHandler(this.addACardbtn_Click);
            // 
            // AddFirstbox
            // 
            this.AddFirstbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFirstbox.Location = new System.Drawing.Point(460, 224);
            this.AddFirstbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddFirstbox.Name = "AddFirstbox";
            this.AddFirstbox.Size = new System.Drawing.Size(541, 30);
            this.AddFirstbox.TabIndex = 7;
            this.AddFirstbox.Text = "";
            this.AddFirstbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // AddSecondbox
            // 
            this.AddSecondbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSecondbox.Location = new System.Drawing.Point(460, 290);
            this.AddSecondbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSecondbox.Name = "AddSecondbox";
            this.AddSecondbox.Size = new System.Drawing.Size(541, 30);
            this.AddSecondbox.TabIndex = 8;
            this.AddSecondbox.Text = "";
            // 
            // AddACard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AddSecondbox);
            this.Controls.Add(this.AddFirstbox);
            this.Controls.Add(this.addACardbtn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddACard";
            this.Text = "AddACard";
            this.Load += new System.EventHandler(this.AddACard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button addACardbtn;
        private System.Windows.Forms.RichTextBox AddFirstbox;
        private System.Windows.Forms.RichTextBox AddSecondbox;
    }
}