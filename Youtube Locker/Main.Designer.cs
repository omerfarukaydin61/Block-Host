namespace Youtube_Locker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnAllow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlock
            // 
            this.btnBlock.BackgroundImage = global::Youtube_Locker.Properties.Resources.YouTubeX;
            this.btnBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock.Location = new System.Drawing.Point(154, 13);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(135, 104);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnAllow
            // 
            this.btnAllow.BackgroundImage = global::Youtube_Locker.Properties.Resources.YouTube;
            this.btnAllow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllow.Location = new System.Drawing.Point(13, 13);
            this.btnAllow.Name = "btnAllow";
            this.btnAllow.Size = new System.Drawing.Size(135, 104);
            this.btnAllow.TabIndex = 3;
            this.btnAllow.UseVisualStyleBackColor = true;
            this.btnAllow.Click += new System.EventHandler(this.btnAllow_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 130);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnAllow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBlock;
        private Button btnAllow;
    }
}