using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Design;
using System.Globalization;
using System.Security.Cryptography;

namespace Harjoitus24
{
    public partial class ToDoList : Form
    {
        // Creating a list of days of the week
        string[] paivat = { "maanantai", "tiistai", "keskiviikko", "torstai", "perjantai", "lauantai", "sunnuntai" };

        // Creating a list of words to search for
        string[] hakusanat = { "hammashoitaja", "lääkäri", "Viktor", "Olha", "Mykyta", "Yevhenii", "KELA", "TE-toimisto" };

        // Create a variable to record the selected row from the list
        private string valittuRivi = null;
        public ToDoList()
        {
            InitializeComponent();
            EtusivuPL.Visible = true;   // Making the start page visible

        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            // Using the function to delete old events
            PoistaVanhojaMerkintoja();

            // Making all other pages invisible
            KirjoitusPL.Visible = false;
            TulosPL.Visible = false;
            HakuPL.Visible = false;
            HakuTulosPL.Visible = false;
            PoistaPL.Visible = false;

            // Create a row that displays the current number and day of the week, as well as the year
            DateTime nykyinenPaiva = DateTime.Now;
            CultureInfo fiCulture = new CultureInfo("fi-FI");
            Calendar kalenteri = fiCulture.Calendar;
            int viikonNumero = kalenteri.GetWeekOfYear(nykyinenPaiva, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            int vuosi = DateTime.Now.Year;

            string viikonPaiva = fiCulture.DateTimeFormat.GetDayName(nykyinenPaiva.DayOfWeek);

            tanaanEtusivuBT.Text = $"Tänään on: Viikko {viikonNumero} {viikonPaiva} {vuosi} vuonna";

            // Clearing the number and day of the week fields for selection
            viikkoEtusivuTB.Text = "";
            paivaEtusivuCB.Text = "";

            // We make it possible to select the day of the week from the drop-down list, as well as enter it manually
            paivaEtusivuCB.Items.AddRange(paivat);
            paivaEtusivuCB.DropDownStyle = ComboBoxStyle.DropDown;

            nayttaaEtusivuBT.Visible = false;       // The "show" button is hidden for correct data entry

            // Validating data input
            viikkoEtusivuTB.TextChanged += new EventHandler(CheckConditions);
            paivaEtusivuCB.TextChanged += new EventHandler(CheckConditions);
        }

        private void CheckConditions(object sender, EventArgs e)
        {
            // Default Text Color
            viikkoEtusivuTB.ForeColor = Color.Black;
            paivaEtusivuCB.ForeColor = Color.Black;

            nayttaaEtusivuBT.Visible = false;       // The "show" button is hidden for correct data entry

            // Check that the week number exists
            if (int.TryParse(viikkoEtusivuTB.Text, out int viikonNumero))
            {
                if (viikonNumero >= 1 && viikonNumero <= 52)
                {
                    // If exists check that day of week is correct
                    if (Array.Exists(paivat, day => day.Equals(paivaEtusivuCB.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                    {
                        nayttaaEtusivuBT.Visible = true;  // If day of week is correct
                    }
                    else
                    {
                        paivaEtusivuCB.ForeColor = Color.DarkCyan;   // If day of week is uncorrect
                    }
                }
                else
                {
                    viikkoEtusivuTB.ForeColor = Color.Red;    // If week number doesn't exist
                }
            }
            else
            {
                nayttaaEtusivuBT.Visible = false;   // If data is uncorrect
            }
        }

        private void paivaEtusivuCB_TextChanged(object sender, EventArgs e)
        {
            paivaEtusivuCB.ForeColor = Color.Black;
        }

        private void hakuEtusivuBT_Click(object sender, EventArgs e)
        {
            // Hide the start page and open the search page
            EtusivuPL.Visible = false;
            HakuPL.Visible = true;
        }

        private void uusiEtusivuBT_Click(object sender, EventArgs e)
        {
            // Hide the start page and open the writing page
            EtusivuPL.Visible = false;
            KirjoitusPL.Visible = true;
        }

        private void nayttaaEtusivuBT_Click(object sender, EventArgs e)
        {
            // Hide the start page and open the result page
            EtusivuPL.Visible = false;
            TulosPL.Visible = true;
        }

        // Saving Events
        private void tallennaKirjoitusBT_Click(object sender, EventArgs e)
        {
            // Create a variable to save the recorded text
            string tapahtuma = textKirjoitusRTB.Text.Trim();

            // Checking that the field is not empty
            if (string.IsNullOrEmpty(tapahtuma))
            {
                MessageBox.Show("Kirjoitathan teksti!");
                return;
            }

            // Choosing a date to save
            DateTime valittuPvm = paivaKirjoitusDTP.Value;
            string paivamaara = valittuPvm.ToString("dd.MM.yyyy");

            // Write the event to a file
            File.AppendAllText("C:\\Users\\Omistaja\\source\\repos\\C sharp\\WinFormsApp24\\todolist.txt", $"{paivamaara}: {tapahtuma}{Environment.NewLine}");
            MessageBox.Show("Tallennettu");

            textKirjoitusRTB.Clear();     // Cleaning the window

            // Hide the writing page and open the start page
            KirjoitusPL.Visible = false;
            EtusivuPL.Visible = true;
        }

        // Organizing the Cancel Button
        private void peruutaKirjoitusBT_Click(object sender, EventArgs e)
        {
            textKirjoitusRTB.Text = "";
            MessageBox.Show("Peruttu");

            // Hide the writing page and open the start page
            KirjoitusPL.Visible = false;
            EtusivuPL.Visible = true;
        }

        private void etusivuTulosBT_Click(object sender, EventArgs e)
        {
            // Hide the result page and open the start page
            TulosPL.Visible = false;
            EtusivuPL.Visible = true;
        }

        private void poistaTulosBT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(valittuRivi))
            {
                // Hide the result page and open the delete page
                TulosPL.Visible = false;
                PoistaPL.Visible = true;
                textTulosLB.Text = valittuRivi;  // Отображаем выбранное событие на панели удаления для подтверждения
            }
            else
            {
                MessageBox.Show("Valitse tapahtuma poistettavaksi");  // Сообщение, если событие не выбрано
            }
        }

        private void hakuHakuBT_Click(object sender, EventArgs e)
        {
            // Adding a search term to a variable
            string hakusana = hakusanaHakuCB.Text.Trim();

            // Create a search array and list
            string[] rivit = File.ReadAllLines("C:\\Users\\Omistaja\\source\\repos\\C sharp\\WinFormsApp24\\todolist.txt");
            List<string> loydetytRivit = new List<string>();
            textHakuTulosLBX.Items.Clear();

            // Loop to add found items to a list
            foreach (string rivi in rivit)
            {
                if (rivi.IndexOf(hakusana, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    loydetytRivit.Add(rivi);
                }
            }

            // Clearing the search results window
            if (loydetytRivit.Count > 0)    // If results 1 and more
            {
                foreach (string rivi in loydetytRivit)
                {
                    textHakuTulosLBX.Items.Add(rivi);
                }
            }
            else
            {
                textHakuTulosLBX.Items.Add("Tälle hakusanalle ei ole merkintöjä");
            }

            // Hide the search page and open the result page
            HakuPL.Visible = false;
            HakuTulosPL.Visible = true;
        }

        private void etusivuHakuBT_Click(object sender, EventArgs e)
        {
            // Hide the search page and open the start page
            HakuPL.Visible = false;
            EtusivuPL.Visible = true;
        }

        private void uusiHakuTulosBT_Click(object sender, EventArgs e)
        {
            // Hide the result page and open the search page
            HakuTulosPL.Visible = false;
            HakuPL.Visible = true;
        }

        private void etusivuHakuTulosBT_Click(object sender, EventArgs e)
        {
            // Hide the result page and open the start page
            HakuTulosPL.Visible = false;
            EtusivuPL.Visible = true;
        }

        // Check if there are any search results
        private void textHakuTulosLBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textHakuTulosLBX.SelectedItem != null)
            {
                valittuRivi = textHakuTulosLBX.SelectedItem.ToString().Trim();
                korjataHakuTulosBT.Visible = true;
            }
            else
            {
                valittuRivi = null;
            }
        }

        // Navigate to the delete page
        private void poistaHakuTulosBT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(valittuRivi))
            {
                // Hide the result page and open the delete page
                HakuTulosPL.Visible = false;
                PoistaPL.Visible = true;

            }
            else
            {
                MessageBox.Show("Valitse rivi poistettavaksi");    // If nothing is selected
            }
        }

