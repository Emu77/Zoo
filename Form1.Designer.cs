
namespace Zooverwaltung
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKontinent = new System.Windows.Forms.TabPage();
            this.btnKontinentLoeschen = new System.Windows.Forms.Button();
            this.btnKontinentSpeichern = new System.Windows.Forms.Button();
            this.lstKontinente = new System.Windows.Forms.ListBox();
            this.txtKontinentBezeichnung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGehege = new System.Windows.Forms.TabPage();
            this.btnGehegeLoeschen = new System.Windows.Forms.Button();
            this.btnGehegeSpeichern = new System.Windows.Forms.Button();
            this.lstGehege = new System.Windows.Forms.ListBox();
            this.cboGehegeKontinent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGehegeBez = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTierart = new System.Windows.Forms.TabPage();
            this.btnTierartLoeschen = new System.Windows.Forms.Button();
            this.btnTierartSpeichern = new System.Windows.Forms.Button();
            this.lstTierarten = new System.Windows.Forms.ListBox();
            this.txtTierartBez = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabTiere = new System.Windows.Forms.TabPage();
            this.btnTierLoeschen = new System.Windows.Forms.Button();
            this.btnTierSpeichern = new System.Windows.Forms.Button();
            this.lstTiere = new System.Windows.Forms.ListBox();
            this.cboTierGehege = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTierart = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTierGeburt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTierGewicht = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTierName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabFutter = new System.Windows.Forms.TabPage();
            this.btnFutterLoeschen = new System.Windows.Forms.Button();
            this.btnFutterSpeichern = new System.Windows.Forms.Button();
            this.lstFutter = new System.Windows.Forms.ListBox();
            this.txtFutterKommentar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFutterVerpackung = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFutterBez = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabRationen = new System.Windows.Forms.TabPage();
            this.btnRationLoeschen = new System.Windows.Forms.Button();
            this.btnRationSpeichern = new System.Windows.Forms.Button();
            this.lstRationen = new System.Windows.Forms.ListBox();
            this.dtpRationUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRationMenge = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboRationFutter = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboRationTier = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabUebersicht = new System.Windows.Forms.TabPage();
            this.dgvUebersicht = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabKontinent.SuspendLayout();
            this.tabGehege.SuspendLayout();
            this.tabTierart.SuspendLayout();
            this.tabTiere.SuspendLayout();
            this.tabFutter.SuspendLayout();
            this.tabRationen.SuspendLayout();
            this.tabUebersicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUebersicht)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKontinent);
            this.tabControl1.Controls.Add(this.tabGehege);
            this.tabControl1.Controls.Add(this.tabTierart);
            this.tabControl1.Controls.Add(this.tabTiere);
            this.tabControl1.Controls.Add(this.tabFutter);
            this.tabControl1.Controls.Add(this.tabRationen);
            this.tabControl1.Controls.Add(this.tabUebersicht);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKontinent
            // 
            this.tabKontinent.Controls.Add(this.btnKontinentLoeschen);
            this.tabKontinent.Controls.Add(this.btnKontinentSpeichern);
            this.tabKontinent.Controls.Add(this.lstKontinente);
            this.tabKontinent.Controls.Add(this.txtKontinentBezeichnung);
            this.tabKontinent.Controls.Add(this.label1);
            this.tabKontinent.Location = new System.Drawing.Point(4, 24);
            this.tabKontinent.Name = "tabKontinent";
            this.tabKontinent.Padding = new System.Windows.Forms.Padding(3);
            this.tabKontinent.Size = new System.Drawing.Size(892, 472);
            this.tabKontinent.TabIndex = 0;
            this.tabKontinent.Text = "Kontinente";
            this.tabKontinent.UseVisualStyleBackColor = true;
            // 
            // btnKontinentLoeschen
            // 
            this.btnKontinentLoeschen.Location = new System.Drawing.Point(187, 74);
            this.btnKontinentLoeschen.Name = "btnKontinentLoeschen";
            this.btnKontinentLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnKontinentLoeschen.TabIndex = 4;
            this.btnKontinentLoeschen.Text = "Löschen";
            this.btnKontinentLoeschen.UseVisualStyleBackColor = true;
            this.btnKontinentLoeschen.Click += new System.EventHandler(this.btnKontinentLoeschen_Click);
            // 
            // btnKontinentSpeichern
            // 
            this.btnKontinentSpeichern.Location = new System.Drawing.Point(106, 74);
            this.btnKontinentSpeichern.Name = "btnKontinentSpeichern";
            this.btnKontinentSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnKontinentSpeichern.TabIndex = 3;
            this.btnKontinentSpeichern.Text = "Speichern";
            this.btnKontinentSpeichern.UseVisualStyleBackColor = true;
            this.btnKontinentSpeichern.Click += new System.EventHandler(this.btnKontinentSpeichern_Click);
            // 
            // lstKontinente
            // 
            this.lstKontinente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKontinente.FormattingEnabled = true;
            this.lstKontinente.ItemHeight = 15;
            this.lstKontinente.Location = new System.Drawing.Point(450, 20);
            this.lstKontinente.Name = "lstKontinente";
            this.lstKontinente.Size = new System.Drawing.Size(420, 424);
            this.lstKontinente.TabIndex = 2;
            this.lstKontinente.SelectedIndexChanged += new System.EventHandler(this.lstKontinente_SelectedIndexChanged);
            // 
            // txtKontinentBezeichnung
            // 
            this.txtKontinentBezeichnung.Location = new System.Drawing.Point(106, 30);
            this.txtKontinentBezeichnung.Name = "txtKontinentBezeichnung";
            this.txtKontinentBezeichnung.Size = new System.Drawing.Size(250, 23);
            this.txtKontinentBezeichnung.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bezeichnung";
            // 
            // tabGehege
            // 
            this.tabGehege.Controls.Add(this.btnGehegeLoeschen);
            this.tabGehege.Controls.Add(this.btnGehegeSpeichern);
            this.tabGehege.Controls.Add(this.lstGehege);
            this.tabGehege.Controls.Add(this.cboGehegeKontinent);
            this.tabGehege.Controls.Add(this.label3);
            this.tabGehege.Controls.Add(this.txtGehegeBez);
            this.tabGehege.Controls.Add(this.label2);
            this.tabGehege.Location = new System.Drawing.Point(4, 24);
            this.tabGehege.Name = "tabGehege";
            this.tabGehege.Padding = new System.Windows.Forms.Padding(3);
            this.tabGehege.Size = new System.Drawing.Size(892, 472);
            this.tabGehege.TabIndex = 1;
            this.tabGehege.Text = "Gehege";
            this.tabGehege.UseVisualStyleBackColor = true;
            // 
            // btnGehegeLoeschen
            // 
            this.btnGehegeLoeschen.Location = new System.Drawing.Point(187, 126);
            this.btnGehegeLoeschen.Name = "btnGehegeLoeschen";
            this.btnGehegeLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnGehegeLoeschen.TabIndex = 6;
            this.btnGehegeLoeschen.Text = "Löschen";
            this.btnGehegeLoeschen.UseVisualStyleBackColor = true;
            this.btnGehegeLoeschen.Click += new System.EventHandler(this.btnGehegeLoeschen_Click);
            // 
            // btnGehegeSpeichern
            // 
            this.btnGehegeSpeichern.Location = new System.Drawing.Point(106, 126);
            this.btnGehegeSpeichern.Name = "btnGehegeSpeichern";
            this.btnGehegeSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnGehegeSpeichern.TabIndex = 5;
            this.btnGehegeSpeichern.Text = "Speichern";
            this.btnGehegeSpeichern.UseVisualStyleBackColor = true;
            this.btnGehegeSpeichern.Click += new System.EventHandler(this.btnGehegeSpeichern_Click);
            // 
            // lstGehege
            // 
            this.lstGehege.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGehege.FormattingEnabled = true;
            this.lstGehege.ItemHeight = 15;
            this.lstGehege.Location = new System.Drawing.Point(450, 20);
            this.lstGehege.Name = "lstGehege";
            this.lstGehege.Size = new System.Drawing.Size(420, 424);
            this.lstGehege.TabIndex = 4;
            this.lstGehege.SelectedIndexChanged += new System.EventHandler(this.lstGehege_SelectedIndexChanged);
            // 
            // cboGehegeKontinent
            // 
            this.cboGehegeKontinent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGehegeKontinent.FormattingEnabled = true;
            this.cboGehegeKontinent.Location = new System.Drawing.Point(106, 75);
            this.cboGehegeKontinent.Name = "cboGehegeKontinent";
            this.cboGehegeKontinent.Size = new System.Drawing.Size(250, 23);
            this.cboGehegeKontinent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontinent";
            // 
            // txtGehegeBez
            // 
            this.txtGehegeBez.Location = new System.Drawing.Point(106, 30);
            this.txtGehegeBez.Name = "txtGehegeBez";
            this.txtGehegeBez.Size = new System.Drawing.Size(250, 23);
            this.txtGehegeBez.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bezeichnung";
            // 
            // tabTierart
            // 
            this.tabTierart.Controls.Add(this.btnTierartLoeschen);
            this.tabTierart.Controls.Add(this.btnTierartSpeichern);
            this.tabTierart.Controls.Add(this.lstTierarten);
            this.tabTierart.Controls.Add(this.txtTierartBez);
            this.tabTierart.Controls.Add(this.label4);
            this.tabTierart.Location = new System.Drawing.Point(4, 24);
            this.tabTierart.Name = "tabTierart";
            this.tabTierart.Padding = new System.Windows.Forms.Padding(3);
            this.tabTierart.Size = new System.Drawing.Size(892, 472);
            this.tabTierart.TabIndex = 2;
            this.tabTierart.Text = "Tierarten";
            this.tabTierart.UseVisualStyleBackColor = true;
            // 
            // btnTierartLoeschen
            // 
            this.btnTierartLoeschen.Location = new System.Drawing.Point(187, 74);
            this.btnTierartLoeschen.Name = "btnTierartLoeschen";
            this.btnTierartLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnTierartLoeschen.TabIndex = 4;
            this.btnTierartLoeschen.Text = "Löschen";
            this.btnTierartLoeschen.UseVisualStyleBackColor = true;
            this.btnTierartLoeschen.Click += new System.EventHandler(this.btnTierartLoeschen_Click);
            // 
            // btnTierartSpeichern
            // 
            this.btnTierartSpeichern.Location = new System.Drawing.Point(106, 74);
            this.btnTierartSpeichern.Name = "btnTierartSpeichern";
            this.btnTierartSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnTierartSpeichern.TabIndex = 3;
            this.btnTierartSpeichern.Text = "Speichern";
            this.btnTierartSpeichern.UseVisualStyleBackColor = true;
            this.btnTierartSpeichern.Click += new System.EventHandler(this.btnTierartSpeichern_Click);
            // 
            // lstTierarten
            // 
            this.lstTierarten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTierarten.FormattingEnabled = true;
            this.lstTierarten.ItemHeight = 15;
            this.lstTierarten.Location = new System.Drawing.Point(450, 20);
            this.lstTierarten.Name = "lstTierarten";
            this.lstTierarten.Size = new System.Drawing.Size(420, 424);
            this.lstTierarten.TabIndex = 2;
            this.lstTierarten.SelectedIndexChanged += new System.EventHandler(this.lstTierarten_SelectedIndexChanged);
            // 
            // txtTierartBez
            // 
            this.txtTierartBez.Location = new System.Drawing.Point(106, 30);
            this.txtTierartBez.Name = "txtTierartBez";
            this.txtTierartBez.Size = new System.Drawing.Size(250, 23);
            this.txtTierartBez.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bezeichnung";
            // 
            // tabTiere
            // 
            this.tabTiere.Controls.Add(this.btnTierLoeschen);
            this.tabTiere.Controls.Add(this.btnTierSpeichern);
            this.tabTiere.Controls.Add(this.lstTiere);
            this.tabTiere.Controls.Add(this.cboTierGehege);
            this.tabTiere.Controls.Add(this.label9);
            this.tabTiere.Controls.Add(this.cboTierart);
            this.tabTiere.Controls.Add(this.label8);
            this.tabTiere.Controls.Add(this.dtpTierGeburt);
            this.tabTiere.Controls.Add(this.label7);
            this.tabTiere.Controls.Add(this.txtTierGewicht);
            this.tabTiere.Controls.Add(this.label6);
            this.tabTiere.Controls.Add(this.txtTierName);
            this.tabTiere.Controls.Add(this.label5);
            this.tabTiere.Location = new System.Drawing.Point(4, 24);
            this.tabTiere.Name = "tabTiere";
            this.tabTiere.Padding = new System.Windows.Forms.Padding(3);
            this.tabTiere.Size = new System.Drawing.Size(892, 472);
            this.tabTiere.TabIndex = 3;
            this.tabTiere.Text = "Tiere";
            this.tabTiere.UseVisualStyleBackColor = true;
            // 
            // btnTierLoeschen
            // 
            this.btnTierLoeschen.Location = new System.Drawing.Point(187, 220);
            this.btnTierLoeschen.Name = "btnTierLoeschen";
            this.btnTierLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnTierLoeschen.TabIndex = 12;
            this.btnTierLoeschen.Text = "Löschen";
            this.btnTierLoeschen.UseVisualStyleBackColor = true;
            this.btnTierLoeschen.Click += new System.EventHandler(this.btnTierLoeschen_Click);
            // 
            // btnTierSpeichern
            // 
            this.btnTierSpeichern.Location = new System.Drawing.Point(106, 220);
            this.btnTierSpeichern.Name = "btnTierSpeichern";
            this.btnTierSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnTierSpeichern.TabIndex = 11;
            this.btnTierSpeichern.Text = "Speichern";
            this.btnTierSpeichern.UseVisualStyleBackColor = true;
            this.btnTierSpeichern.Click += new System.EventHandler(this.btnTierSpeichern_Click);
            // 
            // lstTiere
            // 
            this.lstTiere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTiere.FormattingEnabled = true;
            this.lstTiere.ItemHeight = 15;
            this.lstTiere.Location = new System.Drawing.Point(450, 20);
            this.lstTiere.Name = "lstTiere";
            this.lstTiere.Size = new System.Drawing.Size(420, 424);
            this.lstTiere.TabIndex = 10;
            this.lstTiere.SelectedIndexChanged += new System.EventHandler(this.lstTiere_SelectedIndexChanged);
            // 
            // cboTierGehege
            // 
            this.cboTierGehege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTierGehege.FormattingEnabled = true;
            this.cboTierGehege.Location = new System.Drawing.Point(106, 180);
            this.cboTierGehege.Name = "cboTierGehege";
            this.cboTierGehege.Size = new System.Drawing.Size(250, 23);
            this.cboTierGehege.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gehege";
            // 
            // cboTierart
            // 
            this.cboTierart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTierart.FormattingEnabled = true;
            this.cboTierart.Location = new System.Drawing.Point(106, 151);
            this.cboTierart.Name = "cboTierart";
            this.cboTierart.Size = new System.Drawing.Size(250, 23);
            this.cboTierart.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tierart";
            // 
            // dtpTierGeburt
            // 
            this.dtpTierGeburt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTierGeburt.Location = new System.Drawing.Point(106, 122);
            this.dtpTierGeburt.Name = "dtpTierGeburt";
            this.dtpTierGeburt.Size = new System.Drawing.Size(250, 23);
            this.dtpTierGeburt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Geburtsdatum";
            // 
            // txtTierGewicht
            // 
            this.txtTierGewicht.Location = new System.Drawing.Point(106, 79);
            this.txtTierGewicht.Name = "txtTierGewicht";
            this.txtTierGewicht.Size = new System.Drawing.Size(250, 23);
            this.txtTierGewicht.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gewicht";
            // 
            // txtTierName
            // 
            this.txtTierName.Location = new System.Drawing.Point(106, 34);
            this.txtTierName.Name = "txtTierName";
            this.txtTierName.Size = new System.Drawing.Size(250, 23);
            this.txtTierName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // tabFutter
            // 
            this.tabFutter.Controls.Add(this.btnFutterLoeschen);
            this.tabFutter.Controls.Add(this.btnFutterSpeichern);
            this.tabFutter.Controls.Add(this.lstFutter);
            this.tabFutter.Controls.Add(this.txtFutterKommentar);
            this.tabFutter.Controls.Add(this.label12);
            this.tabFutter.Controls.Add(this.txtFutterVerpackung);
            this.tabFutter.Controls.Add(this.label11);
            this.tabFutter.Controls.Add(this.txtFutterBez);
            this.tabFutter.Controls.Add(this.label10);
            this.tabFutter.Location = new System.Drawing.Point(4, 24);
            this.tabFutter.Name = "tabFutter";
            this.tabFutter.Padding = new System.Windows.Forms.Padding(3);
            this.tabFutter.Size = new System.Drawing.Size(892, 472);
            this.tabFutter.TabIndex = 4;
            this.tabFutter.Text = "Futter";
            this.tabFutter.UseVisualStyleBackColor = true;
            // 
            // btnFutterLoeschen
            // 
            this.btnFutterLoeschen.Location = new System.Drawing.Point(187, 210);
            this.btnFutterLoeschen.Name = "btnFutterLoeschen";
            this.btnFutterLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnFutterLoeschen.TabIndex = 8;
            this.btnFutterLoeschen.Text = "Löschen";
            this.btnFutterLoeschen.UseVisualStyleBackColor = true;
            this.btnFutterLoeschen.Click += new System.EventHandler(this.btnFutterLoeschen_Click);
            // 
            // btnFutterSpeichern
            // 
            this.btnFutterSpeichern.Location = new System.Drawing.Point(106, 210);
            this.btnFutterSpeichern.Name = "btnFutterSpeichern";
            this.btnFutterSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnFutterSpeichern.TabIndex = 7;
            this.btnFutterSpeichern.Text = "Speichern";
            this.btnFutterSpeichern.UseVisualStyleBackColor = true;
            this.btnFutterSpeichern.Click += new System.EventHandler(this.btnFutterSpeichern_Click);
            // 
            // lstFutter
            // 
            this.lstFutter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFutter.FormattingEnabled = true;
            this.lstFutter.ItemHeight = 15;
            this.lstFutter.Location = new System.Drawing.Point(450, 20);
            this.lstFutter.Name = "lstFutter";
            this.lstFutter.Size = new System.Drawing.Size(420, 424);
            this.lstFutter.TabIndex = 6;
            this.lstFutter.SelectedIndexChanged += new System.EventHandler(this.lstFutter_SelectedIndexChanged);
            // 
            // txtFutterKommentar
            // 
            this.txtFutterKommentar.Location = new System.Drawing.Point(106, 107);
            this.txtFutterKommentar.Multiline = true;
            this.txtFutterKommentar.Name = "txtFutterKommentar";
            this.txtFutterKommentar.Size = new System.Drawing.Size(300, 86);
            this.txtFutterKommentar.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Kommentar";
            // 
            // txtFutterVerpackung
            // 
            this.txtFutterVerpackung.Location = new System.Drawing.Point(106, 65);
            this.txtFutterVerpackung.Name = "txtFutterVerpackung";
            this.txtFutterVerpackung.Size = new System.Drawing.Size(300, 23);
            this.txtFutterVerpackung.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Verpackungsgr.";
            // 
            // txtFutterBez
            // 
            this.txtFutterBez.Location = new System.Drawing.Point(106, 26);
            this.txtFutterBez.Name = "txtFutterBez";
            this.txtFutterBez.Size = new System.Drawing.Size(300, 23);
            this.txtFutterBez.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bezeichnung";
            // 
            // tabRationen
            // 
            this.tabRationen.Controls.Add(this.btnRationLoeschen);
            this.tabRationen.Controls.Add(this.btnRationSpeichern);
            this.tabRationen.Controls.Add(this.lstRationen);
            this.tabRationen.Controls.Add(this.dtpRationUhrzeit);
            this.tabRationen.Controls.Add(this.label16);
            this.tabRationen.Controls.Add(this.txtRationMenge);
            this.tabRationen.Controls.Add(this.label15);
            this.tabRationen.Controls.Add(this.cboRationFutter);
            this.tabRationen.Controls.Add(this.label14);
            this.tabRationen.Controls.Add(this.cboRationTier);
            this.tabRationen.Controls.Add(this.label13);
            this.tabRationen.Location = new System.Drawing.Point(4, 24);
            this.tabRationen.Name = "tabRationen";
            this.tabRationen.Padding = new System.Windows.Forms.Padding(3);
            this.tabRationen.Size = new System.Drawing.Size(892, 472);
            this.tabRationen.TabIndex = 5;
            this.tabRationen.Text = "Futterrationen";
            this.tabRationen.UseVisualStyleBackColor = true;
            // 
            // btnRationLoeschen
            // 
            this.btnRationLoeschen.Location = new System.Drawing.Point(187, 210);
            this.btnRationLoeschen.Name = "btnRationLoeschen";
            this.btnRationLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnRationLoeschen.TabIndex = 10;
            this.btnRationLoeschen.Text = "Löschen";
            this.btnRationLoeschen.UseVisualStyleBackColor = true;
            this.btnRationLoeschen.Click += new System.EventHandler(this.btnRationLoeschen_Click);
            // 
            // btnRationSpeichern
            // 
            this.btnRationSpeichern.Location = new System.Drawing.Point(106, 210);
            this.btnRationSpeichern.Name = "btnRationSpeichern";
            this.btnRationSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnRationSpeichern.TabIndex = 9;
            this.btnRationSpeichern.Text = "Speichern";
            this.btnRationSpeichern.UseVisualStyleBackColor = true;
            this.btnRationSpeichern.Click += new System.EventHandler(this.btnRationSpeichern_Click);
            // 
            // lstRationen
            // 
            this.lstRationen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRationen.FormattingEnabled = true;
            this.lstRationen.ItemHeight = 15;
            this.lstRationen.Location = new System.Drawing.Point(450, 20);
            this.lstRationen.Name = "lstRationen";
            this.lstRationen.Size = new System.Drawing.Size(420, 424);
            this.lstRationen.TabIndex = 8;
            // 
            // dtpRationUhrzeit
            // 
            this.dtpRationUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRationUhrzeit.Location = new System.Drawing.Point(106, 162);
            this.dtpRationUhrzeit.Name = "dtpRationUhrzeit";
            this.dtpRationUhrzeit.ShowUpDown = true;
            this.dtpRationUhrzeit.Size = new System.Drawing.Size(200, 23);
            this.dtpRationUhrzeit.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Uhrzeit";
            // 
            // txtRationMenge
            // 
            this.txtRationMenge.Location = new System.Drawing.Point(106, 121);
            this.txtRationMenge.Name = "txtRationMenge";
            this.txtRationMenge.Size = new System.Drawing.Size(200, 23);
            this.txtRationMenge.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Menge";
            // 
            // cboRationFutter
            // 
            this.cboRationFutter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRationFutter.FormattingEnabled = true;
            this.cboRationFutter.Location = new System.Drawing.Point(106, 79);
            this.cboRationFutter.Name = "cboRationFutter";
            this.cboRationFutter.Size = new System.Drawing.Size(250, 23);
            this.cboRationFutter.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Futter";
            // 
            // cboRationTier
            // 
            this.cboRationTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRationTier.FormattingEnabled = true;
            this.cboRationTier.Location = new System.Drawing.Point(106, 37);
            this.cboRationTier.Name = "cboRationTier";
            this.cboRationTier.Size = new System.Drawing.Size(250, 23);
            this.cboRationTier.TabIndex = 1;
            this.cboRationTier.SelectedIndexChanged += new System.EventHandler(this.cboRationTier_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tier";
            // 
            // tabUebersicht
            // 
            this.tabUebersicht.Controls.Add(this.dgvUebersicht);
            this.tabUebersicht.Location = new System.Drawing.Point(4, 24);
            this.tabUebersicht.Name = "tabUebersicht";
            this.tabUebersicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabUebersicht.Size = new System.Drawing.Size(892, 472);
            this.tabUebersicht.TabIndex = 6;
            this.tabUebersicht.Text = "Übersicht";
            this.tabUebersicht.UseVisualStyleBackColor = true;
            // 
            // dgvUebersicht
            // 
            this.dgvUebersicht.AllowUserToAddRows = false;
            this.dgvUebersicht.AllowUserToDeleteRows = false;
            this.dgvUebersicht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUebersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUebersicht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUebersicht.Location = new System.Drawing.Point(3, 3);
            this.dgvUebersicht.Name = "dgvUebersicht";
            this.dgvUebersicht.ReadOnly = true;
            this.dgvUebersicht.RowTemplate.Height = 25;
            this.dgvUebersicht.Size = new System.Drawing.Size(886, 466);
            this.dgvUebersicht.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Zooverwaltung (erweitert mit Futter)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKontinent.ResumeLayout(false);
            this.tabKontinent.PerformLayout();
            this.tabGehege.ResumeLayout(false);
            this.tabGehege.PerformLayout();
            this.tabTierart.ResumeLayout(false);
            this.tabTierart.PerformLayout();
            this.tabTiere.ResumeLayout(false);
            this.tabTiere.PerformLayout();
            this.tabFutter.ResumeLayout(false);
            this.tabFutter.PerformLayout();
            this.tabRationen.ResumeLayout(false);
            this.tabRationen.PerformLayout();
            this.tabUebersicht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUebersicht)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKontinent;
        private System.Windows.Forms.Button btnKontinentLoeschen;
        private System.Windows.Forms.Button btnKontinentSpeichern;
        private System.Windows.Forms.ListBox lstKontinente;
        private System.Windows.Forms.TextBox txtKontinentBezeichnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabGehege;
        private System.Windows.Forms.Button btnGehegeLoeschen;
        private System.Windows.Forms.Button btnGehegeSpeichern;
        private System.Windows.Forms.ListBox lstGehege;
        private System.Windows.Forms.ComboBox cboGehegeKontinent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGehegeBez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabTierart;
        private System.Windows.Forms.Button btnTierartLoeschen;
        private System.Windows.Forms.Button btnTierartSpeichern;
        private System.Windows.Forms.ListBox lstTierarten;
        private System.Windows.Forms.TextBox txtTierartBez;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabTiere;
        private System.Windows.Forms.Button btnTierLoeschen;
        private System.Windows.Forms.Button btnTierSpeichern;
        private System.Windows.Forms.ListBox lstTiere;
        private System.Windows.Forms.ComboBox cboTierGehege;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTierart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTierGeburt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTierGewicht;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTierName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabFutter;
        private System.Windows.Forms.Button btnFutterLoeschen;
        private System.Windows.Forms.Button btnFutterSpeichern;
        private System.Windows.Forms.ListBox lstFutter;
        private System.Windows.Forms.TextBox txtFutterKommentar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFutterVerpackung;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFutterBez;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabRationen;
        private System.Windows.Forms.Button btnRationLoeschen;
        private System.Windows.Forms.Button btnRationSpeichern;
        private System.Windows.Forms.ListBox lstRationen;
        private System.Windows.Forms.DateTimePicker dtpRationUhrzeit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRationMenge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboRationFutter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboRationTier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabUebersicht;
        private System.Windows.Forms.DataGridView dgvUebersicht;
    }
}
