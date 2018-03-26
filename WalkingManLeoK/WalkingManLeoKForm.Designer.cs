namespace WalkingManLeoK
{
    partial class frmWalkingManLeoK
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
            this.btnWalk = new System.Windows.Forms.Button();
            this.picWalk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWalk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWalk
            // 
            this.btnWalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalk.Location = new System.Drawing.Point(124, 12);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(86, 32);
            this.btnWalk.TabIndex = 0;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // picWalk
            // 
            this.picWalk.Image = global::WalkingManLeoK.Properties.Resources.walk1;
            this.picWalk.Location = new System.Drawing.Point(59, 69);
            this.picWalk.Name = "picWalk";
            this.picWalk.Size = new System.Drawing.Size(215, 226);
            this.picWalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWalk.TabIndex = 1;
            this.picWalk.TabStop = false;
            // 
            // frmWalkingManLeoK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 334);
            this.Controls.Add(this.picWalk);
            this.Controls.Add(this.btnWalk);
            this.Name = "frmWalkingManLeoK";
            this.Text = "Walking Man by Leo Kay";
            ((System.ComponentModel.ISupportInitialize)(this.picWalk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.PictureBox picWalk;
    }
}

