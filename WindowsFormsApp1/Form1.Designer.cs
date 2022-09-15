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
            this.tbb6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ulandnr = new System.Windows.Forms.TextBox();
            this.miasto1 = new System.Windows.Forms.TextBox();
            this.miasto2 = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inf = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prog = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.confirm = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
            // 
            // nazwiskotb
            // 
            this.nazwiskotb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nazwiskotb.Location = new System.Drawing.Point(218, 33);
            this.nazwiskotb.Name = "nazwiskotb";
            this.nazwiskotb.Size = new System.Drawing.Size(433, 23);
            this.nazwiskotb.TabIndex = 7;
            // 
            // miejsce
            // 
            this.miejsce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.miejsce.Location = new System.Drawing.Point(310, 99);
            this.miejsce.Name = "miejsce";
            this.miejsce.Size = new System.Drawing.Size(132, 23);
            this.miejsce.TabIndex = 6;
            this.miejsce.TextChanged += new System.EventHandler(this.tb4_TextChanged);
            // 
            // datatb
            // 
            this.datatb.Location = new System.Drawing.Point(217, 100);
            this.datatb.Mask = "00/00/0000";
            this.datatb.Name = "datatb";
            this.datatb.Size = new System.Drawing.Size(84, 23);
            this.datatb.TabIndex = 5;
            this.datatb.ValidatingType = typeof(System.DateTime);
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(218, 138);
            this.pesel.Mask = "00000000000";
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(145, 23);
            this.pesel.TabIndex = 4;
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
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.tbb6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ulandnr);
            this.groupBox2.Controls.Add(this.miasto1);
            this.groupBox2.Controls.Add(this.miasto2);
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
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbb6
            // 
            this.tbb6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbb6.Location = new System.Drawing.Point(429, 125);
            this.tbb6.Name = "tbb6";
            this.tbb6.Size = new System.Drawing.Size(222, 23);
            this.tbb6.TabIndex = 21;
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
            // ulandnr
            // 
            this.ulandnr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ulandnr.Location = new System.Drawing.Point(218, 59);
            this.ulandnr.Name = "ulandnr";
            this.ulandnr.Size = new System.Drawing.Size(433, 23);
            this.ulandnr.TabIndex = 17;
            // 
            // miasto1
            // 
            this.miasto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.miasto1.Location = new System.Drawing.Point(218, 23);
            this.miasto1.Name = "miasto1";
            this.miasto1.Size = new System.Drawing.Size(433, 23);
            this.miasto1.TabIndex = 16;
            // 
            // miasto2
            // 
            this.miasto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.miasto2.Location = new System.Drawing.Point(308, 92);
            this.miasto2.Name = "miasto2";
            this.miasto2.Size = new System.Drawing.Size(132, 23);
            this.miasto2.TabIndex = 15;
            // 
            // postcode
            // 
            this.postcode.Location = new System.Drawing.Point(218, 92);
            this.postcode.Mask = "00-000";
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(84, 23);
            this.postcode.TabIndex = 14;
            this.postcode.ValidatingType = typeof(int);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "czerwiec",
            "styczeń"});
            this.comboBox1.Location = new System.Drawing.Point(405, 402);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "styczeń";
            // 
            // inf
            // 
            this.inf.AutoSize = true;
            this.inf.Location = new System.Drawing.Point(20, 19);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(111, 17);
            this.inf.TabIndex = 6;
            this.inf.TabStop = true;
            this.inf.Text = "technik informatyk";
            this.inf.UseVisualStyleBackColor = true;
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
            this.prog.Location = new System.Drawing.Point(205, 19);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(117, 17);
            this.prog.TabIndex = 6;
            this.prog.TabStop = true;
            this.prog.Text = "technik programista";
            this.prog.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "czerwiec",
            "styczeń"});
            this.comboBox2.Location = new System.Drawing.Point(204, 492);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "styczeń";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(299, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Projektowanie, programowanie aplikacji";
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(721, 41);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(321, 469);
            this.wynik.TabIndex = 10;
            this.wynik.Text = "";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(721, 526);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(142, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Wyczyść";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(892, 526);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(137, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(43, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "po raz pierwszy";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(146, 10);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(90, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "po raz kolejny";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "pisemnej";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(102, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "praktycznej";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Location = new System.Drawing.Point(156, 526);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 33);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(451, 526);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 33);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(238, 125);
            this.maskedTextBox1.Mask = "+009 000-000-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 23);
            this.maskedTextBox1.TabIndex = 22;
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
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.TextBox tbb6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ulandnr;
        private System.Windows.Forms.TextBox miasto1;
        private System.Windows.Forms.TextBox miasto2;
        private System.Windows.Forms.MaskedTextBox postcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton inf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton prog;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox wynik;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

