using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Paint3
{
    public partial class Kolory : Form
    {
        public Pen pisak1;
        public Pen pisak2;
        private int wynik;

        public Kolory()
        {
            InitializeComponent();
            pisak1 = new Pen(Color.Black);
            pisak2 = new Pen(Color.Black);
        }

        private void lewyKolor_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Kolor.txt");
            string kolor2 = sr.ReadLine();
            kolor2 = sr.ReadLine();
            sr.Dispose();
            pisak1.Color = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                trackBarZielony.Value, trackBarNiebieski.Value);
            File.WriteAllText("Kolor.txt", pisak1.Color.ToArgb().ToString() + $"\n{kolor2}");
        }

        private void prawyKolor_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Kolor.txt");
            string kolor1 = sr.ReadLine();
            sr.Dispose();
            pisak2.Color = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                trackBarZielony.Value, trackBarNiebieski.Value);
            File.WriteAllText("Kolor.txt", kolor1 + $"\n{pisak2.Color.ToArgb()}");
        }

        private void trackBarAlpha_Scroll(object sender, EventArgs e)
        {
            textBoxAlpha.Text = trackBarAlpha.Value.ToString();
            buttonKolor.BackColor = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                trackBarZielony.Value, trackBarNiebieski.Value);
        }

        public void trackBarCzerwony_Scroll(object sender, EventArgs e)
        {
            textBoxCzerwony.Text = trackBarCzerwony.Value.ToString();
            buttonKolor.BackColor = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                trackBarZielony.Value, trackBarNiebieski.Value);
        }

        private void trackBarZielony_Scroll(object sender, EventArgs e)
        {
            textBoxZielony.Text = trackBarZielony.Value.ToString();
            buttonKolor.BackColor = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                trackBarZielony.Value, trackBarNiebieski.Value);
        }

        private void trackBarNiebieski_Scroll(object sender, EventArgs e)
        {
            textBoxNiebieski.Text = trackBarNiebieski.Value.ToString();
            buttonKolor.BackColor = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                trackBarZielony.Value, trackBarNiebieski.Value);
        }

        private void textBoxAlpha_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAlpha.Text != "")
            {
                if (int.TryParse(textBoxAlpha.Text, out wynik))
                {
                    if (wynik >= 0 && wynik <= 255)
                    {
                        trackBarAlpha.Value = int.Parse(textBoxAlpha.Text);
                        buttonKolor.BackColor = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                            trackBarZielony.Value, trackBarNiebieski.Value);
                    }
                    else
                        ZlaLiczba("A");
                }
                else
                    ZlaLiczba("A");
            }
        }

        private void textBoxCzerwony_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCzerwony.Text != "")
            {
                if (int.TryParse(textBoxCzerwony.Text, out wynik))
                {
                    if (wynik >= 0 && wynik <= 255)
                    {
                        trackBarCzerwony.Value = int.Parse(textBoxCzerwony.Text);
                        buttonKolor.BackColor = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                            trackBarZielony.Value, trackBarNiebieski.Value);
                    }
                    else
                        ZlaLiczba("R");
                }
                else
                    ZlaLiczba("R");
            }
        }

        private void textBoxZielony_TextChanged(object sender, EventArgs e)
        {
            if (textBoxZielony.Text != "")
            {
                if (int.TryParse(textBoxZielony.Text, out wynik))
                {
                    if (wynik >= 0 && wynik <= 255)
                    {
                        trackBarZielony.Value = int.Parse(textBoxZielony.Text);
                        buttonKolor.BackColor = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                            trackBarZielony.Value, trackBarNiebieski.Value);
                    }
                    else
                        ZlaLiczba("Z");
                }
                else
                    ZlaLiczba("Z");
            }
        }

        private void textBoxNiebieski_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNiebieski.Text != "")
            {
                if (int.TryParse(textBoxNiebieski.Text, out wynik))
                {
                    if (wynik >= 0 && wynik <= 255)
                    {
                        trackBarNiebieski.Value = int.Parse(textBoxNiebieski.Text);
                        buttonKolor.BackColor = Color.FromArgb(trackBarAlpha.Value, trackBarCzerwony.Value,
                            trackBarZielony.Value, trackBarNiebieski.Value);
                    }
                    else
                        ZlaLiczba("N");
                }
                else
                    ZlaLiczba("N");
            }
        }

        private void ZlaLiczba(string kolor)
        {
            if (kolor == "A")
            {
                MessageBox.Show("Zła liczba!", "Błąd!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                textBoxAlpha.Text = "255";
                trackBarAlpha.Value = 255;
            }
            if (kolor == "R")
            {
                MessageBox.Show("Zła liczba!", "Błąd!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                textBoxCzerwony.Text = "0";
                trackBarCzerwony.Value = 0;
            }
            if (kolor == "Z")
            {
                MessageBox.Show("Zła liczba!", "Błąd!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                textBoxZielony.Text = "0";
                trackBarZielony.Value = 0;
            }
            if (kolor == "N")
            {
                MessageBox.Show("Zła liczba!", "Błąd!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                textBoxNiebieski.Text = "0";
                trackBarNiebieski.Value = 0;
            }
        }
    }
}