namespace FinalApp
{
    partial class AnslutningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnslutningForm));
            this.btn_anslut = new System.Windows.Forms.Button();
            this.tbx_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_anslut
            // 
            this.btn_anslut.Location = new System.Drawing.Point(283, 63);
            this.btn_anslut.Name = "btn_anslut";
            this.btn_anslut.Size = new System.Drawing.Size(75, 23);
            this.btn_anslut.TabIndex = 0;
            this.btn_anslut.Text = "Anslut";
            this.btn_anslut.UseVisualStyleBackColor = true;
            this.btn_anslut.Click += new System.EventHandler(this.btn_anslut_Click);
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(130, 65);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(131, 20);
            this.tbx_ip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serverns ip address";
            // 
            // AnslutningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalApp.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(386, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_ip);
            this.Controls.Add(this.btn_anslut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnslutningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anslutning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnslutningForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnslutningForm_FormClosed);
            this.Load += new System.EventHandler(this.AnslutningForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anslut;
        private System.Windows.Forms.TextBox tbx_ip;
        private System.Windows.Forms.Label label1;
    }
}