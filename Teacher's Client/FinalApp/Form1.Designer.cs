namespace FinalApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansvarigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansvarigaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avdelningarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omOssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anslutningenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbx_datum = new System.Windows.Forms.TextBox();
            this.btn_Spara = new System.Windows.Forms.Button();
            this.btn_InfogaBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_NejBtn = new System.Windows.Forms.RadioButton();
            this.rdb_JaBtn = new System.Windows.Forms.RadioButton();
            this.nud_Prio = new System.Windows.Forms.NumericUpDown();
            this.nud_OrderNr = new System.Windows.Forms.NumericUpDown();
            this.pbx_BildBox = new System.Windows.Forms.PictureBox();
            this.cbx_Avdelning = new System.Windows.Forms.ComboBox();
            this.tbx_Beskrivning = new System.Windows.Forms.TextBox();
            this.cbx_Ansvaring = new System.Windows.Forms.ComboBox();
            this.pnl_app = new System.Windows.Forms.Panel();
            this.btn_Avbryt = new System.Windows.Forms.Button();
            this.tpc_Tabell = new System.Windows.Forms.TabControl();
            this.tpg_order = new System.Windows.Forms.TabPage();
            this.btn_VisaAllaOrder = new System.Windows.Forms.Button();
            this.cbx_SearchWord = new System.Windows.Forms.ComboBox();
            this.btn_OrderUpdate = new System.Windows.Forms.Button();
            this.btn_OrderRemove = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cbx_SearchOrder = new System.Windows.Forms.ComboBox();
            this.btn_Sok = new System.Windows.Forms.Button();
            this.tbx_KlarOrder = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rdb_nejOrder = new System.Windows.Forms.RadioButton();
            this.rdb_jaOrder = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.nud_PrioOrder = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_avdelningarOrdrar = new System.Windows.Forms.ComboBox();
            this.cbx_ansvarigaOrdrar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_orderNr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_ordrar = new System.Windows.Forms.DataGridView();
            this.col_Ordnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_amsvarig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_avdelning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Prio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Börjat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_klar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpg_avdelning = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx_AvdelningSok = new System.Windows.Forms.TextBox();
            this.btn_searchAvdelning = new System.Windows.Forms.Button();
            this.btn_AvdelningRemove = new System.Windows.Forms.Button();
            this.btn_AddAvdelning = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_avdelningAdd = new System.Windows.Forms.TextBox();
            this.dgv_Avdelningar = new System.Windows.Forms.DataGridView();
            this.col_avdelningar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpg_elever = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx_ElevNamn = new System.Windows.Forms.TextBox();
            this.btn_SokElev = new System.Windows.Forms.Button();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.tbx_StudentName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_RemoveStudent = new System.Windows.Forms.Button();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.dgv_elever = new System.Windows.Forms.DataGridView();
            this.col_Elever = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Losen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Prio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrderNr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BildBox)).BeginInit();
            this.pnl_app.SuspendLayout();
            this.tpc_Tabell.SuspendLayout();
            this.tpg_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PrioOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordrar)).BeginInit();
            this.tpg_avdelning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Avdelningar)).BeginInit();
            this.tpg_elever.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_elever)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg Filer|*.jpg|png Filer|*.png";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menyToolStripMenuItem,
            this.anslutningenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menyToolStripMenuItem
            // 
            this.menyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyOrderToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.ansvarigaToolStripMenuItem,
            this.avslutaToolStripMenuItem,
            this.omOssToolStripMenuItem,
            this.ordrarToolStripMenuItem});
            this.menyToolStripMenuItem.Name = "menyToolStripMenuItem";
            this.menyToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.menyToolStripMenuItem.Text = "Meny";
            // 
            // nyOrderToolStripMenuItem
            // 
            this.nyOrderToolStripMenuItem.Name = "nyOrderToolStripMenuItem";
            this.nyOrderToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nyOrderToolStripMenuItem.Text = "Ny Order";
            this.nyOrderToolStripMenuItem.Click += new System.EventHandler(this.nyOrderToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sparaToolStripMenuItem.Text = "Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // ansvarigaToolStripMenuItem
            // 
            this.ansvarigaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ansvarigaToolStripMenuItem1,
            this.avdelningarToolStripMenuItem1,
            this.orderarToolStripMenuItem1});
            this.ansvarigaToolStripMenuItem.Name = "ansvarigaToolStripMenuItem";
            this.ansvarigaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ansvarigaToolStripMenuItem.Text = "Listor";
            // 
            // ansvarigaToolStripMenuItem1
            // 
            this.ansvarigaToolStripMenuItem1.Name = "ansvarigaToolStripMenuItem1";
            this.ansvarigaToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.ansvarigaToolStripMenuItem1.Text = "Elever";
            this.ansvarigaToolStripMenuItem1.Click += new System.EventHandler(this.ansvarigaToolStripMenuItem1_Click);
            // 
            // avdelningarToolStripMenuItem1
            // 
            this.avdelningarToolStripMenuItem1.Name = "avdelningarToolStripMenuItem1";
            this.avdelningarToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.avdelningarToolStripMenuItem1.Text = "Avdelningar";
            this.avdelningarToolStripMenuItem1.Click += new System.EventHandler(this.avdelningarToolStripMenuItem1_Click);
            // 
            // orderarToolStripMenuItem1
            // 
            this.orderarToolStripMenuItem1.Name = "orderarToolStripMenuItem1";
            this.orderarToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.orderarToolStripMenuItem1.Text = "Orderar";
            this.orderarToolStripMenuItem1.Click += new System.EventHandler(this.orderarToolStripMenuItem1_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.avslutaToolStripMenuItem.Text = "Ordrar";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // omOssToolStripMenuItem
            // 
            this.omOssToolStripMenuItem.Name = "omOssToolStripMenuItem";
            this.omOssToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.omOssToolStripMenuItem.Text = "Om oss";
            this.omOssToolStripMenuItem.Click += new System.EventHandler(this.OmOssToolStripMenuItem_Click);
            // 
            // ordrarToolStripMenuItem
            // 
            this.ordrarToolStripMenuItem.Name = "ordrarToolStripMenuItem";
            this.ordrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ordrarToolStripMenuItem.Text = "Avsluta";
            this.ordrarToolStripMenuItem.Click += new System.EventHandler(this.ordrarToolStripMenuItem_Click);
            // 
            // anslutningenToolStripMenuItem
            // 
            this.anslutningenToolStripMenuItem.Name = "anslutningenToolStripMenuItem";
            this.anslutningenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.anslutningenToolStripMenuItem.Text = "Anslutningen";
            this.anslutningenToolStripMenuItem.Click += new System.EventHandler(this.anslutningenToolStripMenuItem_Click);
            // 
            // tbx_datum
            // 
            this.tbx_datum.Location = new System.Drawing.Point(647, 409);
            this.tbx_datum.Name = "tbx_datum";
            this.tbx_datum.ReadOnly = true;
            this.tbx_datum.Size = new System.Drawing.Size(100, 20);
            this.tbx_datum.TabIndex = 18;
            this.tbx_datum.TextChanged += new System.EventHandler(this.tbx_datum_TextChanged);
            // 
            // btn_Spara
            // 
            this.btn_Spara.Location = new System.Drawing.Point(779, 487);
            this.btn_Spara.Name = "btn_Spara";
            this.btn_Spara.Size = new System.Drawing.Size(96, 35);
            this.btn_Spara.TabIndex = 17;
            this.btn_Spara.Text = "Spara";
            this.btn_Spara.UseVisualStyleBackColor = true;
            this.btn_Spara.Click += new System.EventHandler(this.Spara_Click);
            // 
            // btn_InfogaBtn
            // 
            this.btn_InfogaBtn.Location = new System.Drawing.Point(556, 334);
            this.btn_InfogaBtn.Name = "btn_InfogaBtn";
            this.btn_InfogaBtn.Size = new System.Drawing.Size(110, 23);
            this.btn_InfogaBtn.TabIndex = 16;
            this.btn_InfogaBtn.Text = "Infoga en bild";
            this.btn_InfogaBtn.UseVisualStyleBackColor = true;
            this.btn_InfogaBtn.Click += new System.EventHandler(this.InfogaBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(631, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Signatur (Klart)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(383, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Påbörjat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prio ( 1 -  4 )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bild";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Beskrivning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ansvaring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Avdelning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order Nummer";
            // 
            // rdb_NejBtn
            // 
            this.rdb_NejBtn.AutoSize = true;
            this.rdb_NejBtn.BackColor = System.Drawing.Color.Transparent;
            this.rdb_NejBtn.Enabled = false;
            this.rdb_NejBtn.Location = new System.Drawing.Point(418, 447);
            this.rdb_NejBtn.Name = "rdb_NejBtn";
            this.rdb_NejBtn.Size = new System.Drawing.Size(41, 17);
            this.rdb_NejBtn.TabIndex = 7;
            this.rdb_NejBtn.TabStop = true;
            this.rdb_NejBtn.Text = "Nej";
            this.rdb_NejBtn.UseVisualStyleBackColor = false;
            this.rdb_NejBtn.CheckedChanged += new System.EventHandler(this.rdb_NejBtn_CheckedChanged);
            // 
            // rdb_JaBtn
            // 
            this.rdb_JaBtn.AutoSize = true;
            this.rdb_JaBtn.BackColor = System.Drawing.Color.Transparent;
            this.rdb_JaBtn.Enabled = false;
            this.rdb_JaBtn.Location = new System.Drawing.Point(418, 413);
            this.rdb_JaBtn.Name = "rdb_JaBtn";
            this.rdb_JaBtn.Size = new System.Drawing.Size(36, 17);
            this.rdb_JaBtn.TabIndex = 6;
            this.rdb_JaBtn.TabStop = true;
            this.rdb_JaBtn.Text = "Ja";
            this.rdb_JaBtn.UseVisualStyleBackColor = false;
            this.rdb_JaBtn.CheckedChanged += new System.EventHandler(this.rdb_JaBtn_CheckedChanged);
            // 
            // nud_Prio
            // 
            this.nud_Prio.Location = new System.Drawing.Point(120, 410);
            this.nud_Prio.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_Prio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Prio.Name = "nud_Prio";
            this.nud_Prio.Size = new System.Drawing.Size(120, 20);
            this.nud_Prio.TabIndex = 5;
            this.nud_Prio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Prio.ValueChanged += new System.EventHandler(this.nud_Prio_ValueChanged);
            // 
            // nud_OrderNr
            // 
            this.nud_OrderNr.Location = new System.Drawing.Point(143, 37);
            this.nud_OrderNr.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nud_OrderNr.Name = "nud_OrderNr";
            this.nud_OrderNr.Size = new System.Drawing.Size(120, 20);
            this.nud_OrderNr.TabIndex = 0;
            this.nud_OrderNr.ValueChanged += new System.EventHandler(this.OrderNr_ValueChanged);
            // 
            // pbx_BildBox
            // 
            this.pbx_BildBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_BildBox.Location = new System.Drawing.Point(490, 152);
            this.pbx_BildBox.Name = "pbx_BildBox";
            this.pbx_BildBox.Size = new System.Drawing.Size(240, 176);
            this.pbx_BildBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_BildBox.TabIndex = 4;
            this.pbx_BildBox.TabStop = false;
            // 
            // cbx_Avdelning
            // 
            this.cbx_Avdelning.FormattingEnabled = true;
            this.cbx_Avdelning.Location = new System.Drawing.Point(362, 36);
            this.cbx_Avdelning.Name = "cbx_Avdelning";
            this.cbx_Avdelning.Size = new System.Drawing.Size(121, 21);
            this.cbx_Avdelning.TabIndex = 1;
            this.cbx_Avdelning.TextChanged += new System.EventHandler(this.Avdelning_TextChanged);
            // 
            // tbx_Beskrivning
            // 
            this.tbx_Beskrivning.Location = new System.Drawing.Point(132, 152);
            this.tbx_Beskrivning.Multiline = true;
            this.tbx_Beskrivning.Name = "tbx_Beskrivning";
            this.tbx_Beskrivning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Beskrivning.Size = new System.Drawing.Size(223, 186);
            this.tbx_Beskrivning.TabIndex = 3;
            this.tbx_Beskrivning.TextChanged += new System.EventHandler(this.Beskrivning_TextChanged);
            // 
            // cbx_Ansvaring
            // 
            this.cbx_Ansvaring.FormattingEnabled = true;
            this.cbx_Ansvaring.Location = new System.Drawing.Point(597, 37);
            this.cbx_Ansvaring.Name = "cbx_Ansvaring";
            this.cbx_Ansvaring.Size = new System.Drawing.Size(121, 21);
            this.cbx_Ansvaring.TabIndex = 2;
            this.cbx_Ansvaring.TextChanged += new System.EventHandler(this.Ansvaring_TextChanged);
            // 
            // pnl_app
            // 
            this.pnl_app.BackColor = System.Drawing.Color.Transparent;
            this.pnl_app.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_app.Controls.Add(this.btn_Avbryt);
            this.pnl_app.Controls.Add(this.tbx_datum);
            this.pnl_app.Controls.Add(this.btn_Spara);
            this.pnl_app.Controls.Add(this.btn_InfogaBtn);
            this.pnl_app.Controls.Add(this.label8);
            this.pnl_app.Controls.Add(this.label7);
            this.pnl_app.Controls.Add(this.label6);
            this.pnl_app.Controls.Add(this.label5);
            this.pnl_app.Controls.Add(this.label4);
            this.pnl_app.Controls.Add(this.label3);
            this.pnl_app.Controls.Add(this.label2);
            this.pnl_app.Controls.Add(this.label1);
            this.pnl_app.Controls.Add(this.rdb_NejBtn);
            this.pnl_app.Controls.Add(this.rdb_JaBtn);
            this.pnl_app.Controls.Add(this.nud_Prio);
            this.pnl_app.Controls.Add(this.nud_OrderNr);
            this.pnl_app.Controls.Add(this.pbx_BildBox);
            this.pnl_app.Controls.Add(this.cbx_Avdelning);
            this.pnl_app.Controls.Add(this.tbx_Beskrivning);
            this.pnl_app.Controls.Add(this.cbx_Ansvaring);
            this.pnl_app.Location = new System.Drawing.Point(1, 26);
            this.pnl_app.Name = "pnl_app";
            this.pnl_app.Size = new System.Drawing.Size(907, 540);
            this.pnl_app.TabIndex = 7;
            // 
            // btn_Avbryt
            // 
            this.btn_Avbryt.Location = new System.Drawing.Point(30, 487);
            this.btn_Avbryt.Name = "btn_Avbryt";
            this.btn_Avbryt.Size = new System.Drawing.Size(97, 32);
            this.btn_Avbryt.TabIndex = 19;
            this.btn_Avbryt.Text = "Avbryt";
            this.btn_Avbryt.UseVisualStyleBackColor = true;
            this.btn_Avbryt.Click += new System.EventHandler(this.Avbryt_Click);
            // 
            // tpc_Tabell
            // 
            this.tpc_Tabell.Controls.Add(this.tpg_order);
            this.tpc_Tabell.Controls.Add(this.tpg_avdelning);
            this.tpc_Tabell.Controls.Add(this.tpg_elever);
            this.tpc_Tabell.Location = new System.Drawing.Point(0, 21);
            this.tpc_Tabell.Name = "tpc_Tabell";
            this.tpc_Tabell.SelectedIndex = 0;
            this.tpc_Tabell.Size = new System.Drawing.Size(903, 542);
            this.tpc_Tabell.TabIndex = 9;
            this.tpc_Tabell.Visible = false;
            // 
            // tpg_order
            // 
            this.tpg_order.BackgroundImage = global::FinalApp.Properties.Resources.BG;
            this.tpg_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpg_order.Controls.Add(this.btn_VisaAllaOrder);
            this.tpg_order.Controls.Add(this.cbx_SearchWord);
            this.tpg_order.Controls.Add(this.btn_OrderUpdate);
            this.tpg_order.Controls.Add(this.btn_OrderRemove);
            this.tpg_order.Controls.Add(this.label15);
            this.tpg_order.Controls.Add(this.cbx_SearchOrder);
            this.tpg_order.Controls.Add(this.btn_Sok);
            this.tpg_order.Controls.Add(this.tbx_KlarOrder);
            this.tpg_order.Controls.Add(this.label14);
            this.tpg_order.Controls.Add(this.rdb_nejOrder);
            this.tpg_order.Controls.Add(this.rdb_jaOrder);
            this.tpg_order.Controls.Add(this.label13);
            this.tpg_order.Controls.Add(this.nud_PrioOrder);
            this.tpg_order.Controls.Add(this.label12);
            this.tpg_order.Controls.Add(this.cbx_avdelningarOrdrar);
            this.tpg_order.Controls.Add(this.cbx_ansvarigaOrdrar);
            this.tpg_order.Controls.Add(this.label11);
            this.tpg_order.Controls.Add(this.label10);
            this.tpg_order.Controls.Add(this.tbx_orderNr);
            this.tpg_order.Controls.Add(this.label9);
            this.tpg_order.Controls.Add(this.dgv_ordrar);
            this.tpg_order.Location = new System.Drawing.Point(4, 22);
            this.tpg_order.Name = "tpg_order";
            this.tpg_order.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_order.Size = new System.Drawing.Size(895, 516);
            this.tpg_order.TabIndex = 0;
            this.tpg_order.Text = "Ordrar";
            this.tpg_order.UseVisualStyleBackColor = true;
            this.tpg_order.Click += new System.EventHandler(this.tpg_order_Click);
            // 
            // btn_VisaAllaOrder
            // 
            this.btn_VisaAllaOrder.Location = new System.Drawing.Point(783, 15);
            this.btn_VisaAllaOrder.Name = "btn_VisaAllaOrder";
            this.btn_VisaAllaOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_VisaAllaOrder.TabIndex = 22;
            this.btn_VisaAllaOrder.Text = "Visa alla ";
            this.btn_VisaAllaOrder.UseVisualStyleBackColor = true;
            this.btn_VisaAllaOrder.Click += new System.EventHandler(this.btn_VisaAllaOrder_Click);
            // 
            // cbx_SearchWord
            // 
            this.cbx_SearchWord.FormattingEnabled = true;
            this.cbx_SearchWord.Location = new System.Drawing.Point(529, 14);
            this.cbx_SearchWord.Name = "cbx_SearchWord";
            this.cbx_SearchWord.Size = new System.Drawing.Size(121, 21);
            this.cbx_SearchWord.TabIndex = 21;
            // 
            // btn_OrderUpdate
            // 
            this.btn_OrderUpdate.Location = new System.Drawing.Point(94, 391);
            this.btn_OrderUpdate.Name = "btn_OrderUpdate";
            this.btn_OrderUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_OrderUpdate.TabIndex = 20;
            this.btn_OrderUpdate.Text = "Uppdatera";
            this.btn_OrderUpdate.UseVisualStyleBackColor = true;
            this.btn_OrderUpdate.Click += new System.EventHandler(this.btn_OrderUpdate_Click);
            // 
            // btn_OrderRemove
            // 
            this.btn_OrderRemove.Location = new System.Drawing.Point(94, 425);
            this.btn_OrderRemove.Name = "btn_OrderRemove";
            this.btn_OrderRemove.Size = new System.Drawing.Size(75, 23);
            this.btn_OrderRemove.TabIndex = 19;
            this.btn_OrderRemove.Text = "Ta bort";
            this.btn_OrderRemove.UseVisualStyleBackColor = true;
            this.btn_OrderRemove.Click += new System.EventHandler(this.btn_OrderRemove_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Sök via";
            // 
            // cbx_SearchOrder
            // 
            this.cbx_SearchOrder.FormattingEnabled = true;
            this.cbx_SearchOrder.Items.AddRange(new object[] {
            "Ansvariga",
            "Avdelningar"});
            this.cbx_SearchOrder.Location = new System.Drawing.Point(380, 14);
            this.cbx_SearchOrder.Name = "cbx_SearchOrder";
            this.cbx_SearchOrder.Size = new System.Drawing.Size(121, 21);
            this.cbx_SearchOrder.TabIndex = 17;
            this.cbx_SearchOrder.SelectedIndexChanged += new System.EventHandler(this.cbx_SearchOrder_SelectedIndexChanged);
            // 
            // btn_Sok
            // 
            this.btn_Sok.Location = new System.Drawing.Point(683, 14);
            this.btn_Sok.Name = "btn_Sok";
            this.btn_Sok.Size = new System.Drawing.Size(75, 23);
            this.btn_Sok.TabIndex = 15;
            this.btn_Sok.Text = "Sök";
            this.btn_Sok.UseVisualStyleBackColor = true;
            this.btn_Sok.Click += new System.EventHandler(this.btn_Sok_Click);
            // 
            // tbx_KlarOrder
            // 
            this.tbx_KlarOrder.Location = new System.Drawing.Point(93, 345);
            this.tbx_KlarOrder.Name = "tbx_KlarOrder";
            this.tbx_KlarOrder.ReadOnly = true;
            this.tbx_KlarOrder.Size = new System.Drawing.Size(100, 20);
            this.tbx_KlarOrder.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Klar";
            // 
            // rdb_nejOrder
            // 
            this.rdb_nejOrder.AutoSize = true;
            this.rdb_nejOrder.Location = new System.Drawing.Point(93, 296);
            this.rdb_nejOrder.Name = "rdb_nejOrder";
            this.rdb_nejOrder.Size = new System.Drawing.Size(41, 17);
            this.rdb_nejOrder.TabIndex = 12;
            this.rdb_nejOrder.Text = "Nej";
            this.rdb_nejOrder.UseVisualStyleBackColor = true;
            // 
            // rdb_jaOrder
            // 
            this.rdb_jaOrder.AutoSize = true;
            this.rdb_jaOrder.Location = new System.Drawing.Point(94, 256);
            this.rdb_jaOrder.Name = "rdb_jaOrder";
            this.rdb_jaOrder.Size = new System.Drawing.Size(36, 17);
            this.rdb_jaOrder.TabIndex = 11;
            this.rdb_jaOrder.Text = "Ja";
            this.rdb_jaOrder.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Börjat";
            // 
            // nud_PrioOrder
            // 
            this.nud_PrioOrder.Location = new System.Drawing.Point(93, 200);
            this.nud_PrioOrder.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_PrioOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_PrioOrder.Name = "nud_PrioOrder";
            this.nud_PrioOrder.Size = new System.Drawing.Size(104, 20);
            this.nud_PrioOrder.TabIndex = 9;
            this.nud_PrioOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Prioritet";
            // 
            // cbx_avdelningarOrdrar
            // 
            this.cbx_avdelningarOrdrar.FormattingEnabled = true;
            this.cbx_avdelningarOrdrar.Location = new System.Drawing.Point(94, 141);
            this.cbx_avdelningarOrdrar.Name = "cbx_avdelningarOrdrar";
            this.cbx_avdelningarOrdrar.Size = new System.Drawing.Size(101, 21);
            this.cbx_avdelningarOrdrar.TabIndex = 7;
            // 
            // cbx_ansvarigaOrdrar
            // 
            this.cbx_ansvarigaOrdrar.FormattingEnabled = true;
            this.cbx_ansvarigaOrdrar.Location = new System.Drawing.Point(93, 96);
            this.cbx_ansvarigaOrdrar.Name = "cbx_ansvarigaOrdrar";
            this.cbx_ansvarigaOrdrar.Size = new System.Drawing.Size(101, 21);
            this.cbx_ansvarigaOrdrar.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Avdelning";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ansvarig";
            // 
            // tbx_orderNr
            // 
            this.tbx_orderNr.Location = new System.Drawing.Point(94, 49);
            this.tbx_orderNr.Name = "tbx_orderNr";
            this.tbx_orderNr.ReadOnly = true;
            this.tbx_orderNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_orderNr.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "OrderNr";
            // 
            // dgv_ordrar
            // 
            this.dgv_ordrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Ordnr,
            this.col_amsvarig,
            this.col_avdelning,
            this.col_Prio,
            this.col_Börjat,
            this.col_klar});
            this.dgv_ordrar.Location = new System.Drawing.Point(227, 52);
            this.dgv_ordrar.Name = "dgv_ordrar";
            this.dgv_ordrar.ReadOnly = true;
            this.dgv_ordrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ordrar.Size = new System.Drawing.Size(651, 403);
            this.dgv_ordrar.TabIndex = 0;
            this.dgv_ordrar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordrar_RowEnter);
            this.dgv_ordrar.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv_ordrar_RowStateChanged);
            this.dgv_ordrar.SelectionChanged += new System.EventHandler(this.dgv_ordrar_SelectionChanged);
            // 
            // col_Ordnr
            // 
            this.col_Ordnr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Ordnr.HeaderText = "OrderNr";
            this.col_Ordnr.Name = "col_Ordnr";
            this.col_Ordnr.ReadOnly = true;
            // 
            // col_amsvarig
            // 
            this.col_amsvarig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_amsvarig.HeaderText = "Ansvarig";
            this.col_amsvarig.Name = "col_amsvarig";
            this.col_amsvarig.ReadOnly = true;
            // 
            // col_avdelning
            // 
            this.col_avdelning.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_avdelning.HeaderText = "Avdelning";
            this.col_avdelning.Name = "col_avdelning";
            this.col_avdelning.ReadOnly = true;
            // 
            // col_Prio
            // 
            this.col_Prio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Prio.HeaderText = "Prioritet";
            this.col_Prio.Name = "col_Prio";
            this.col_Prio.ReadOnly = true;
            // 
            // col_Börjat
            // 
            this.col_Börjat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Börjat.HeaderText = "Börjat";
            this.col_Börjat.Name = "col_Börjat";
            this.col_Börjat.ReadOnly = true;
            // 
            // col_klar
            // 
            this.col_klar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_klar.HeaderText = "Klar";
            this.col_klar.Name = "col_klar";
            this.col_klar.ReadOnly = true;
            // 
            // tpg_avdelning
            // 
            this.tpg_avdelning.BackgroundImage = global::FinalApp.Properties.Resources.BG;
            this.tpg_avdelning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpg_avdelning.Controls.Add(this.label20);
            this.tpg_avdelning.Controls.Add(this.tbx_AvdelningSok);
            this.tpg_avdelning.Controls.Add(this.btn_searchAvdelning);
            this.tpg_avdelning.Controls.Add(this.btn_AvdelningRemove);
            this.tpg_avdelning.Controls.Add(this.btn_AddAvdelning);
            this.tpg_avdelning.Controls.Add(this.label16);
            this.tpg_avdelning.Controls.Add(this.tbx_avdelningAdd);
            this.tpg_avdelning.Controls.Add(this.dgv_Avdelningar);
            this.tpg_avdelning.Location = new System.Drawing.Point(4, 22);
            this.tpg_avdelning.Name = "tpg_avdelning";
            this.tpg_avdelning.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_avdelning.Size = new System.Drawing.Size(895, 516);
            this.tpg_avdelning.TabIndex = 1;
            this.tpg_avdelning.Text = "Avdelningar";
            this.tpg_avdelning.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(506, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Avdelnings namn";
            // 
            // tbx_AvdelningSok
            // 
            this.tbx_AvdelningSok.Location = new System.Drawing.Point(613, 27);
            this.tbx_AvdelningSok.Name = "tbx_AvdelningSok";
            this.tbx_AvdelningSok.Size = new System.Drawing.Size(112, 20);
            this.tbx_AvdelningSok.TabIndex = 11;
            // 
            // btn_searchAvdelning
            // 
            this.btn_searchAvdelning.Location = new System.Drawing.Point(753, 25);
            this.btn_searchAvdelning.Name = "btn_searchAvdelning";
            this.btn_searchAvdelning.Size = new System.Drawing.Size(75, 23);
            this.btn_searchAvdelning.TabIndex = 10;
            this.btn_searchAvdelning.Text = "Sök";
            this.btn_searchAvdelning.UseVisualStyleBackColor = true;
            this.btn_searchAvdelning.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_AvdelningRemove
            // 
            this.btn_AvdelningRemove.Location = new System.Drawing.Point(51, 224);
            this.btn_AvdelningRemove.Name = "btn_AvdelningRemove";
            this.btn_AvdelningRemove.Size = new System.Drawing.Size(75, 23);
            this.btn_AvdelningRemove.TabIndex = 4;
            this.btn_AvdelningRemove.Text = "Ta bort";
            this.btn_AvdelningRemove.UseVisualStyleBackColor = true;
            this.btn_AvdelningRemove.Click += new System.EventHandler(this.btn_AvdelningRemove_Click);
            // 
            // btn_AddAvdelning
            // 
            this.btn_AddAvdelning.Location = new System.Drawing.Point(51, 172);
            this.btn_AddAvdelning.Name = "btn_AddAvdelning";
            this.btn_AddAvdelning.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAvdelning.TabIndex = 3;
            this.btn_AddAvdelning.Text = "Lägg till";
            this.btn_AddAvdelning.UseVisualStyleBackColor = true;
            this.btn_AddAvdelning.Click += new System.EventHandler(this.btn_AddAvdelning_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Avdelning";
            // 
            // tbx_avdelningAdd
            // 
            this.tbx_avdelningAdd.Location = new System.Drawing.Point(158, 98);
            this.tbx_avdelningAdd.Name = "tbx_avdelningAdd";
            this.tbx_avdelningAdd.Size = new System.Drawing.Size(136, 20);
            this.tbx_avdelningAdd.TabIndex = 1;
            // 
            // dgv_Avdelningar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Avdelningar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Avdelningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Avdelningar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_avdelningar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Avdelningar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Avdelningar.Location = new System.Drawing.Point(485, 68);
            this.dgv_Avdelningar.MultiSelect = false;
            this.dgv_Avdelningar.Name = "dgv_Avdelningar";
            this.dgv_Avdelningar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Avdelningar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Avdelningar.RowHeadersVisible = false;
            this.dgv_Avdelningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Avdelningar.Size = new System.Drawing.Size(392, 387);
            this.dgv_Avdelningar.TabIndex = 0;
            this.dgv_Avdelningar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Avdelningar_RowEnter);
            // 
            // col_avdelningar
            // 
            this.col_avdelningar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_avdelningar.HeaderText = "Avdelning";
            this.col_avdelningar.Name = "col_avdelningar";
            this.col_avdelningar.ReadOnly = true;
            // 
            // tpg_elever
            // 
            this.tpg_elever.BackgroundImage = global::FinalApp.Properties.Resources.BG;
            this.tpg_elever.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpg_elever.Controls.Add(this.label19);
            this.tpg_elever.Controls.Add(this.tbx_ElevNamn);
            this.tpg_elever.Controls.Add(this.btn_SokElev);
            this.tpg_elever.Controls.Add(this.tbx_Password);
            this.tpg_elever.Controls.Add(this.tbx_StudentName);
            this.tpg_elever.Controls.Add(this.label18);
            this.tpg_elever.Controls.Add(this.label17);
            this.tpg_elever.Controls.Add(this.btn_RemoveStudent);
            this.tpg_elever.Controls.Add(this.btn_AddStudent);
            this.tpg_elever.Controls.Add(this.dgv_elever);
            this.tpg_elever.Location = new System.Drawing.Point(4, 22);
            this.tpg_elever.Name = "tpg_elever";
            this.tpg_elever.Size = new System.Drawing.Size(895, 516);
            this.tpg_elever.TabIndex = 2;
            this.tpg_elever.Text = "Elever";
            this.tpg_elever.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(506, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Elevens namn";
            // 
            // tbx_ElevNamn
            // 
            this.tbx_ElevNamn.Location = new System.Drawing.Point(613, 32);
            this.tbx_ElevNamn.Name = "tbx_ElevNamn";
            this.tbx_ElevNamn.Size = new System.Drawing.Size(112, 20);
            this.tbx_ElevNamn.TabIndex = 8;
            // 
            // btn_SokElev
            // 
            this.btn_SokElev.Location = new System.Drawing.Point(753, 30);
            this.btn_SokElev.Name = "btn_SokElev";
            this.btn_SokElev.Size = new System.Drawing.Size(75, 23);
            this.btn_SokElev.TabIndex = 7;
            this.btn_SokElev.Text = "Sök";
            this.btn_SokElev.UseVisualStyleBackColor = true;
            this.btn_SokElev.Click += new System.EventHandler(this.btn_SokElev_Click);
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(182, 139);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(106, 20);
            this.tbx_Password.TabIndex = 6;
            // 
            // tbx_StudentName
            // 
            this.tbx_StudentName.Location = new System.Drawing.Point(182, 86);
            this.tbx_StudentName.Name = "tbx_StudentName";
            this.tbx_StudentName.Size = new System.Drawing.Size(106, 20);
            this.tbx_StudentName.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(61, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Lösenord";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Elevens namn";
            // 
            // btn_RemoveStudent
            // 
            this.btn_RemoveStudent.Location = new System.Drawing.Point(193, 270);
            this.btn_RemoveStudent.Name = "btn_RemoveStudent";
            this.btn_RemoveStudent.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveStudent.TabIndex = 2;
            this.btn_RemoveStudent.Text = "Ta bort";
            this.btn_RemoveStudent.UseVisualStyleBackColor = true;
            this.btn_RemoveStudent.Click += new System.EventHandler(this.btn_RemoveStudent_Click);
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Location = new System.Drawing.Point(193, 213);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(75, 23);
            this.btn_AddStudent.TabIndex = 1;
            this.btn_AddStudent.Text = "Lägg till";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // dgv_elever
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_elever.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_elever.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_elever.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Elever,
            this.col_Losen});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_elever.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_elever.Location = new System.Drawing.Point(450, 67);
            this.dgv_elever.Name = "dgv_elever";
            this.dgv_elever.RowHeadersVisible = false;
            this.dgv_elever.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_elever.Size = new System.Drawing.Size(429, 417);
            this.dgv_elever.TabIndex = 0;
            this.dgv_elever.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv_elever_RowStateChanged);
            // 
            // col_Elever
            // 
            this.col_Elever.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Elever.HeaderText = "Elev";
            this.col_Elever.Name = "col_Elever";
            // 
            // col_Losen
            // 
            this.col_Losen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Losen.HeaderText = "Lösenord";
            this.col_Losen.Name = "col_Losen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalApp.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 560);
            this.Controls.Add(this.tpc_Tabell);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_app);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Prio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrderNr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BildBox)).EndInit();
            this.pnl_app.ResumeLayout(false);
            this.pnl_app.PerformLayout();
            this.tpc_Tabell.ResumeLayout(false);
            this.tpg_order.ResumeLayout(false);
            this.tpg_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PrioOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordrar)).EndInit();
            this.tpg_avdelning.ResumeLayout(false);
            this.tpg_avdelning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Avdelningar)).EndInit();
            this.tpg_elever.ResumeLayout(false);
            this.tpg_elever.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_elever)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menyToolStripMenuItem;
        private System.Windows.Forms.TextBox tbx_datum;
        private System.Windows.Forms.Button btn_Spara;
        private System.Windows.Forms.Button btn_InfogaBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_NejBtn;
        private System.Windows.Forms.RadioButton rdb_JaBtn;
        private System.Windows.Forms.NumericUpDown nud_Prio;
        private System.Windows.Forms.NumericUpDown nud_OrderNr;
        private System.Windows.Forms.PictureBox pbx_BildBox;
        private System.Windows.Forms.ComboBox cbx_Avdelning;
        private System.Windows.Forms.TextBox tbx_Beskrivning;
        private System.Windows.Forms.ComboBox cbx_Ansvaring;
        private System.Windows.Forms.Panel pnl_app;
        private System.Windows.Forms.Button btn_Avbryt;
        private System.Windows.Forms.ToolStripMenuItem nyOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansvarigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansvarigaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avdelningarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.TabControl tpc_Tabell;
        private System.Windows.Forms.TabPage tpg_order;
        private System.Windows.Forms.TabPage tpg_avdelning;
        private System.Windows.Forms.TabPage tpg_elever;
        private System.Windows.Forms.ToolStripMenuItem ordrarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_ordrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ordnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_amsvarig;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_avdelning;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Prio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Börjat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_klar;
        private System.Windows.Forms.ComboBox cbx_avdelningarOrdrar;
        private System.Windows.Forms.ComboBox cbx_ansvarigaOrdrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_orderNr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_PrioOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_KlarOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rdb_nejOrder;
        private System.Windows.Forms.RadioButton rdb_jaOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbx_SearchOrder;
        private System.Windows.Forms.Button btn_Sok;
        private System.Windows.Forms.DataGridView dgv_Avdelningar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_avdelningar;
        private System.Windows.Forms.Button btn_AddAvdelning;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbx_avdelningAdd;
        private System.Windows.Forms.Button btn_AvdelningRemove;
        private System.Windows.Forms.Button btn_OrderRemove;
        private System.Windows.Forms.Button btn_OrderUpdate;
        private System.Windows.Forms.DataGridView dgv_elever;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Elever;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Losen;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Button btn_RemoveStudent;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.TextBox tbx_StudentName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbx_ElevNamn;
        private System.Windows.Forms.Button btn_SokElev;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbx_AvdelningSok;
        private System.Windows.Forms.Button btn_searchAvdelning;
        private System.Windows.Forms.ToolStripMenuItem anslutningenToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbx_SearchWord;
        private System.Windows.Forms.Button btn_VisaAllaOrder;
        private System.Windows.Forms.ToolStripMenuItem omOssToolStripMenuItem;
    }
}

