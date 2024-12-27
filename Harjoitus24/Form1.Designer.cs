namespace Harjoitus24
{
    partial class ToDoList
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
            this.toDoLB = new System.Windows.Forms.Label();
            this.EtusivuPL = new System.Windows.Forms.Panel();
            this.tanaanEtusivuBT = new System.Windows.Forms.Label();
            this.nayttaaEtusivuBT = new System.Windows.Forms.Button();
            this.uusiEtusivuBT = new System.Windows.Forms.Button();
            this.hakuEtusivuBT = new System.Windows.Forms.Button();
            this.paivaEtusivuCB = new System.Windows.Forms.ComboBox();
            this.viikkoEtusivuTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TulosPL = new System.Windows.Forms.Panel();
            this.takaisinTulosBT = new System.Windows.Forms.Button();
            this.textTulosPL = new System.Windows.Forms.Panel();
            this.textTulosLB = new System.Windows.Forms.Label();
            this.etusivuTulosBT = new System.Windows.Forms.Button();
            this.paivaTulosLB = new System.Windows.Forms.Label();
            this.KirjoitusPL = new System.Windows.Forms.Panel();
            this.paivaKirjoitusDTP = new System.Windows.Forms.DateTimePicker();
            this.textKirjoitusRTB = new System.Windows.Forms.RichTextBox();
            this.peruutaKirjoitusBT = new System.Windows.Forms.Button();
            this.tallennaKirjoitusBT = new System.Windows.Forms.Button();
            this.paivaKirjoitusLB = new System.Windows.Forms.Label();
            this.HakuPL = new System.Windows.Forms.Panel();
            this.hakusanaHakuCB = new System.Windows.Forms.ComboBox();
            this.hakuHakuBT = new System.Windows.Forms.Button();
            this.etusivuHakuBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HakuTulosPL = new System.Windows.Forms.Panel();
            this.korjataHakuTulosBT = new System.Windows.Forms.Button();
            this.textHakuTulosLBX = new System.Windows.Forms.ListBox();
            this.poistaHakuTulosBT = new System.Windows.Forms.Button();
            this.uusiHakuTulosBT = new System.Windows.Forms.Button();
            this.etusivuHakuTulosBT = new System.Windows.Forms.Button();
            this.PoistaPL = new System.Windows.Forms.Panel();
            this.etusivuPoistaBT = new System.Windows.Forms.Button();
            this.poistaLB = new System.Windows.Forms.Label();
            this.peruutaPoistaBT = new System.Windows.Forms.Button();
            this.poistaPoistaBT = new System.Windows.Forms.Button();
            this.exitBT = new System.Windows.Forms.Button();
            this.EtusivuPL.SuspendLayout();
            this.TulosPL.SuspendLayout();
            this.textTulosPL.SuspendLayout();
            this.KirjoitusPL.SuspendLayout();
            this.HakuPL.SuspendLayout();
            this.HakuTulosPL.SuspendLayout();
            this.PoistaPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // toDoLB
            // 
            this.toDoLB.BackColor = System.Drawing.Color.DarkTurquoise;
            this.toDoLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.toDoLB.Font = new System.Drawing.Font("Miriam CLM", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toDoLB.ForeColor = System.Drawing.Color.White;
            this.toDoLB.Location = new System.Drawing.Point(0, 0);
            this.toDoLB.Name = "toDoLB";
            this.toDoLB.Size = new System.Drawing.Size(600, 50);
            this.toDoLB.TabIndex = 0;
            this.toDoLB.Text = "To Do List";
            this.toDoLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EtusivuPL
            // 
            this.EtusivuPL.BackColor = System.Drawing.Color.Azure;
            this.EtusivuPL.Controls.Add(this.tanaanEtusivuBT);
            this.EtusivuPL.Controls.Add(this.nayttaaEtusivuBT);
            this.EtusivuPL.Controls.Add(this.uusiEtusivuBT);
            this.EtusivuPL.Controls.Add(this.hakuEtusivuBT);
            this.EtusivuPL.Controls.Add(this.paivaEtusivuCB);
            this.EtusivuPL.Controls.Add(this.viikkoEtusivuTB);
            this.EtusivuPL.Controls.Add(this.label2);
            this.EtusivuPL.Controls.Add(this.label1);
            this.EtusivuPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EtusivuPL.Location = new System.Drawing.Point(0, 50);
            this.EtusivuPL.Name = "EtusivuPL";
            this.EtusivuPL.Size = new System.Drawing.Size(600, 750);
            this.EtusivuPL.TabIndex = 1;
            // 
            // tanaanEtusivuBT
            // 
            this.tanaanEtusivuBT.AutoSize = true;
            this.tanaanEtusivuBT.Location = new System.Drawing.Point(73, 17);
            this.tanaanEtusivuBT.Name = "tanaanEtusivuBT";
            this.tanaanEtusivuBT.Size = new System.Drawing.Size(494, 31);
            this.tanaanEtusivuBT.TabIndex = 7;
            this.tanaanEtusivuBT.Text = "Tänään on: Viikko X päivä X vuosi XXXX";
            // 
            // nayttaaEtusivuBT
            // 
            this.nayttaaEtusivuBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.nayttaaEtusivuBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nayttaaEtusivuBT.Location = new System.Drawing.Point(366, 581);
            this.nayttaaEtusivuBT.Name = "nayttaaEtusivuBT";
            this.nayttaaEtusivuBT.Size = new System.Drawing.Size(150, 60);
            this.nayttaaEtusivuBT.TabIndex = 6;
            this.nayttaaEtusivuBT.Text = "Näyttää";
            this.nayttaaEtusivuBT.UseVisualStyleBackColor = false;
            this.nayttaaEtusivuBT.Visible = false;
            this.nayttaaEtusivuBT.Click += new System.EventHandler(this.nayttaaEtusivuBT_Click);
            // 
            // uusiEtusivuBT
            // 
            this.uusiEtusivuBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uusiEtusivuBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uusiEtusivuBT.Location = new System.Drawing.Point(79, 581);
            this.uusiEtusivuBT.Name = "uusiEtusivuBT";
            this.uusiEtusivuBT.Size = new System.Drawing.Size(150, 60);
            this.uusiEtusivuBT.TabIndex = 5;
            this.uusiEtusivuBT.Text = "Uusi";
            this.uusiEtusivuBT.UseVisualStyleBackColor = false;
            this.uusiEtusivuBT.Click += new System.EventHandler(this.uusiEtusivuBT_Click);
            // 
            // hakuEtusivuBT
            // 
            this.hakuEtusivuBT.BackColor = System.Drawing.Color.LightCyan;
            this.hakuEtusivuBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hakuEtusivuBT.FlatAppearance.BorderSize = 2;
            this.hakuEtusivuBT.Location = new System.Drawing.Point(40, 363);
            this.hakuEtusivuBT.Name = "hakuEtusivuBT";
            this.hakuEtusivuBT.Size = new System.Drawing.Size(500, 71);
            this.hakuEtusivuBT.TabIndex = 4;
            this.hakuEtusivuBT.Text = "Tietojen hakeminen";
            this.hakuEtusivuBT.UseVisualStyleBackColor = false;
            this.hakuEtusivuBT.Click += new System.EventHandler(this.hakuEtusivuBT_Click);
            // 
            // paivaEtusivuCB
            // 
            this.paivaEtusivuCB.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.paivaEtusivuCB.FormattingEnabled = true;
            this.paivaEtusivuCB.Location = new System.Drawing.Point(201, 221);
            this.paivaEtusivuCB.Name = "paivaEtusivuCB";
            this.paivaEtusivuCB.Size = new System.Drawing.Size(339, 44);
            this.paivaEtusivuCB.TabIndex = 3;
            this.paivaEtusivuCB.SelectedIndexChanged += new System.EventHandler(this.paivaEtusivuCB_SelectedIndexChanged);
            // 
            // viikkoEtusivuTB
            // 
            this.viikkoEtusivuTB.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viikkoEtusivuTB.Location = new System.Drawing.Point(201, 118);
            this.viikkoEtusivuTB.Name = "viikkoEtusivuTB";
            this.viikkoEtusivuTB.Size = new System.Drawing.Size(339, 47);
            this.viikkoEtusivuTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(35, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Päivä";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(35, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Viikko";
            // 
            // TulosPL
            // 
            this.TulosPL.BackColor = System.Drawing.Color.Azure;
            this.TulosPL.Controls.Add(this.takaisinTulosBT);
            this.TulosPL.Controls.Add(this.textTulosPL);
            this.TulosPL.Controls.Add(this.etusivuTulosBT);
            this.TulosPL.Controls.Add(this.paivaTulosLB);
            this.TulosPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TulosPL.Location = new System.Drawing.Point(0, 50);
            this.TulosPL.Name = "TulosPL";
            this.TulosPL.Size = new System.Drawing.Size(600, 750);
            this.TulosPL.TabIndex = 0;
            this.TulosPL.Paint += new System.Windows.Forms.PaintEventHandler(this.TulosPL_Paint);
            // 
            // takaisinTulosBT
            // 
            this.takaisinTulosBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.takaisinTulosBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.takaisinTulosBT.Location = new System.Drawing.Point(366, 594);
            this.takaisinTulosBT.Name = "takaisinTulosBT";
            this.takaisinTulosBT.Size = new System.Drawing.Size(150, 60);
            this.takaisinTulosBT.TabIndex = 4;
            this.takaisinTulosBT.Text = "Takaisin";
            this.takaisinTulosBT.UseVisualStyleBackColor = false;
            this.takaisinTulosBT.Click += new System.EventHandler(this.takaisinTulosBT_Click);
            // 
            // textTulosPL
            // 
            this.textTulosPL.BackColor = System.Drawing.Color.LightCyan;
            this.textTulosPL.Controls.Add(this.textTulosLB);
            this.textTulosPL.Location = new System.Drawing.Point(41, 112);
            this.textTulosPL.Name = "textTulosPL";
            this.textTulosPL.Size = new System.Drawing.Size(520, 440);
            this.textTulosPL.TabIndex = 3;
            // 
            // textTulosLB
            // 
            this.textTulosLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTulosLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTulosLB.Location = new System.Drawing.Point(0, 0);
            this.textTulosLB.Name = "textTulosLB";
            this.textTulosLB.Size = new System.Drawing.Size(520, 440);
            this.textTulosLB.TabIndex = 0;
            // 
            // etusivuTulosBT
            // 
            this.etusivuTulosBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.etusivuTulosBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.etusivuTulosBT.Location = new System.Drawing.Point(79, 594);
            this.etusivuTulosBT.Name = "etusivuTulosBT";
            this.etusivuTulosBT.Size = new System.Drawing.Size(150, 60);
            this.etusivuTulosBT.TabIndex = 1;
            this.etusivuTulosBT.Text = "Etusivu";
            this.etusivuTulosBT.UseVisualStyleBackColor = false;
            this.etusivuTulosBT.Click += new System.EventHandler(this.etusivuTulosBT_Click);
            // 
            // paivaTulosLB
            // 
            this.paivaTulosLB.AutoSize = true;
            this.paivaTulosLB.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.paivaTulosLB.Location = new System.Drawing.Point(152, 39);
            this.paivaTulosLB.Name = "paivaTulosLB";
            this.paivaTulosLB.Size = new System.Drawing.Size(0, 36);
            this.paivaTulosLB.TabIndex = 0;
            // 
            // KirjoitusPL
            // 
            this.KirjoitusPL.BackColor = System.Drawing.Color.Azure;
            this.KirjoitusPL.Controls.Add(this.paivaKirjoitusDTP);
            this.KirjoitusPL.Controls.Add(this.textKirjoitusRTB);
            this.KirjoitusPL.Controls.Add(this.peruutaKirjoitusBT);
            this.KirjoitusPL.Controls.Add(this.tallennaKirjoitusBT);
            this.KirjoitusPL.Controls.Add(this.paivaKirjoitusLB);
            this.KirjoitusPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KirjoitusPL.Location = new System.Drawing.Point(0, 50);
            this.KirjoitusPL.Name = "KirjoitusPL";
            this.KirjoitusPL.Size = new System.Drawing.Size(600, 750);
            this.KirjoitusPL.TabIndex = 0;
            this.KirjoitusPL.Paint += new System.Windows.Forms.PaintEventHandler(this.KirjoitusPL_Paint);
            // 
            // paivaKirjoitusDTP
            // 
            this.paivaKirjoitusDTP.CalendarFont = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.paivaKirjoitusDTP.Location = new System.Drawing.Point(158, 67);
            this.paivaKirjoitusDTP.Name = "paivaKirjoitusDTP";
            this.paivaKirjoitusDTP.Size = new System.Drawing.Size(300, 39);
            this.paivaKirjoitusDTP.TabIndex = 6;
            // 
            // textKirjoitusRTB
            // 
            this.textKirjoitusRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textKirjoitusRTB.Location = new System.Drawing.Point(66, 132);
            this.textKirjoitusRTB.Name = "textKirjoitusRTB";
            this.textKirjoitusRTB.Size = new System.Drawing.Size(474, 417);
            this.textKirjoitusRTB.TabIndex = 5;
            this.textKirjoitusRTB.Text = "";
            // 
            // peruutaKirjoitusBT
            // 
            this.peruutaKirjoitusBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.peruutaKirjoitusBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.peruutaKirjoitusBT.Location = new System.Drawing.Point(366, 594);
            this.peruutaKirjoitusBT.Name = "peruutaKirjoitusBT";
            this.peruutaKirjoitusBT.Size = new System.Drawing.Size(150, 60);
            this.peruutaKirjoitusBT.TabIndex = 4;
            this.peruutaKirjoitusBT.Text = "Peruuta";
            this.peruutaKirjoitusBT.UseVisualStyleBackColor = false;
            this.peruutaKirjoitusBT.Click += new System.EventHandler(this.peruutaKirjoitusBT_Click);
            // 
            // tallennaKirjoitusBT
            // 
            this.tallennaKirjoitusBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tallennaKirjoitusBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tallennaKirjoitusBT.Location = new System.Drawing.Point(79, 594);
            this.tallennaKirjoitusBT.Name = "tallennaKirjoitusBT";
            this.tallennaKirjoitusBT.Size = new System.Drawing.Size(150, 60);
            this.tallennaKirjoitusBT.TabIndex = 3;
            this.tallennaKirjoitusBT.Text = "Tallenna";
            this.tallennaKirjoitusBT.UseVisualStyleBackColor = false;
            this.tallennaKirjoitusBT.Click += new System.EventHandler(this.tallennaKirjoitusBT_Click);
            // 
            // paivaKirjoitusLB
            // 
            this.paivaKirjoitusLB.AutoSize = true;
            this.paivaKirjoitusLB.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.paivaKirjoitusLB.Location = new System.Drawing.Point(152, 15);
            this.paivaKirjoitusLB.Name = "paivaKirjoitusLB";
            this.paivaKirjoitusLB.Size = new System.Drawing.Size(281, 36);
            this.paivaKirjoitusLB.TabIndex = 1;
            this.paivaKirjoitusLB.Text = "x viikko maanantai";
            // 
            // HakuPL
            // 
            this.HakuPL.BackColor = System.Drawing.Color.Azure;
            this.HakuPL.Controls.Add(this.hakusanaHakuCB);
            this.HakuPL.Controls.Add(this.hakuHakuBT);
            this.HakuPL.Controls.Add(this.etusivuHakuBT);
            this.HakuPL.Controls.Add(this.label3);
            this.HakuPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HakuPL.Location = new System.Drawing.Point(0, 50);
            this.HakuPL.Name = "HakuPL";
            this.HakuPL.Size = new System.Drawing.Size(600, 750);
            this.HakuPL.TabIndex = 0;
            // 
            // hakusanaHakuCB
            // 
            this.hakusanaHakuCB.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hakusanaHakuCB.FormattingEnabled = true;
            this.hakusanaHakuCB.Location = new System.Drawing.Point(79, 152);
            this.hakusanaHakuCB.Name = "hakusanaHakuCB";
            this.hakusanaHakuCB.Size = new System.Drawing.Size(421, 44);
            this.hakusanaHakuCB.TabIndex = 4;
            this.hakusanaHakuCB.Text = "valitse tai kirjoita hakusanan";
            this.hakusanaHakuCB.Click += new System.EventHandler(this.hakusanaHakuCB_Click);
            // 
            // hakuHakuBT
            // 
            this.hakuHakuBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.hakuHakuBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hakuHakuBT.Location = new System.Drawing.Point(79, 581);
            this.hakuHakuBT.Name = "hakuHakuBT";
            this.hakuHakuBT.Size = new System.Drawing.Size(150, 60);
            this.hakuHakuBT.TabIndex = 3;
            this.hakuHakuBT.Text = "Haku";
            this.hakuHakuBT.UseVisualStyleBackColor = false;
            this.hakuHakuBT.Click += new System.EventHandler(this.hakuHakuBT_Click);
            // 
            // etusivuHakuBT
            // 
            this.etusivuHakuBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.etusivuHakuBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.etusivuHakuBT.Location = new System.Drawing.Point(366, 581);
            this.etusivuHakuBT.Name = "etusivuHakuBT";
            this.etusivuHakuBT.Size = new System.Drawing.Size(150, 60);
            this.etusivuHakuBT.TabIndex = 2;
            this.etusivuHakuBT.Text = "Etusivu";
            this.etusivuHakuBT.UseVisualStyleBackColor = false;
            this.etusivuHakuBT.Click += new System.EventHandler(this.etusivuHakuBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(178, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Anna hakusana:";
            // 
            // HakuTulosPL
            // 
            this.HakuTulosPL.BackColor = System.Drawing.Color.Azure;
            this.HakuTulosPL.Controls.Add(this.korjataHakuTulosBT);
            this.HakuTulosPL.Controls.Add(this.textHakuTulosLBX);
            this.HakuTulosPL.Controls.Add(this.poistaHakuTulosBT);
            this.HakuTulosPL.Controls.Add(this.uusiHakuTulosBT);
            this.HakuTulosPL.Controls.Add(this.etusivuHakuTulosBT);
            this.HakuTulosPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HakuTulosPL.Location = new System.Drawing.Point(0, 50);
            this.HakuTulosPL.Name = "HakuTulosPL";
            this.HakuTulosPL.Size = new System.Drawing.Size(600, 750);
            this.HakuTulosPL.TabIndex = 0;
            // 
            // korjataHakuTulosBT
            // 
            this.korjataHakuTulosBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.korjataHakuTulosBT.Location = new System.Drawing.Point(50, 494);
            this.korjataHakuTulosBT.Name = "korjataHakuTulosBT";
            this.korjataHakuTulosBT.Size = new System.Drawing.Size(510, 60);
            this.korjataHakuTulosBT.TabIndex = 7;
            this.korjataHakuTulosBT.Text = "Näyttää ";
            this.korjataHakuTulosBT.UseVisualStyleBackColor = false;
            this.korjataHakuTulosBT.Click += new System.EventHandler(this.korjataHakuTulosBT_Click);
            // 
            // textHakuTulosLBX
            // 
            this.textHakuTulosLBX.FormattingEnabled = true;
            this.textHakuTulosLBX.ItemHeight = 29;
            this.textHakuTulosLBX.Location = new System.Drawing.Point(32, 35);
            this.textHakuTulosLBX.Name = "textHakuTulosLBX";
            this.textHakuTulosLBX.Size = new System.Drawing.Size(535, 439);
            this.textHakuTulosLBX.TabIndex = 6;
            this.textHakuTulosLBX.SelectedIndexChanged += new System.EventHandler(this.textHakuTulosLBX_SelectedIndexChanged);
            // 
            // poistaHakuTulosBT
            // 
            this.poistaHakuTulosBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.poistaHakuTulosBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.poistaHakuTulosBT.Location = new System.Drawing.Point(230, 581);
            this.poistaHakuTulosBT.Name = "poistaHakuTulosBT";
            this.poistaHakuTulosBT.Size = new System.Drawing.Size(150, 60);
            this.poistaHakuTulosBT.TabIndex = 5;
            this.poistaHakuTulosBT.Text = "Poista";
            this.poistaHakuTulosBT.UseVisualStyleBackColor = false;
            this.poistaHakuTulosBT.Click += new System.EventHandler(this.poistaHakuTulosBT_Click);
            // 
            // uusiHakuTulosBT
            // 
            this.uusiHakuTulosBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uusiHakuTulosBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uusiHakuTulosBT.Location = new System.Drawing.Point(50, 581);
            this.uusiHakuTulosBT.Name = "uusiHakuTulosBT";
            this.uusiHakuTulosBT.Size = new System.Drawing.Size(150, 60);
            this.uusiHakuTulosBT.TabIndex = 4;
            this.uusiHakuTulosBT.Text = "Uusi haku";
            this.uusiHakuTulosBT.UseVisualStyleBackColor = false;
            this.uusiHakuTulosBT.Click += new System.EventHandler(this.uusiHakuTulosBT_Click);
            // 
            // etusivuHakuTulosBT
            // 
            this.etusivuHakuTulosBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.etusivuHakuTulosBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.etusivuHakuTulosBT.Location = new System.Drawing.Point(411, 581);
            this.etusivuHakuTulosBT.Name = "etusivuHakuTulosBT";
            this.etusivuHakuTulosBT.Size = new System.Drawing.Size(150, 60);
            this.etusivuHakuTulosBT.TabIndex = 2;
            this.etusivuHakuTulosBT.Text = "Etusivu";
            this.etusivuHakuTulosBT.UseVisualStyleBackColor = false;
            this.etusivuHakuTulosBT.Click += new System.EventHandler(this.etusivuHakuTulosBT_Click);
            // 
            // PoistaPL
            // 
            this.PoistaPL.BackColor = System.Drawing.Color.Azure;
            this.PoistaPL.Controls.Add(this.etusivuPoistaBT);
            this.PoistaPL.Controls.Add(this.poistaLB);
            this.PoistaPL.Controls.Add(this.peruutaPoistaBT);
            this.PoistaPL.Controls.Add(this.poistaPoistaBT);
            this.PoistaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoistaPL.Location = new System.Drawing.Point(0, 50);
            this.PoistaPL.Name = "PoistaPL";
            this.PoistaPL.Size = new System.Drawing.Size(600, 750);
            this.PoistaPL.TabIndex = 1;
            // 
            // etusivuPoistaBT
            // 
            this.etusivuPoistaBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.etusivuPoistaBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.etusivuPoistaBT.Location = new System.Drawing.Point(167, 581);
            this.etusivuPoistaBT.Name = "etusivuPoistaBT";
            this.etusivuPoistaBT.Size = new System.Drawing.Size(250, 60);
            this.etusivuPoistaBT.TabIndex = 5;
            this.etusivuPoistaBT.Text = "Etusivu";
            this.etusivuPoistaBT.UseVisualStyleBackColor = false;
            this.etusivuPoistaBT.Click += new System.EventHandler(this.etusivuPoistaBT_Click);
            // 
            // poistaLB
            // 
            this.poistaLB.AutoSize = true;
            this.poistaLB.Font = new System.Drawing.Font("Miriam CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.poistaLB.Location = new System.Drawing.Point(161, 132);
            this.poistaLB.Name = "poistaLB";
            this.poistaLB.Size = new System.Drawing.Size(286, 108);
            this.poistaLB.TabIndex = 4;
            this.poistaLB.Text = "  Oletko varmaa?\r\n\r\nTeksti on poistettu!";
            // 
            // peruutaPoistaBT
            // 
            this.peruutaPoistaBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.peruutaPoistaBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.peruutaPoistaBT.Location = new System.Drawing.Point(366, 374);
            this.peruutaPoistaBT.Name = "peruutaPoistaBT";
            this.peruutaPoistaBT.Size = new System.Drawing.Size(150, 60);
            this.peruutaPoistaBT.TabIndex = 3;
            this.peruutaPoistaBT.Text = "Peruuta";
            this.peruutaPoistaBT.UseVisualStyleBackColor = false;
            this.peruutaPoistaBT.Click += new System.EventHandler(this.peruutaPoistaBT_Click);
            // 
            // poistaPoistaBT
            // 
            this.poistaPoistaBT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.poistaPoistaBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.poistaPoistaBT.Location = new System.Drawing.Point(79, 374);
            this.poistaPoistaBT.Name = "poistaPoistaBT";
            this.poistaPoistaBT.Size = new System.Drawing.Size(150, 60);
            this.poistaPoistaBT.TabIndex = 2;
            this.poistaPoistaBT.Text = "Poista";
            this.poistaPoistaBT.UseVisualStyleBackColor = false;
            this.poistaPoistaBT.Click += new System.EventHandler(this.poistaPoistaBT_Click);
            // 
            // exitBT
            // 
            this.exitBT.BackColor = System.Drawing.Color.Red;
            this.exitBT.Font = new System.Drawing.Font("Miriam CLM", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exitBT.ForeColor = System.Drawing.Color.White;
            this.exitBT.Location = new System.Drawing.Point(550, 0);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(50, 50);
            this.exitBT.TabIndex = 2;
            this.exitBT.Text = "X";
            this.exitBT.UseVisualStyleBackColor = false;
            this.exitBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.TulosPL);
            this.Controls.Add(this.HakuTulosPL);
            this.Controls.Add(this.KirjoitusPL);
            this.Controls.Add(this.EtusivuPL);
            this.Controls.Add(this.PoistaPL);
            this.Controls.Add(this.HakuPL);
            this.Controls.Add(this.exitBT);
            this.Controls.Add(this.toDoLB);
            this.Font = new System.Drawing.Font("Miriam CLM", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ToDoList";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.EtusivuPL.ResumeLayout(false);
            this.EtusivuPL.PerformLayout();
            this.TulosPL.ResumeLayout(false);
            this.TulosPL.PerformLayout();
            this.textTulosPL.ResumeLayout(false);
            this.KirjoitusPL.ResumeLayout(false);
            this.KirjoitusPL.PerformLayout();
            this.HakuPL.ResumeLayout(false);
            this.HakuPL.PerformLayout();
            this.HakuTulosPL.ResumeLayout(false);
            this.PoistaPL.ResumeLayout(false);
            this.PoistaPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label toDoLB;
        private System.Windows.Forms.Panel EtusivuPL;
        private System.Windows.Forms.Panel TulosPL;
        private System.Windows.Forms.Panel KirjoitusPL;
        private System.Windows.Forms.Panel HakuPL;
        private System.Windows.Forms.Panel HakuTulosPL;
        private System.Windows.Forms.Button nayttaaEtusivuBT;
        private System.Windows.Forms.Button uusiEtusivuBT;
        private System.Windows.Forms.Button hakuEtusivuBT;
        private System.Windows.Forms.ComboBox paivaEtusivuCB;
        private System.Windows.Forms.TextBox viikkoEtusivuTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label paivaTulosLB;
        private System.Windows.Forms.Button etusivuTulosBT;
        private System.Windows.Forms.Panel textTulosPL;
        private System.Windows.Forms.Label textTulosLB;
        private System.Windows.Forms.RichTextBox textKirjoitusRTB;
        private System.Windows.Forms.Button peruutaKirjoitusBT;
        private System.Windows.Forms.Button tallennaKirjoitusBT;
        private System.Windows.Forms.Label paivaKirjoitusLB;
        private System.Windows.Forms.Panel PoistaPL;
        private System.Windows.Forms.Button hakuHakuBT;
        private System.Windows.Forms.Button etusivuHakuBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hakusanaHakuCB;
        private System.Windows.Forms.Button etusivuHakuTulosBT;
        private System.Windows.Forms.Button takaisinTulosBT;
        private System.Windows.Forms.Button uusiHakuTulosBT;
        private System.Windows.Forms.Label poistaLB;
        private System.Windows.Forms.Button peruutaPoistaBT;
        private System.Windows.Forms.Button poistaPoistaBT;
        private System.Windows.Forms.Button etusivuPoistaBT;
        private System.Windows.Forms.Button exitBT;
        private System.Windows.Forms.Button poistaHakuTulosBT;
        private System.Windows.Forms.Label tanaanEtusivuBT;
        private System.Windows.Forms.DateTimePicker paivaKirjoitusDTP;
        private System.Windows.Forms.Button korjataHakuTulosBT;
        private System.Windows.Forms.ListBox textHakuTulosLBX;
    }
}

