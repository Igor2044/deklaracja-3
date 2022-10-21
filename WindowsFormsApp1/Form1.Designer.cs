namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imietb = new System.Windows.Forms.TextBox();
            this.nazwiskotb = new System.Windows.Forms.TextBox();
            this.miejsce = new System.Windows.Forms.TextBox();
            this.datatb = new System.Windows.Forms.MaskedTextBox();
            this.pesel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nrtel = new System.Windows.Forms.MaskedTextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.miejscowosc = new System.Windows.Forms.TextBox();
            this.miasto = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.miesiac1 = new System.Windows.Forms.ComboBox();
            this.inf = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prog = new System.Windows.Forms.RadioButton();
            this.kwalifikacja = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.wyniktb = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.firsttime = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.RadioButton();
            this.pisemna = new System.Windows.Forms.CheckBox();
            this.praktyczna = new System.Windows.Forms.CheckBox();
            this.confirm = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(285, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEKLARACJA PRZYSTĄPIENIA DO EGZAMINU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imietb);
            this.groupBox1.Controls.Add(this.nazwiskotb);
            this.groupBox1.Controls.Add(this.miejsce);
            this.groupBox1.Controls.Add(this.datatb);
            this.groupBox1.Controls.Add(this.pesel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane osobowe ucznia";
            // 
            // imietb
            // 
            this.imietb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.imietb.Location = new System.Drawing.Point(218, 66);
            this.imietb.Name = "imietb";
            this.imietb.Size = new System.Drawing.Size(433, 23);
            this.imietb.TabIndex = 8;
            this.imietb.Click += new System.EventHandler(this.imietb_Click);
            // 
            // nazwiskotb
            // 
            this.nazwiskotb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nazwiskotb.Location = new System.Drawing.Point(218, 33);
            this.nazwiskotb.Name = "nazwiskotb";
            this.nazwiskotb.Size = new System.Drawing.Size(433, 23);
            this.nazwiskotb.TabIndex = 7;
            this.nazwiskotb.Click += new System.EventHandler(this.nazwiskotb_Click);
            // 
            // miejsce
            // 
            this.miejsce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.miejsce.Location = new System.Drawing.Point(310, 99);
            this.miejsce.Name = "miejsce";
            this.miejsce.Size = new System.Drawing.Size(132, 23);
            this.miejsce.TabIndex = 6;
            this.miejsce.Click += new System.EventHandler(this.miejsce_Click);
            // 
            // datatb
            // 
            this.datatb.Location = new System.Drawing.Point(217, 100);
            this.datatb.Mask = "00/00/0000";
            this.datatb.Name = "datatb";
            this.datatb.Size = new System.Drawing.Size(84, 23);
            this.datatb.TabIndex = 5;
            this.datatb.ValidatingType = typeof(System.DateTime);
            this.datatb.Click += new System.EventHandler(this.datatb_Click);
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(218, 138);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(145, 23);
            this.pesel.TabIndex = 4;
            this.pesel.Click += new System.EventHandler(this.pesel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numer PESEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data i miejsce urodzenia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Imię (imiona):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nrtel);
            this.groupBox2.Controls.Add(this.mail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.adres);
            this.groupBox2.Controls.Add(this.miejscowosc);
            this.groupBox2.Controls.Add(this.miasto);
            this.groupBox2.Controls.Add(this.postcode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres korespondencyjny";
            // 
            // nrtel
            // 
            this.nrtel.Location = new System.Drawing.Point(238, 125);
            this.nrtel.Mask = "000-000-099";
            this.nrtel.Name = "nrtel";
            this.nrtel.Size = new System.Drawing.Size(125, 23);
            this.nrtel.TabIndex = 22;
            this.nrtel.Click += new System.EventHandler(this.nrtel_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(429, 125);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(222, 23);
            this.mail.TabIndex = 21;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "mail:";
            // 
            // adres
            // 
            this.adres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.adres.Location = new System.Drawing.Point(218, 59);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(433, 23);
            this.adres.TabIndex = 17;
            this.adres.Click += new System.EventHandler(this.adres_Click);
            // 
            // miejscowosc
            // 
            this.miejscowosc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.miejscowosc.Location = new System.Drawing.Point(218, 23);
            this.miejscowosc.Name = "miejscowosc";
            this.miejscowosc.Size = new System.Drawing.Size(433, 23);
            this.miejscowosc.TabIndex = 16;
            this.miejscowosc.Click += new System.EventHandler(this.miejscowosc_Click);
            // 
            // miasto
            // 
            this.miasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.miasto.Location = new System.Drawing.Point(308, 92);
            this.miasto.Name = "miasto";
            this.miasto.Size = new System.Drawing.Size(132, 23);
            this.miasto.TabIndex = 15;
            this.miasto.Click += new System.EventHandler(this.miasto_Click);
            // 
            // postcode
            // 
            this.postcode.Location = new System.Drawing.Point(218, 92);
            this.postcode.Mask = "00-000";
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(84, 23);
            this.postcode.TabIndex = 14;
            this.postcode.ValidatingType = typeof(int);
            this.postcode.Click += new System.EventHandler(this.postcode_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "nr telefonu z kierunkowym:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "kod pocztowy i poczta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "ulica i numer domu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "miejscowość:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(431, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(201, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = " przeprowadzonego w terminie";
            // 
            // miesiac1
            // 
            this.miesiac1.FormattingEnabled = true;
            this.miesiac1.Items.AddRange(new object[] {
            "Styczeń",
            "Czerwiec"});
            this.miesiac1.Location = new System.Drawing.Point(405, 402);
            this.miesiac1.Name = "miesiac1";
            this.miesiac1.Size = new System.Drawing.Size(121, 21);
            this.miesiac1.TabIndex = 5;
            this.miesiac1.Text = "Styczeń";
            // 
            // inf
            // 
            this.inf.AutoSize = true;
            this.inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inf.Location = new System.Drawing.Point(20, 19);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(129, 17);
            this.inf.TabIndex = 6;
            this.inf.TabStop = true;
            this.inf.Text = "technik informatyk";
            this.inf.UseVisualStyleBackColor = true;
            this.inf.CheckedChanged += new System.EventHandler(this.inf_CheckedChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prog);
            this.groupBox3.Controls.Add(this.inf);
            this.groupBox3.Location = new System.Drawing.Point(204, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 52);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // prog
            // 
            this.prog.AutoSize = true;
            this.prog.BackColor = System.Drawing.SystemColors.Control;
            this.prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prog.Location = new System.Drawing.Point(205, 19);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(136, 17);
            this.prog.TabIndex = 6;
            this.prog.TabStop = true;
            this.prog.Text = "technik programista";
            this.prog.UseVisualStyleBackColor = false;
            this.prog.CheckedChanged += new System.EventHandler(this.prog_CheckedChanged_1);
            // 
            // kwalifikacja
            // 
            this.kwalifikacja.FormattingEnabled = true;
            this.kwalifikacja.Location = new System.Drawing.Point(204, 492);
            this.kwalifikacja.Name = "kwalifikacja";
            this.kwalifikacja.Size = new System.Drawing.Size(82, 21);
            this.kwalifikacja.TabIndex = 8;
            this.kwalifikacja.SelectedIndexChanged += new System.EventHandler(this.miesiac2_SelectedIndexChanged_1);
            this.kwalifikacja.Click += new System.EventHandler(this.miesiac2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(299, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Projektowanie, programowanie aplikacji";
            // 
            // wyniktb
            // 
            this.wyniktb.Enabled = false;
            this.wyniktb.Location = new System.Drawing.Point(721, 41);
            this.wyniktb.Name = "wyniktb";
            this.wyniktb.Size = new System.Drawing.Size(321, 469);
            this.wyniktb.TabIndex = 10;
            this.wyniktb.Text = "";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(721, 526);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(142, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Wyczyść";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(892, 526);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(137, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // firsttime
            // 
            this.firsttime.AutoSize = true;
            this.firsttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firsttime.Location = new System.Drawing.Point(43, 10);
            this.firsttime.Name = "firsttime";
            this.firsttime.Size = new System.Drawing.Size(112, 17);
            this.firsttime.TabIndex = 13;
            this.firsttime.TabStop = true;
            this.firsttime.Text = "po raz pierwszy";
            this.firsttime.UseVisualStyleBackColor = true;
            this.firsttime.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.next.Location = new System.Drawing.Point(146, 10);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(104, 17);
            this.next.TabIndex = 14;
            this.next.TabStop = true;
            this.next.Text = "po raz kolejny";
            this.next.UseVisualStyleBackColor = true;
            // 
            // pisemna
            // 
            this.pisemna.AutoSize = true;
            this.pisemna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pisemna.Location = new System.Drawing.Point(29, 11);
            this.pisemna.Name = "pisemna";
            this.pisemna.Size = new System.Drawing.Size(75, 17);
            this.pisemna.TabIndex = 15;
            this.pisemna.Text = "pisemnej";
            this.pisemna.UseVisualStyleBackColor = true;
            this.pisemna.Click += new System.EventHandler(this.pisemna_Click);
            // 
            // praktyczna
            // 
            this.praktyczna.AutoSize = true;
            this.praktyczna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.praktyczna.Location = new System.Drawing.Point(102, 11);
            this.praktyczna.Name = "praktyczna";
            this.praktyczna.Size = new System.Drawing.Size(91, 17);
            this.praktyczna.TabIndex = 16;
            this.praktyczna.Text = "praktycznej";
            this.praktyczna.UseVisualStyleBackColor = true;
            this.praktyczna.Click += new System.EventHandler(this.praktyczna_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(433, 574);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(177, 23);
            this.confirm.TabIndex = 17;
            this.confirm.Text = "Zatwierdź";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.firsttime);
            this.groupBox4.Controls.Add(this.next);
            this.groupBox4.Location = new System.Drawing.Point(156, 526);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 33);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.praktyczna);
            this.groupBox5.Controls.Add(this.pisemna);
            this.groupBox5.Location = new System.Drawing.Point(451, 526);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 33);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 631);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.wyniktb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.kwalifikacja);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.miesiac1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox imietb;
        private System.Windows.Forms.TextBox nazwiskotb;
        private System.Windows.Forms.TextBox miejsce;
        private System.Windows.Forms.MaskedTextBox datatb;
        private System.Windows.Forms.MaskedTextBox pesel;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox miejscowosc;
        private System.Windows.Forms.TextBox miasto;
        private System.Windows.Forms.MaskedTextBox postcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox miesiac1;
        private System.Windows.Forms.RadioButton inf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton prog;
        private System.Windows.Forms.ComboBox kwalifikacja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox wyniktb;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton firsttime;
        private System.Windows.Forms.RadioButton next;
        private System.Windows.Forms.CheckBox pisemna;
        private System.Windows.Forms.CheckBox praktyczna;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox nrtel;
    }
}

