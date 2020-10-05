using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Paint3
{

    public partial class Form1 : Form
    {
        #region daneGłówne
        Graphics g; Graphics r;
        Pen pisak1;
        Pen pisak2;
        Brush brush1 = Brushes.Black;
        Brush brush2 = Brushes.Black;
        Bitmap bmp = new Bitmap(1, 1);
        Rectangle recta;
        #endregion
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pisak1 = new Pen(Color.Black);
            pisak2 = new Pen(Color.Black);
            pisak1.StartCap = pisak1.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pisak2.StartCap = pisak2.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            wielkoscX = panel1.Width;
            wielkoscY = panel1.Height;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            //timer4.Start();
        }

        #region danePoboczne
        int punktx = 0;
        int punkty = 0;
        int punktx2 = 0;
        int wielkoscX = 0;
        int wielkoscY = 0;
        int punkty2 = 0;
        int k = 0;
        int l = 0;
        int wynik = 0;
        string pisanie = "Pisak";
        int punktXStart = 0;
        int punktYStart = 0;
        bool auto = false;
        bool czyPelny = true;
        int punktXMax = 0;
        int punktYMax = 0;
        int punktXMin = 0;
        int punktYMin = 0;
        int punktXLast = 0;
        int punktYLast = 0;
        int wysokoscLast = 0;
        int szerokoscLast = 0;
        int liczba = 0;
        int liczba1 = 0, liczba3 = 0;
        int liczba2 = 0, liczba4 = 0;
        bool kolejkaProstokat = false, kolejkaProstokatPuste = false;
        bool kolejkaElipsa = false, kolejkaElipsaPuste = false;
        Brush brush3; Pen pisak3;
        int fps = 0;
        List<int> colorX = new List<int>();
        List<int> colorY = new List<int>(); //reset click
        int c1 = 0;
        int c2 = 0;
        int c3 = 0;
        int c4 = 0;
        #endregion

        private void Pisanie1()
        {
            if (pisanie == "Pisak")
            {
                fps++;
                g.DrawLine(pisak1, punktx, punkty, punktx2, punkty2);
            }
            if (auto && (pisanie == "Prostokat" || pisanie == "Elipsa"))
            {
                liczba++;
                punktXMax = Math.Max(punktx2, punktXMax);
                punktYMax = Math.Max(punkty2, punktYMax);
                punktXMin = Math.Min(punktx2, punktXMin);
                punktYMin = Math.Min(punkty2, punktYMin);
                if (liczba % 2 == 0)
                {
                    fps++;
                    if (pisanie == "Prostokat")
                        g.FillRectangle(Brushes.White, punktXLast, punktYLast, wysokoscLast, szerokoscLast);
                    else
                        g.FillEllipse(Brushes.White, punktXLast, punktYLast, wysokoscLast, szerokoscLast);
                }
                if (pisanie == "Prostokat")
                {
                    fps++;
                    if (czyPelny)
                    {
                        g.FillRectangle(brush1, Math.Min(punktXStart, punktx2), Math.Min(punktYStart, punkty2),
                        Math.Abs(punktx2 - punktXStart), Math.Abs(punkty2 - punktYStart));
                    }
                    else
                    {
                        g.DrawRectangle(pisak1, Math.Min(punktXStart, punktx2), Math.Min(punktYStart, punkty2),
                        Math.Abs(punktx2 - punktXStart), Math.Abs(punkty2 - punktYStart));
                    }
                }
                if (pisanie == "Elipsa")
                {
                    fps++;
                    if (czyPelny)
                    {
                        g.FillEllipse(brush1, Math.Min(punktXStart, punktx2), Math.Min(punktYStart, punkty2),
                        Math.Abs(punktx2 - punktXStart), Math.Abs(punkty2 - punktYStart));
                    }
                    else
                    {
                        g.DrawEllipse(pisak1, Math.Min(punktXStart, punktx2), Math.Min(punktYStart, punkty2),
                        Math.Abs(punktx2 - punktXStart), Math.Abs(punkty2 - punktYStart));
                    }
                }
                if (liczba % 2 == 0)
                {
                    punktXLast = Math.Min(punktXStart, punktx2) - 1;
                    punktYLast = Math.Min(punktYStart, punkty2) - 1;
                    wysokoscLast = Math.Abs(punktx2 - punktXStart) + 4;
                    szerokoscLast = Math.Abs(punkty2 - punktYStart) + 4;
                }
            }
        }

        private void Pisanie2()
        {
            if (pisanie == "Pisak")
            {
                fps++;
                g.DrawLine(pisak2, punktx, punkty, punktx2, punkty2);
            }
            if (auto && (pisanie == "Prostokat" || pisanie == "Elipsa"))
            {
                liczba++;
                punktXMax = Math.Max(punktx2, punktXMax);
                punktYMax = Math.Max(punkty2, punktYMax);
                punktXMin = Math.Min(punktx2, punktXMin);
                punktYMin = Math.Min(punkty2, punktYMin);
                if (liczba % 2 == 0)
                {
                    fps++;
                    if (pisanie == "Prostokat")
                        g.FillRectangle(Brushes.White, punktXLast, punktYLast, wysokoscLast, szerokoscLast);
                    else
                        g.FillEllipse(Brushes.White, punktXLast, punktYLast, wysokoscLast, szerokoscLast);
                }
                if (pisanie == "Prostokat")
                {
                    fps++;
                    if (czyPelny)
                    {
                        g.FillRectangle(brush2, Math.Min(punktXStart, punktx2), Math.Min(punktYStart, punkty2),
                        Math.Abs(punktx2 - punktXStart), Math.Abs(punkty2 - punktYStart));
                    }
                    else
                    {
                        g.DrawRectangle(pisak2, Math.Min(punktXStart, punktx2), Math.Min(punktYStart, punkty2),
                        Math.Abs(punktx2 - punktXStart), Math.Abs(punkty2 - punktYStart));
                    }
                }
                if (pisanie == "Elipsa")
                {
                    fps++;
                    if (czyPelny)
                    {
                        g.FillEllipse(brush2, Math.Min(punktXStart, punktx2), Math.Min(punktYStart, punkty2),
                        Math.Abs(punktx2 - punktXStart), Math.Abs(punkty2 - punktYStart));
                    }
                    else
                    {
                        g.DrawEllipse(pisak2, Math.Min(punktXStart, punktx2), Math.Min(punktYStart, punkty2),
                        Math.Abs(punktx2 - punktXStart), Math.Abs(punkty2 - punktYStart));
                    }
                }
                if (liczba % 2 == 0)
                {
                    punktXLast = Math.Min(punktXStart, punktx2) - 1;
                    punktYLast = Math.Min(punktYStart, punkty2) - 1;
                    wysokoscLast = Math.Abs(punktx2 - punktXStart) + 2;
                    szerokoscLast = Math.Abs(punkty2 - punktYStart) + 2;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxRozmiar.Text = "Jest";
            /*if(/*e.KeyCode == Keys.LControlKey && e.KeyCode == Keys.)
            {
                panel1.BackgroundImage = bitmaps[bitmaps.Count - 1];
                bitmaps.RemoveAt(bitmaps.Count - 1);
                g = panel1.CreateGraphics();
            }*/
        }

        #region przyciski
        private void buttonPisanie_Click(object sender, EventArgs e)
        {
            pisanie = "Pisak";
            auto = false;
            buttonAuto.Text = "Auto wył";
        }

        private void buttonLinia_Click(object sender, EventArgs e)
        {
            pisanie = "Linia";
            auto = false;
            buttonAuto.Text = "Auto wył";
        }

        private void buttonProstokat_Click(object sender, EventArgs e)
        {
            pisanie = "Prostokat";
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            pisanie = "Elipsa";
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            if (pisanie != "Pisak" && pisanie != "Linia")
            {
                auto = !auto;
                if (buttonAuto.Text == "Auto wył")
                {
                    buttonAuto.Text = "Auto wł";
                }
                else
                {
                    buttonAuto.Text = "Auto wył";
                }
            }
        }

        private void buttonPelny_Click(object sender, EventArgs e)
        {
            czyPelny = !czyPelny;
            if (buttonPelny.Text == "Pełny")
            {
                buttonPelny.Text = "Pusty";
            }
            else
            {
                buttonPelny.Text = "Pełny";
            }
        }

        private void ButtonFill_Click(object sender, EventArgs e)
        {
            pisanie = "Fill";
        }
        #endregion

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((!kolejkaElipsa && !kolejkaElipsaPuste) && (!kolejkaProstokat && !kolejkaProstokatPuste))
            {
                if (bmp != null) { bmp.Dispose(); }
                if (r != null) { r.Dispose(); }

                bmp = new Bitmap(panel1.Width, panel1.Height);
                r = Graphics.FromImage(bmp);
                recta = panel1.RectangleToScreen(panel1.ClientRectangle);
                r.CopyFromScreen(recta.Location, Point.Empty, panel1.Size);
                punktXMax = e.X;
                punktYMax = e.Y;
                punktXMin = e.X;
                punktYMin = e.Y;
                punktXStart = e.X;
                punktYStart = e.Y;
                punktXLast = e.X;
                punktYLast = e.Y;
                wysokoscLast = 0;
                szerokoscLast = 0;
                if (e.Button == MouseButtons.Left)
                {
                    punktx = e.X;
                    punktx2 = e.X;
                    punkty = e.Y;
                    punkty2 = e.Y;
                    if (pisanie == "Pisak" || pisanie == "Linia")
                    {
                        g.FillEllipse(brush1, punktx - trackBarRozmiar.Value / 2,
                        punkty - trackBarRozmiar.Value / 2, pisak1.Width, pisak1.Width);
                    }
                    if(pisanie == "Fill")
                    {
                        c1 = 0;
                        c2 = 0;
                        c3 = 0;
                        c4 = 0;
                        bmp = new Bitmap(panel1.Width, panel1.Height);
                        FillPanel(punktx, punkty, pisak1.Color, bmp.GetPixel(punktx, punkty));
                        /*panel1.BackgroundImage = bmp;
                        g = panel1.CreateGraphics();
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;*/
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    punktx = e.X;
                    punktx2 = e.X;
                    punkty = e.Y;
                    punkty2 = e.Y;
                    if (pisanie == "Pisak" || pisanie == "Linia")
                    {
                        g.FillEllipse(brush2, punktx - trackBarRozmiar.Value / 2,
                        punkty - trackBarRozmiar.Value / 2, pisak2.Width, pisak2.Width);
                    }
                }
                else if (e.Button == MouseButtons.Middle)
                {
                    Graphics graphics = panel1.CreateGraphics();
                    graphics.Clear(Color.White);
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((k % 2 == 0) && (e.Button == MouseButtons.Left))
            {
                punktx = e.X;
                punkty = e.Y;
                Pisanie1();
                k++;
            }
            else if ((k % 2 == 1) && (e.Button == MouseButtons.Left))
            {
                punktx2 = e.X;
                punkty2 = e.Y;
                Pisanie1();
                k++;
            }
            if ((l % 2 == 0) && (e.Button == MouseButtons.Right))
            {
                punktx = e.X;
                punkty = e.Y;
                Pisanie2();
                l++;
            }
            else if ((l % 2 == 1) && (e.Button == MouseButtons.Right))
            {
                punktx2 = e.X;
                punkty2 = e.Y;
                Pisanie2();
                l++;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            punktx2 = e.X;
            punkty2 = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                if (pisanie == "Linia")
                {
                    g.DrawLine(pisak1, punktXStart, punktYStart, punktx2, punkty2);
                }
                liczba1 = Math.Min(punktXStart, punktx2);
                liczba2 = Math.Min(punktYStart, punkty2);
                liczba3 = Math.Abs(punktx2 - punktXStart);
                liczba4 = Math.Abs(punkty2 - punktYStart);
                brush3 = brush1;
                pisak3 = pisak1;
                if (pisanie == "Prostokat")
                {
                    panel1.BackgroundImage = bmp;
                    g = panel1.CreateGraphics();
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    
                    if (czyPelny)
                    {
                        kolejkaProstokat = true;
                    }
                    else
                    {
                        kolejkaProstokatPuste = true;
                    }
                }
                if (pisanie == "Elipsa")
                {
                    panel1.BackgroundImage = bmp;
                    g = panel1.CreateGraphics();
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (czyPelny)
                    {
                        kolejkaElipsa = true;
                    }
                    else
                    {
                        kolejkaElipsaPuste = true;
                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (pisanie == "Linia")
                {
                    g.DrawLine(pisak2, punktXStart, punktYStart, punktx2, punkty2);
                }
                liczba1 = Math.Min(punktXStart, punktx2);
                liczba2 = Math.Min(punktYStart, punkty2);
                liczba3 = Math.Abs(punktx2 - punktXStart);
                liczba4 = Math.Abs(punkty2 - punktYStart);
                brush3 = brush2;
                pisak3 = pisak2;
                if (pisanie == "Prostokat")
                {
                    panel1.BackgroundImage = bmp;
                    g = panel1.CreateGraphics();
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (czyPelny)
                    {
                        kolejkaProstokat = true;
                    }
                    else
                    {
                        kolejkaProstokatPuste = true;
                    }
                }
                if (pisanie == "Elipsa")
                {
                    panel1.BackgroundImage = bmp;
                    g = panel1.CreateGraphics();
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (czyPelny)
                    {
                        kolejkaElipsa = true;
                    }
                    else
                    {
                        kolejkaElipsaPuste = true;
                    }
                }
            }
        }

        private void newColor_Click(object sender, EventArgs e)
        {
            Kolory kolory = new Kolory();
            kolory.Show();
        }

        private void textBoxRozmiar_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRozmiar.Text, out wynik))
            {
                if (int.Parse(textBoxRozmiar.Text) <= 30 && wynik > 0)
                {
                    trackBarRozmiar.Value = int.Parse(textBoxRozmiar.Text);
                    trackBarRozmiar_Scroll(this, null);
                }
                else
                    Blad();
            }
            else if (textBoxRozmiar.Text == "") { }
            else
                Blad();
        }

        private void Blad()
        {
            MessageBox.Show("Wartość nie może być większa niż 30!\n" +
                        "Oraz mniejsza niż 1\n" + "Ustawiono automatycznie na 10",
                        "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxRozmiar.Text = "10";
            trackBarRozmiar.Value = 10;
        }

        private void trackBarRozmiar_Scroll(object sender, EventArgs e)
        {
            pisak1.Width = trackBarRozmiar.Value;
            pisak2.Width = trackBarRozmiar.Value;
            textBoxRozmiar.Text = trackBarRozmiar.Value.ToString();
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            graphics.Clear(Color.White);
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            textBoxRozmiar.Text = "Jest";
            /*if(/*e.KeyCode == Keys.LControlKey && e.KeyCode == Keys.)
            {
                panel1.BackgroundImage = bitmaps[bitmaps.Count - 1];
                bitmaps.RemoveAt(bitmaps.Count - 1);
                g = panel1.CreateGraphics();
            }*/
        }

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Kolor.txt");
            int kolor = int.Parse(sr.ReadLine());
            brush1 = new SolidBrush(Color.FromArgb(kolor));
            pisak1.Color = Color.FromArgb(kolor);
            kolor = int.Parse(sr.ReadLine());
            brush2 = new SolidBrush(Color.FromArgb(kolor));
            pisak2.Color = Color.FromArgb(kolor);
            sr.Dispose();
            labelWybranyStyl.Text = $"Wybrany styl: {pisanie}";
            buttonWybranyKolor1.BackColor = pisak1.Color;
            buttonWybranyKolor2.BackColor = pisak2.Color;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (wielkoscX != panel1.Width || wielkoscY != panel1.Height)
            {
                g = panel1.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (kolejkaProstokat)
            {
                g.FillRectangle(brush3, liczba1, liczba2, liczba3, liczba4);
                kolejkaProstokat = false;
                //bmp.Dispose();
                //r.Dispose();
            }
            if (kolejkaElipsa)
            {
                g.FillEllipse(brush3, liczba1, liczba2, liczba3, liczba4);
                kolejkaElipsa = false;
                //bmp.Dispose();
                //r.Dispose();
            }
            if (kolejkaProstokatPuste)
            {
                g.DrawRectangle(pisak3, liczba1, liczba2, liczba3, liczba4);
                kolejkaProstokatPuste = false;
                //bmp.Dispose();
                //r.Dispose();
            }
            if (kolejkaElipsaPuste)
            {
                g.DrawEllipse(pisak3, liczba1, liczba2, liczba3, liczba4);
                kolejkaElipsaPuste = false;
                //bmp.Dispose();
                //r.Dispose();
            }
        }
        
        private void timer4_Tick(object sender, EventArgs e)
        {
            //labelFPS.Text = $"{fps}";
            //fps = 0;
        }
        #endregion

        #region Pliki

        private void otworzPlik_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                panel1.BackgroundImage = (Image)Image.FromFile(o.FileName);
            }
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = panel1.RectangleToScreen(panel1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, panel1.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Czy chcesz zapisać swoją prace?", "Przypomnienie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                zapisz_Click(null, null);
                e.Cancel = false;
            }
        }

        private void NowyProjekt_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy chcesz zapisać swoją prace?", "Przypomnienie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                zapisz_Click(null, null);
            }
            g.Clear(Color.White);
        }
        #endregion

        #region Kolory
        public void UstawKolor(string kolor, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                StreamReader sr = new StreamReader("Kolor.txt");
                string kolor2 = sr.ReadLine();
                kolor2 = sr.ReadLine();
                sr.Dispose();
                pisak1.Color = Color.FromName(kolor);
                brush1 = new SolidBrush(Color.FromName(kolor));
                File.WriteAllText("Kolor.txt", pisak1.Color.ToArgb().ToString() + $"\n{kolor2}");
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamReader sr = new StreamReader("Kolor.txt");
                string kolor1 = sr.ReadLine();
                sr.Dispose();
                pisak2.Color = Color.FromName(kolor);
                brush1 = new SolidBrush(Color.FromName(kolor));
                File.WriteAllText("Kolor.txt", kolor1 + $"\n{pisak2.Color.ToArgb()}");
            }
        }

        private void buttonBlack(object sender, MouseEventArgs e)
        {
            UstawKolor("Black", e);
        }

        private void buttonRed(object sender, MouseEventArgs e)
        {
            UstawKolor("Red", e);
        }

        private void buttonYellow(object sender, MouseEventArgs e)
        {
            UstawKolor("Yellow", e);
        }

        private void buttonGreen(object sender, MouseEventArgs e)
        {
            UstawKolor("Green", e);
        }

        private void buttonWhite(object sender, MouseEventArgs e)
        {
            UstawKolor("White", e);
        }

        private void buttonPink(object sender, MouseEventArgs e)
        {
            UstawKolor("Pink", e);
        }

        private void buttonOrange(object sender, MouseEventArgs e)
        {
            UstawKolor("Orange", e);
        }

        private void buttonGrey(object sender, MouseEventArgs e)
        {
            UstawKolor("Gray", e);
        }

        private void buttonBlue(object sender, MouseEventArgs e)
        {
            UstawKolor("Blue", e);
        }

        private void buttonAqua1(object sender, MouseEventArgs e)
        {
            UstawKolor("Aqua", e);
        }
        #endregion

        void FillPanel(int x, int y, Color newColor, Color clickColor)
        {
            bool rozne = true;
            for (int i = 0; i < colorX.Count; i++)
            {
                for (int j = 0; j < colorY.Count; j++)
                {
                    if((colorX[i] != x) & (colorY[j] != y))
                    {
                        rozne = false;
                    }
                }
            }
            if (rozne)
            {

                if (bmp.GetPixel(x, y) == clickColor)
                {
                    bmp.SetPixel(x, y, newColor);
                    colorX.Add(x); colorY.Add(y);

                    g.FillEllipse(brush1, x, y, 1, 1);

                    if (x>0)
                    {
                        g.FillEllipse(brush1, punktx - c1, punkty, 1, 1);
                        FillPanel(punktx - c1, punkty, newColor, clickColor);
                        c1++;
                    }
                    if(x<panel1.Width)
                    {
                        g.FillEllipse(brush1, punktx + c2, punkty, 1, 1);
                        FillPanel(punktx + c2, punkty, newColor, clickColor);
                        c2--;
                    }
                    if(y>0)
                    {
                        g.FillEllipse(brush1, punktx, punkty - c3, 1, 1);
                        FillPanel(punktx, punkty - c3, newColor, clickColor);
                        c3++;
                    }
                    if(y<panel1.Height)
                    {
                        g.FillEllipse(brush1, punktx, punkty + c4, 1, 1);
                        FillPanel(punktx, punkty + c4, newColor, clickColor);
                        c4--;
                    }
                }
            }
            //koniec:
            //if(false) { }
        }
    }
}