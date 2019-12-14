namespace Elever
{
    partial class lösenord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lösenord));
            this.label5 = new System.Windows.Forms.Label();
            this.Bytt_btn = new System.Windows.Forms.Button();
            this.New_pass_again = new System.Windows.Forms.TextBox();
            this.New_pass = new System.Windows.Forms.TextBox();
            this.Cerent_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bytt lösenord";
            // 
            // Bytt_btn
            // 
            this.Bytt_btn.Location = new System.Drawing.Point(107, 293);
            this.Bytt_btn.Name = "Bytt_btn";
            this.Bytt_btn.Size = new System.Drawing.Size(75, 23);
            this.Bytt_btn.TabIndex = 18;
            this.Bytt_btn.Text = "Bytt";
            this.Bytt_btn.UseVisualStyleBackColor = true;
            this.Bytt_btn.Click += new System.EventHandler(this.Bytt_btn_Click);
            // 
            // New_pass_again
            // 
            this.New_pass_again.Location = new System.Drawing.Point(169, 230);
            this.New_pass_again.Name = "New_pass_again";
            this.New_pass_again.Size = new System.Drawing.Size(100, 20);
            this.New_pass_again.TabIndex = 17;
            this.New_pass_again.UseSystemPasswordChar = true;
            // 
            // New_pass
            // 
            this.New_pass.Location = new System.Drawing.Point(169, 188);
            this.New_pass.Name = "New_pass";
            this.New_pass.Size = new System.Drawing.Size(100, 20);
            this.New_pass.TabIndex = 16;
            this.New_pass.UseSystemPasswordChar = true;
            // 
            // Cerent_pass
            // 
            this.Cerent_pass.Location = new System.Drawing.Point(169, 145);
            this.Cerent_pass.Name = "Cerent_pass";
            this.Cerent_pass.Size = new System.Drawing.Size(100, 20);
            this.Cerent_pass.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Skriv det nya igen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nytt lösenord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aktuellt";
            // 
            // lösenord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elever.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(288, 328);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bytt_btn);
            this.Controls.Add(this.New_pass_again);
            this.Controls.Add(this.New_pass);
            this.Controls.Add(this.Cerent_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "lösenord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nytt Lösenord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bytt_btn;
        private System.Windows.Forms.TextBox New_pass_again;
        private System.Windows.Forms.TextBox New_pass;
        private System.Windows.Forms.TextBox Cerent_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}