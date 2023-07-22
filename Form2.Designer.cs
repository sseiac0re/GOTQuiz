namespace GOTQuiz
{
    partial class Form2
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
            this.lbQue = new System.Windows.Forms.Label();
            this.bn1 = new System.Windows.Forms.Button();
            this.bn2 = new System.Windows.Forms.Button();
            this.bn3 = new System.Windows.Forms.Button();
            this.bn4 = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQue
            // 
            this.lbQue.BackColor = System.Drawing.Color.Transparent;
            this.lbQue.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQue.ForeColor = System.Drawing.Color.Black;
            this.lbQue.Location = new System.Drawing.Point(23, 265);
            this.lbQue.Name = "lbQue";
            this.lbQue.Size = new System.Drawing.Size(599, 82);
            this.lbQue.TabIndex = 4;
            this.lbQue.Text = "-";
            this.lbQue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bn1
            // 
            this.bn1.Location = new System.Drawing.Point(26, 397);
            this.bn1.Name = "bn1";
            this.bn1.Size = new System.Drawing.Size(186, 38);
            this.bn1.TabIndex = 5;
            this.bn1.Tag = "1";
            this.bn1.Text = "button1";
            this.bn1.UseVisualStyleBackColor = true;
            this.bn1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // bn2
            // 
            this.bn2.Location = new System.Drawing.Point(26, 454);
            this.bn2.Name = "bn2";
            this.bn2.Size = new System.Drawing.Size(186, 37);
            this.bn2.TabIndex = 6;
            this.bn2.Tag = "2";
            this.bn2.Text = "button2";
            this.bn2.UseVisualStyleBackColor = true;
            this.bn2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // bn3
            // 
            this.bn3.Location = new System.Drawing.Point(436, 397);
            this.bn3.Name = "bn3";
            this.bn3.Size = new System.Drawing.Size(186, 37);
            this.bn3.TabIndex = 7;
            this.bn3.Tag = "3";
            this.bn3.Text = "button3";
            this.bn3.UseVisualStyleBackColor = true;
            this.bn3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // bn4
            // 
            this.bn4.Location = new System.Drawing.Point(436, 454);
            this.bn4.Name = "bn4";
            this.bn4.Size = new System.Drawing.Size(186, 37);
            this.bn4.TabIndex = 8;
            this.bn4.Tag = "4";
            this.bn4.Text = "button4";
            this.bn4.UseVisualStyleBackColor = true;
            this.bn4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // pb1
            // 
            this.pb1.Image = global::GOTQuiz.Properties.Resources.dany;
            this.pb1.Location = new System.Drawing.Point(23, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(599, 235);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(648, 530);
            this.Controls.Add(this.bn4);
            this.Controls.Add(this.bn3);
            this.Controls.Add(this.bn2);
            this.Controls.Add(this.bn1);
            this.Controls.Add(this.lbQue);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";

            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lbQue;
        private System.Windows.Forms.Button bn1;
        private System.Windows.Forms.Button bn2;
        private System.Windows.Forms.Button bn3;
        private System.Windows.Forms.Button bn4;
    }
}