using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string inf1 = "INF.02";
        string inf2 = "INF.03";
        string prog1 = "INF.03";
        string prog2 = "INF.04";
        public Form1()
        {
            InitializeComponent();
            inf.Checked = true;
            firsttime.Checked = true;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            List<string> puste = new List<string>();
            bool first = true;
            string wyswietl = "";
            var regMail = new Regex(@"([\@]+)");
            var regAdres = new Regex(@"[A-Z][0-9]+\/[0-9]");
            var regData = new Regex("^[0-9]{2}.[0-9]{2}.[0-9]{4}$");
            var regPostCode = new Regex("^[0-9]{2}-[0-9]{3}$");
            var regTel = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{3}");

            string wynik = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje " +
                "w zawodzie przeprowadzanego w terminie " + comboBox1.Text + "\n\n"
                + "Dane osobowe ucznia\n" +
                " Nazwisko: " + nazwiskotb.Text + "\n" +
                " Imie (imiona): " + imietb.Text + "\n" +
                " Data i miejsce urodzenia: " + datatb.Text + ", " + miejsce.Text + "\n" +
                " Numer PESEL: " + pesel.Text + "\n\n" +
                "Adres korespondencyjny\n" +
                " miejscowość: " + miejscowosc.Text + "\n" +
                " ulica i numer domu: " + adres.Text + "\n" +
                " Kod pocztowy i poczta: " + postcode.Text + ", " + miasto.Text + "\n" +
                " nr telefonu z kierunkowym: " + "+48 " + nrtel.Text + "\n" +
                " mail: " + mail.Text + "\n\n\n";

            if (nazwiskotb.Text == "")
            {
                puste.Add("nazwisko");
                nazwiskotb.BackColor = Color.Red;
            }
            if (imietb.Text == "")
            {
                puste.Add("imie");
                imietb.BackColor = Color.Red;
            }
            if (datatb.Text == "" || !regData.IsMatch(datatb.Text))
            {
                puste.Add("data urodzenia");
                datatb.BackColor = Color.Red;
            }
            if (miejsce.Text == "")
            {
                puste.Add("miejsce urodzenia");
                miejsce.BackColor = Color.Red;
            }
            if (pesel.Text == "")
            {
                puste.Add("pesel");
                pesel.BackColor = Color.Red;
            }
            if (miejscowosc.Text == "")
            {
                puste.Add("miejscowość");
                miejscowosc.BackColor = Color.Red;
            }
            if (adres.Text == "" || !regAdres.IsMatch(adres.Text))
            {
                puste.Add("ulica i numer domu");
                adres.BackColor = Color.Red;
            }
            if (postcode.Text == "" || !regPostCode.IsMatch(postcode.Text))
            {
                puste.Add("kod pocztowy");
                postcode.BackColor = Color.Red;
            }
            if (miasto.Text == "")
            {
                puste.Add("miasto poczty");
                miasto.BackColor = Color.Red;
            }
            if (nrtel.Text == "" || !regTel.IsMatch(nrtel.Text))
            {
                puste.Add("numer telefonu");
                nrtel.BackColor = Color.Red;
            }
            if (mail.Text == "" || !regMail.IsMatch(mail.Text))
            {
                puste.Add("e-mail");
                mail.BackColor = Color.Red;
            }
            if (miesiac2.Text == "")
            {
                miesiac2.BackColor = Color.Red;
            }
            if (next.Checked && pisemna.Checked)
            {
                wynik += "Deklaruję przystąpienie do egzaminu poraz kolejny do części pisemnej\n\n";
            }
            else if (next.Checked && praktyczna.Checked)
            {
                wynik += "Deklaruję przystąpienie do egzaminu poraz kolejny do części praktycznej\n\n";
            }
            else if (firsttime.Checked)
            {
                wynik += "Deklaruję przystąpienie do egzaminu poraz pierwszy\n\n";
            }

            wynik += "Oznaczenie kwalifikacji zgodne z podstawą programową: " + miesiac2.Text +
                ". Nazwa kwalifikacji: " + label13.Text + "\n\n";

            if(inf.Checked)
            {
                wynik += "Symbol cyfrowy zawodu: 351203\nNazwa zawodu: technik informatyk"; 
            }
            else
            {
                wynik += "Symbol cyfrowy zawodu: 351406\nNazwa zawodu: technik programista";
            }

            if (puste.Count != 0)
            {
                foreach (var x in puste)
                {
                    if (first == true)
                    {
                        first = false;
                        wyswietl += x;
                    }
                    else wyswietl += ", " + x;
                }
                MessageBox.Show("Podane pola " + wyswietl + " są puste lub źle uzupełnione!");
            }
            else if (imietb.Text.EndsWith("A") && pesel.Text[9] % 2 != 0)
            {
                MessageBox.Show("Pesel się nie zgadza!");
            }
            else if (next.Checked && !pisemna.Checked && !praktyczna.Checked)
            {
                MessageBox.Show("Zaznacz wszystkie pola!");
            }
            else
            {
                wyniktb.Text = wynik;
            }
        }

        private void inf_CheckedChanged_1(object sender, EventArgs e)
        {
            if (inf.Checked)
            {
                miesiac2.Enabled = true;
                miesiac2.Items.Clear();
                miesiac2.Text = null;
                miesiac2.Items.Add(inf1);
                miesiac2.Items.Add(inf2);
            }
            if (prog.Checked)
            {
                miesiac2.Enabled = true;
                miesiac2.Items.Clear();
                miesiac2.Text = null;
                miesiac2.Items.Add(prog1);
                miesiac2.Items.Add(prog2);
            }
        }

        private void prog_CheckedChanged_1(object sender, EventArgs e)
        {
            if (inf.Checked)
            {
                miesiac2.Enabled = true;
                miesiac2.Items.Clear();
                miesiac2.Text = null;
                miesiac2.Items.Add(inf1);
                miesiac2.Items.Add(inf2);
            }
            if (prog.Checked)
            {
                miesiac2.Enabled = true;
                miesiac2.Items.Clear();
                miesiac2.Text = null;
                miesiac2.Items.Add(prog1);
                miesiac2.Items.Add(prog2);
            }
        }

        private void miesiac2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (miesiac2.Text == inf1)
            {
                label13.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń peryferyjnych i lokalnych sieci komputerowych.";
            }
            else if (miesiac2.Text == inf2)
            {
                label13.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych.";
            }
            else if (miesiac2.Text == prog1)
            {
                label13.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych.";
            }
            else if (miesiac2.Text == prog2)
            {
                label13.Text = "Projektowanie, programowanie i testowanie aplikacji";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(firsttime.Checked)
            {
                pisemna.Enabled = false;
                praktyczna.Enabled = false;
            }
            else
            {
                pisemna.Enabled = true;
                praktyczna.Enabled = true;
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            nazwiskotb.Text = "";
            imietb.Text = "";
            datatb.Text = "";
            miejsce.Text = "";
            pesel.Text = "";
            miejscowosc.Text = "";
            adres.Text = "";
            postcode.Text = "";
            miasto.Text = "";
            nrtel.Text = "";
            mail.Text = "";
            wyniktb.Text = "";
        }

        private void miesiac2_Click(object sender, EventArgs e)
        {
            miesiac2.BackColor = Color.White;
        }

        private void nazwiskotb_Click(object sender, EventArgs e)
        {
            nazwiskotb.BackColor = Color.White;
        }

        private void imietb_Click(object sender, EventArgs e)
        {
            imietb.BackColor = Color.White;
        }

        private void datatb_Click(object sender, EventArgs e)
        {
            datatb.BackColor = Color.White;
        }

        private void pesel_Click(object sender, EventArgs e)
        {
            pesel.BackColor = Color.White;
        }

        private void miejscowosc_Click(object sender, EventArgs e)
        {
            miejscowosc.BackColor = Color.White;
        }

        private void adres_Click(object sender, EventArgs e)
        {
            adres.BackColor = Color.White;
        }

        private void postcode_Click(object sender, EventArgs e)
        {
            postcode.BackColor = Color.White;
        }

        private void miasto_Click(object sender, EventArgs e)
        {
            miasto.BackColor = Color.White;
        }

        private void nrtel_Click(object sender, EventArgs e)
        {
            nrtel.BackColor = Color.White;
        }

        private void mail_Click(object sender, EventArgs e)
        {
            mail.BackColor = Color.White;
        }

        private void miejsce_Click(object sender, EventArgs e)
        {
            miejsce.BackColor = Color.White;
        }

        private void pisemna_Click(object sender, EventArgs e)
        {
            pisemna.BackColor = Color.White;
        }

        private void praktyczna_Click(object sender, EventArgs e)
        {
            praktyczna.BackColor = Color.White;
        }

        private void save_Click(object sender, EventArgs e)
        {
            var path = "C:\\Users\\tomek\\Desktop";
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(wyniktb.Text);
            }
        }
    }
}
