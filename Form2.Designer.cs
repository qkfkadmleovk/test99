namespace main
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.btreceipe = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.lbhome = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbed = new System.Windows.Forms.Label();
            this.lbetc = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.bthome = new System.Windows.Forms.TextBox();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.tbed = new System.Windows.Forms.TextBox();
            this.tbetc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(29, 18);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(204, 128);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // btreceipe
            // 
            this.btreceipe.Location = new System.Drawing.Point(377, 17);
            this.btreceipe.Name = "btreceipe";
            this.btreceipe.Size = new System.Drawing.Size(150, 65);
            this.btreceipe.TabIndex = 1;
            this.btreceipe.Text = "추천레시피";
            this.btreceipe.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(377, 88);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(150, 65);
            this.btexit.TabIndex = 2;
            this.btexit.Text = "나가기";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(29, 179);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(29, 12);
            this.lbname.TabIndex = 3;
            this.lbname.Text = "이름";
            // 
            // lbhome
            // 
            this.lbhome.AutoSize = true;
            this.lbhome.Location = new System.Drawing.Point(29, 215);
            this.lbhome.Name = "lbhome";
            this.lbhome.Size = new System.Drawing.Size(41, 12);
            this.lbhome.TabIndex = 4;
            this.lbhome.Text = "원산지";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(29, 251);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(53, 12);
            this.lbdate.TabIndex = 5;
            this.lbdate.Text = "구입날짜";
            // 
            // lbed
            // 
            this.lbed.AutoSize = true;
            this.lbed.Location = new System.Drawing.Point(29, 287);
            this.lbed.Name = "lbed";
            this.lbed.Size = new System.Drawing.Size(53, 12);
            this.lbed.TabIndex = 6;
            this.lbed.Text = "유통기한";
            // 
            // lbetc
            // 
            this.lbetc.AutoSize = true;
            this.lbetc.Location = new System.Drawing.Point(29, 323);
            this.lbetc.Name = "lbetc";
            this.lbetc.Size = new System.Drawing.Size(53, 12);
            this.lbetc.TabIndex = 7;
            this.lbetc.Text = "유의사항";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(103, 170);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(274, 21);
            this.tbname.TabIndex = 8;
            // 
            // bthome
            // 
            this.bthome.Location = new System.Drawing.Point(103, 206);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(274, 21);
            this.bthome.TabIndex = 9;
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(103, 242);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(274, 21);
            this.tbdate.TabIndex = 10;
            // 
            // tbed
            // 
            this.tbed.Location = new System.Drawing.Point(103, 278);
            this.tbed.Name = "tbed";
            this.tbed.Size = new System.Drawing.Size(274, 21);
            this.tbed.TabIndex = 11;
            // 
            // tbetc
            // 
            this.tbetc.Location = new System.Drawing.Point(103, 314);
            this.tbetc.Name = "tbetc";
            this.tbetc.Size = new System.Drawing.Size(274, 21);
            this.tbetc.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 366);
            this.Controls.Add(this.tbetc);
            this.Controls.Add(this.tbed);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.bthome);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbetc);
            this.Controls.Add(this.lbed);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbhome);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btreceipe);
            this.Controls.Add(this.picture);
            this.Name = "Form2";
            this.Text = "정보";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btreceipe;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbhome;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbed;
        private System.Windows.Forms.Label lbetc;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox bthome;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.TextBox tbed;
        private System.Windows.Forms.TextBox tbetc;
        internal System.Windows.Forms.Button btexit;
    }
}