        // Delete string if it is choosing
        private void poistaPoistaBT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(valittuRivi))    // If string not empty
            {
                // Create list and copy data from file
                List<string> rivit = File.ReadAllLines("C:\\Users\\Omistaja\\source\\repos\\C sharp\\WinFormsApp24\\todolist.txt").ToList();

                if (rivit.Any(r => r.Trim() == valittuRivi))
                {
                    // Create a new list for rewriting the results after deleting
                    List<string> uudetRivit = rivit.Where(r => r.Trim() != valittuRivi).ToList();
                    File.WriteAllLines("C:\\Users\\Omistaja\\source\\repos\\C sharp\\WinFormsApp24\\todolist.txt", uudetRivit);

                    // Clear the text window
                    textHakuTulosLBX.Items.Clear();

                    // Iterating through the lines in a loop and adding the results without the deleted element 
                    foreach (string rivi in uudetRivit)
                    {
                        textHakuTulosLBX.Items.Add(rivi);
                    }

                    MessageBox.Show("Poistaminen onnistui!");
                    valittuRivi = null;
                }
                else
                {
                    MessageBox.Show("Valittua riviä ei löytynyt");
                }
            }
            else
            {
                MessageBox.Show("Valitse rivi poistettavaksi");   // If you didn't choose any string
            }
        }

        // If you don't want to delete string
        private void peruutaPoistaBT_Click(object sender, EventArgs e)
        {
            // Hide the delete page and open the result page
            PoistaPL.Visible = false;
            HakuTulosPL.Visible = true;
        }

        private void etusivuPoistaBT_Click(object sender, EventArgs e)
        {
            // Hide the delete page and open the start page
            PoistaPL.Visible = false;
            EtusivuPL.Visible = true;
        }

        // Organize of exit from app
        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paivaEtusivuCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            paivaEtusivuCB.ForeColor = Color.Black;
        }

        // Filling of the date label
        private void KirjoitusPL_Paint(object sender, PaintEventArgs e)
        {
            DateTime nykyinenPaiva = DateTime.Now;
            CultureInfo fiCulture = new CultureInfo("fi-FI");
            Calendar kalenteri = fiCulture.Calendar;
            int viikonNumero = kalenteri.GetWeekOfYear(nykyinenPaiva, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            string viikonPaiva = fiCulture.DateTimeFormat.GetDayName(nykyinenPaiva.DayOfWeek);

            paivaKirjoitusLB.Text = viikonNumero + " viikko " + viikonPaiva;

        }

        private void TulosPL_Paint(object sender, PaintEventArgs e)
        {
            // If you came to result page from start page
            if (viikkoEtusivuTB.Text != "" && paivaEtusivuCB.Text != "")
            {
                paivaKirjoitusLB.Text = viikkoEtusivuTB.Text + " viikko " + paivaEtusivuCB.Text;
                string tapahtumat = tapahtumanHaku(viikkoEtusivuTB.Text, paivaEtusivuCB.Text);
                textTulosLB.Text = tapahtumat;
            }
            else
            {
                // If you came from result page
                paivaKirjoitusLB.Text = "";
            }
        }

        // Organize the search box
        static string tapahtumanHaku(string viikonNro, string paivan)
        {
            int viikonNumero = int.Parse(viikonNro);
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            switch (paivan)
            {
                case "maanantai":
                    dayOfWeek = DayOfWeek.Monday;
                    break;
                case "tiistai":
                    dayOfWeek = DayOfWeek.Tuesday;
                    break;
                case "keskiviikko":
                    dayOfWeek = DayOfWeek.Wednesday;
                    break;
                case "torstai":
                    dayOfWeek = DayOfWeek.Thursday;
                    break;
                case "perjantai":
                    dayOfWeek = DayOfWeek.Friday;
                    break;
                case "lauantai":
                    dayOfWeek = DayOfWeek.Saturday;
                    break;
                case "sunnuntai":
                    dayOfWeek = DayOfWeek.Sunday;
                    break;
            }

            // Determining the date by number and day of the week
            DateTime touko1 = new DateTime(DateTime.Now.Year, 1, 1);

            // Search the first monday of year
            DateTime ensimMaanantai = touko1;
            while (ensimMaanantai.DayOfWeek != DayOfWeek.Monday)
            {
                ensimMaanantai = ensimMaanantai.AddDays(1);
            }
            DateTime tarvinPaiva = ensimMaanantai.AddDays((viikonNumero - 1) * 7 + (int)(dayOfWeek - 1));

            string hakuPaiva = tarvinPaiva.ToString("dd.MM.yyyy");

            string[] rivit = File.ReadAllLines("C:\\Users\\Omistaja\\source\\repos\\C sharp\\WinFormsApp24\\todolist.txt");
            
            // Creat the list for events
            List<string> tapahtumat = new List<string>();

            foreach (string rivi in rivit)
            {
                if (rivi.StartsWith(hakuPaiva))
                {
                    tapahtumat.Add(rivi.Substring(hakuPaiva.Length + 2));
                }
            }

            // Displaying search results
            if (tapahtumat.Count > 0)
            {
                string tapahtumatList = string.Join("\n- ", tapahtumat);
                return $"{hakuPaiva}:\n- {tapahtumatList}";
            }
            else
            {
                return "Tälle päivämäärälle ei ole merkintöjä";
            }

        }

        // Make the posibility of choosing or writing the day of week
        private void hakusanaHakuCB_Click(object sender, EventArgs e)
        {
            hakusanaHakuCB.Text = "";
            hakusanaHakuCB.Items.Clear();
            hakusanaHakuCB.Items.AddRange(hakusanat);
            hakusanaHakuCB.DropDownStyle = ComboBoxStyle.DropDown;
        }

        // Function for deleting of old events (older than 1 month)
        private void PoistaVanhojaMerkintoja()
        {
            List<string> rivit = File.ReadAllLines("C:\\Users\\Omistaja\\source\\repos\\C sharp\\WinFormsApp24\\todolist.txt").ToList();
            List<string> vanhatRivit = new List<string>();

            foreach (string rivi in rivit)
            {
                if (rivi.Length >= 10)
                {
                    if (DateTime.TryParseExact(rivi.Substring(0, 10), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime pvm))
                    {
                        if ((DateTime.Now - pvm).TotalDays <= 30)
                        {
                            vanhatRivit.Add(rivi);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Rivillä on väärin päivä: {rivi}");
                    }
                }
            }

            File.WriteAllLines("C:\\Users\\Omistaja\\source\\repos\\C sharp\\WinFormsApp24\\todolist.txt", vanhatRivit);
        }

        private void korjataHakuTulosBT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(valittuRivi))
            {
                // Hide the search page and open the result page
                HakuTulosPL.Visible = false;
                TulosPL.Visible = true;

                // Display the selected event in the result page
                naytaTapahtumaTulosPL(valittuRivi);
            }
            else
            {
                MessageBox.Show("Valitse rivi siirtyäksesi tapahtuman katseluun"); // If nothing chosen
            }
        }

        private void naytaTapahtumaTulosPL(string tapahtuma)
        {
            // Display event on the screen
            textTulosLB.Text = tapahtuma;
        }

        // Organize a return to the previous page from the event view page
        private void takaisinTulosBT_Click(object sender, EventArgs e)
        {
            if (viikkoEtusivuTB.Text != "" && paivaEtusivuCB.Text != "")
            {
                // Hide the result page and open the start page
                EtusivuPL.Visible = true;
                TulosPL.Visible = false;
            }
            else
            {
                // Hide the result page and open the search page
                HakuTulosPL.Visible = true;
                TulosPL.Visible = false;
            }
        }
    }
}
