namespace Elever
{
    partial class ElevApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevApp));
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byttLösenordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omOssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avdelning_box = new System.Windows.Forms.TextBox();
            this.btn_Avbryt = new System.Windows.Forms.Button();
            this.Signatur_box = new System.Windows.Forms.TextBox();
            this.btn_Spara = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NejBtn = new System.Windows.Forms.RadioButton();
            this.JaBtn = new System.Windows.Forms.RadioButton();
            this.Prio_nud = new System.Windows.Forms.NumericUpDown();
            this.nud_OrderNr = new System.Windows.Forms.NumericUpDown();
            this.Bild_Box = new System.Windows.Forms.PictureBox();
            this.Beskrivning_box = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_uppdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Prio_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrderNr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bild_Box)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byttLösenordToolStripMenuItem,
            this.omOssToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // byttLösenordToolStripMenuItem
            // 
            this.byttLösenordToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.byttLösenordToolStripMenuItem.Name = "byttLösenordToolStripMenuItem";
            this.byttLösenordToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.byttLösenordToolStripMenuItem.Text = "Bytt lösenord";
            this.byttLösenordToolStripMenuItem.Click += new System.EventHandler(this.ByttLösenordToolStripMenuItem_Click);
            // 
            // omOssToolStripMenuItem
            // 
            this.omOssToolStripMenuItem.Name = "omOssToolStripMenuItem";
            this.omOssToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.omOssToolStripMenuItem.Text = "Om oss";
            this.omOssToolStripMenuItem.Click += new System.EventHandler(this.omOssToolStripMenuItem_Click);
            // 
            // avdelning_box
            // 
            this.avdelning_box.Location = new System.Drawing.Point(499, 85);
            this.avdelning_box.Name = "avdelning_box";
            this.avdelning_box.ReadOnly = true;
            this.avdelning_box.Size = new System.Drawing.Size(100, 20);
            this.avdelning_box.TabIndex = 55;
            // 
            // btn_Avbryt
            // 
            this.btn_Avbryt.Location = new System.Drawing.Point(44, 544);
            this.btn_Avbryt.Name = "btn_Avbryt";
            this.btn_Avbryt.Size = new System.Drawing.Size(93, 34);
            this.btn_Avbryt.TabIndex = 54;
            this.btn_Avbryt.Text = "Avbryt";
            this.btn_Avbryt.UseVisualStyleBackColor = true;
            this.btn_Avbryt.Click += new System.EventHandler(this.Btn_Avbryt_Click);
            // 
            // Signatur_box
            // 
            this.Signatur_box.Location = new System.Drawing.Point(627, 480);
            this.Signatur_box.Name = "Signatur_box";
            this.Signatur_box.Size = new System.Drawing.Size(100, 20);
            this.Signatur_box.TabIndex = 53;
            // 
            // btn_Spara
            // 
            this.btn_Spara.Location = new System.Drawing.Point(794, 544);
            this.btn_Spara.Name = "btn_Spara";
            this.btn_Spara.Size = new System.Drawing.Size(93, 34);
            this.btn_Spara.TabIndex = 52;
            this.btn_Spara.Text = "Spara";
            this.btn_Spara.UseVisualStyleBackColor = true;
            this.btn_Spara.Click += new System.EventHandler(this.btn_Spara_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(605, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "Signatur (Klart)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(394, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "Påbörjat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(131, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Prio ( 1 -  4 )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(592, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Bild";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(187, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Beskrivning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(495, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Avdelning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Order Nummer";
            // 
            // NejBtn
            // 
            this.NejBtn.AutoSize = true;
            this.NejBtn.BackColor = System.Drawing.Color.Transparent;
            this.NejBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NejBtn.Location = new System.Drawing.Point(404, 493);
            this.NejBtn.Name = "NejBtn";
            this.NejBtn.Size = new System.Drawing.Size(47, 20);
            this.NejBtn.TabIndex = 44;
            this.NejBtn.TabStop = true;
            this.NejBtn.Text = "Nej";
            this.NejBtn.UseVisualStyleBackColor = false;
            // 
            // JaBtn
            // 
            this.JaBtn.AutoSize = true;
            this.JaBtn.BackColor = System.Drawing.Color.Transparent;
            this.JaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JaBtn.Location = new System.Drawing.Point(404, 459);
            this.JaBtn.Name = "JaBtn";
            this.JaBtn.Size = new System.Drawing.Size(41, 20);
            this.JaBtn.TabIndex = 43;
            this.JaBtn.TabStop = true;
            this.JaBtn.Text = "Ja";
            this.JaBtn.UseVisualStyleBackColor = false;
            // 
            // Prio_nud
            // 
            this.Prio_nud.Location = new System.Drawing.Point(137, 457);
            this.Prio_nud.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Prio_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prio_nud.Name = "Prio_nud";
            this.Prio_nud.ReadOnly = true;
            this.Prio_nud.Size = new System.Drawing.Size(110, 20);
            this.Prio_nud.TabIndex = 42;
            this.Prio_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_OrderNr
            // 
            this.nud_OrderNr.Location = new System.Drawing.Point(274, 85);
            this.nud_OrderNr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_OrderNr.Name = "nud_OrderNr";
            this.nud_OrderNr.Size = new System.Drawing.Size(120, 20);
            this.nud_OrderNr.TabIndex = 39;
            this.nud_OrderNr.ValueChanged += new System.EventHandler(this.Nud_OrderNr_ValueChanged);
            // 
            // Bild_Box
            // 
            this.Bild_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bild_Box.Location = new System.Drawing.Point(499, 181);
            this.Bild_Box.Name = "Bild_Box";
            this.Bild_Box.Size = new System.Drawing.Size(240, 186);
            this.Bild_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bild_Box.TabIndex = 41;
            this.Bild_Box.TabStop = false;
            // 
            // Beskrivning_box
            // 
            this.Beskrivning_box.Location = new System.Drawing.Point(145, 181);
            this.Beskrivning_box.Multiline = true;
            this.Beskrivning_box.Name = "Beskrivning_box";
            this.Beskrivning_box.ReadOnly = true;
            this.Beskrivning_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Beskrivning_box.Size = new System.Drawing.Size(223, 186);
            this.Beskrivning_box.TabIndex = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 28);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_uppdate
            // 
            this.btn_uppdate.Location = new System.Drawing.Point(750, 49);
            this.btn_uppdate.Name = "btn_uppdate";
            this.btn_uppdate.Size = new System.Drawing.Size(75, 23);
            this.btn_uppdate.TabIndex = 57;
            this.btn_uppdate.Text = "Uppdatera";
            this.btn_uppdate.UseVisualStyleBackColor = true;
            this.btn_uppdate.Click += new System.EventHandler(this.btn_uppdate_Click);
            // 
            // ElevApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elever.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.btn_uppdate);
            this.Controls.Add(this.avdelning_box);
            this.Controls.Add(this.btn_Avbryt);
            this.Controls.Add(this.Signatur_box);
            this.Controls.Add(this.btn_Spara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NejBtn);
            this.Controls.Add(this.JaBtn);
            this.Controls.Add(this.Prio_nud);
            this.Controls.Add(this.nud_OrderNr);
            this.Controls.Add(this.Bild_Box);
            this.Controls.Add(this.Beskrivning_box);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ElevApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elev Ordrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElevApp_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Prio_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrderNr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bild_Box)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byttLösenordToolStripMenuItem;
        private System.Windows.Forms.TextBox avdelning_box;
        private System.Windows.Forms.Button btn_Avbryt;
        private System.Windows.Forms.TextBox Signatur_box;
        private System.Windows.Forms.Button btn_Spara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton NejBtn;
        private System.Windows.Forms.RadioButton JaBtn;
        private System.Windows.Forms.NumericUpDown Prio_nud;
        private System.Windows.Forms.NumericUpDown nud_OrderNr;
        private System.Windows.Forms.PictureBox Bild_Box;
        private System.Windows.Forms.TextBox Beskrivning_box;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem omOssToolStripMenuItem;
        private System.Windows.Forms.Button btn_uppdate;
    }
}