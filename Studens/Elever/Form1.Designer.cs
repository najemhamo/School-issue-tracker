namespace Elever
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
            this.Show_box = new System.Windows.Forms.CheckBox();
            this.Avbryte = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anslutningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show_box
            // 
            this.Show_box.AutoSize = true;
            this.Show_box.BackColor = System.Drawing.Color.Transparent;
            this.Show_box.Location = new System.Drawing.Point(212, 199);
            this.Show_box.Name = "Show_box";
            this.Show_box.Size = new System.Drawing.Size(53, 17);
            this.Show_box.TabIndex = 19;
            this.Show_box.Text = "Show";
            this.Show_box.UseVisualStyleBackColor = false;
            this.Show_box.CheckedChanged += new System.EventHandler(this.Show_box_CheckedChanged_1);
            // 
            // Avbryte
            // 
            this.Avbryte.Location = new System.Drawing.Point(22, 268);
            this.Avbryte.Name = "Avbryte";
            this.Avbryte.Size = new System.Drawing.Size(75, 23);
            this.Avbryte.TabIndex = 18;
            this.Avbryte.Text = "Avbryte";
            this.Avbryte.UseVisualStyleBackColor = true;
            this.Avbryte.Click += new System.EventHandler(this.Avbryte_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(179, 268);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 17;
            this.login.Text = "Logga in";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.Login_Click);
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "lösenord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Andvändnamn";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(103, 196);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(100, 20);
            this.password_box.TabIndex = 14;
            this.password_box.UseSystemPasswordChar = true;
            this.password_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_box_KeyDown);
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(103, 137);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(100, 20);
            this.username_box.TabIndex = 13;
            this.username_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_box_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inloggning För Elever";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Elever.Properties.Resources.BG;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anslutningToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anslutningToolStripMenuItem
            // 
            this.anslutningToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anslutningToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.anslutningToolStripMenuItem.Name = "anslutningToolStripMenuItem";
            this.anslutningToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.anslutningToolStripMenuItem.Text = "Anslutning";
            this.anslutningToolStripMenuItem.Click += new System.EventHandler(this.anslutningToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elever.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(275, 323);
            this.Controls.Add(this.Show_box);
            this.Controls.Add(this.Avbryte);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggning";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Show_box;
        private System.Windows.Forms.Button Avbryte;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anslutningToolStripMenuItem;
    }
}

