namespace ServerFinalApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbx_listan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbx_listan
            // 
            this.lbx_listan.FormattingEnabled = true;
            this.lbx_listan.Location = new System.Drawing.Point(56, 55);
            this.lbx_listan.Name = "lbx_listan";
            this.lbx_listan.Size = new System.Drawing.Size(438, 316);
            this.lbx_listan.TabIndex = 0;
            this.lbx_listan.SelectedIndexChanged += new System.EventHandler(this.lbx_listan_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServerFinalApp.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(572, 441);
            this.Controls.Add(this.lbx_listan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_listan;
    }
}

