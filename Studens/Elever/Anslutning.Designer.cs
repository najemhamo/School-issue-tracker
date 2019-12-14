namespace Elever
{
    partial class Anslutning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anslutning));
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_ip = new System.Windows.Forms.TextBox();
            this.btn_anslut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serverns ip address";
            // 
            // tbx_ip
            // 
            this.tbx_ip.Location = new System.Drawing.Point(147, 53);
            this.tbx_ip.Name = "tbx_ip";
            this.tbx_ip.Size = new System.Drawing.Size(114, 20);
            this.tbx_ip.TabIndex = 4;
            // 
            // btn_anslut
            // 
            this.btn_anslut.Location = new System.Drawing.Point(283, 50);
            this.btn_anslut.Name = "btn_anslut";
            this.btn_anslut.Size = new System.Drawing.Size(75, 23);
            this.btn_anslut.TabIndex = 3;
            this.btn_anslut.Text = "Anslut";
            this.btn_anslut.UseVisualStyleBackColor = true;
            this.btn_anslut.Click += new System.EventHandler(this.btn_anslut_Click);
            // 
            // Anslutning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elever.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(379, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_ip);
            this.Controls.Add(this.btn_anslut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Anslutning";
            this.Text = "Anslutning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_ip;
        private System.Windows.Forms.Button btn_anslut;
    }
}