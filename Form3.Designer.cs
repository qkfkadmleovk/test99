namespace main
{
    partial class Form3
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.ptpic = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.lbhome = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbed = new System.Windows.Forms.Label();
            this.lbetc = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbhome = new System.Windows.Forms.TextBox();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.tbed = new System.Windows.Forms.TextBox();
            this.tbetc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(15, 15);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(231, 165);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // ptpic
            // 
            this.ptpic.Location = new System.Drawing.Point(252, 36);
            this.ptpic.Name = "ptpic";
            this.ptpic.Size = new System.Drawing.Size(110, 60);
            this.ptpic.TabIndex = 1;
            this.ptpic.Text = "사진추가";
            this.ptpic.UseVisualStyleBackColor = true;
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(368, 36);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(110, 60);
            this.btsave.TabIndex = 2;
            this.btsave.Text = "저장";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(368, 102);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(110, 60);
            this.btexit.TabIndex = 3;
            this.btexit.Text = "이전";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(13, 202);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(29, 12);
            this.lbname.TabIndex = 4;
            this.lbname.Text = "이름";
            // 
            // lbhome
            // 
            this.lbhome.AutoSize = true;
            this.lbhome.Location = new System.Drawing.Point(12, 234);
            this.lbhome.Name = "lbhome";
            this.lbhome.Size = new System.Drawing.Size(41, 12);
            this.lbhome.TabIndex = 5;
            this.lbhome.Text = "원산지";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(12, 266);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(53, 12);
            this.lbdate.TabIndex = 6;
            this.lbdate.Text = "구입날짜";
            // 
            // lbed
            // 
            this.lbed.AutoSize = true;
            this.lbed.Location = new System.Drawing.Point(12, 298);
            this.lbed.Name = "lbed";
            this.lbed.Size = new System.Drawing.Size(53, 12);
            this.lbed.TabIndex = 7;
            this.lbed.Text = "유통기한";
            // 
            // lbetc
            // 
            this.lbetc.AutoSize = true;
            this.lbetc.Location = new System.Drawing.Point(12, 330);
            this.lbetc.Name = "lbetc";
            this.lbetc.Size = new System.Drawing.Size(53, 12);
            this.lbetc.TabIndex = 8;
            this.lbetc.Text = "주의사항";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(68, 193);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(294, 21);
            this.tbname.TabIndex = 9;
            // 
            // tbhome
            // 
            this.tbhome.Location = new System.Drawing.Point(68, 225);
            this.tbhome.Name = "tbhome";
            this.tbhome.Size = new System.Drawing.Size(294, 21);
            this.tbhome.TabIndex = 10;
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(68, 257);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(294, 21);
            this.tbdate.TabIndex = 11;
            // 
            // tbed
            // 
            this.tbed.Location = new System.Drawing.Point(68, 289);
            this.tbed.Name = "tbed";
            this.tbed.Size = new System.Drawing.Size(294, 21);
            this.tbed.TabIndex = 12;
            // 
            // tbetc
            // 
            this.tbetc.Location = new System.Drawing.Point(68, 321);
            this.tbetc.Name = "tbetc";
            this.tbetc.Size = new System.Drawing.Size(294, 21);
            this.tbetc.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 374);
            this.Controls.Add(this.tbetc);
            this.Controls.Add(this.tbed);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.tbhome);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbetc);
            this.Controls.Add(this.lbed);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbhome);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.ptpic);
            this.Controls.Add(this.picture);
            this.Name = "Form3";
            this.Text = "추가";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button ptpic;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbhome;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbed;
        private System.Windows.Forms.Label lbetc;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbhome;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.TextBox tbed;
        private System.Windows.Forms.TextBox tbetc;
        internal System.Windows.Forms.Button btexit;
    }
}