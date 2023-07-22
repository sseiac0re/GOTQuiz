namespace GOTQuiz
{
    partial class Form1
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
            this.pl1 = new System.Windows.Forms.Panel();
            this.bnStart = new System.Windows.Forms.Button();
            this.lbInstruc = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl1
            // 
            this.pl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pl1.Controls.Add(this.bnStart);
            this.pl1.Controls.Add(this.lbInstruc);
            this.pl1.Controls.Add(this.lbName);
            this.pl1.Controls.Add(this.tbName);
            this.pl1.Controls.Add(this.lbTitle);
            this.pl1.Location = new System.Drawing.Point(64, 55);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(518, 410);
            this.pl1.TabIndex = 0;
            // 
            // bnStart
            // 
            this.bnStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bnStart.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnStart.Location = new System.Drawing.Point(205, 304);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(102, 35);
            this.bnStart.TabIndex = 4;
            this.bnStart.Text = "Start";
            this.bnStart.UseVisualStyleBackColor = false;
            this.bnStart.Click += new System.EventHandler(this.bnStart_Click);
            // 
            // lbInstruc
            // 
            this.lbInstruc.BackColor = System.Drawing.Color.Transparent;
            this.lbInstruc.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruc.ForeColor = System.Drawing.Color.White;
            this.lbInstruc.Location = new System.Drawing.Point(29, 55);
            this.lbInstruc.Name = "lbInstruc";
            this.lbInstruc.Size = new System.Drawing.Size(463, 114);
            this.lbInstruc.TabIndex = 3;
            this.lbInstruc.Text = "-";
            this.lbInstruc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(93, 186);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(200, 21);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Enter Name of Player:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(98, 206);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(317, 23);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(113, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(287, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Game Of Thrones Quiz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GOTQuiz.Properties.Resources.iron;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 530);
            this.Controls.Add(this.pl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbInstruc;
        private System.Windows.Forms.Button bnStart;
    }
}

