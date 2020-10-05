namespace Paint3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonFill = new System.Windows.Forms.Button();
            this.labelFPS = new System.Windows.Forms.Label();
            this.buttonPomoc = new System.Windows.Forms.Button();
            this.buttonWybranyKolor2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWybranyKolor1 = new System.Windows.Forms.Button();
            this.labelWybranyStyl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPelny = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonProstokat = new System.Windows.Forms.Button();
            this.NowyProjekt = new System.Windows.Forms.Button();
            this.buttonLinia = new System.Windows.Forms.Button();
            this.buttonPisanie = new System.Windows.Forms.Button();
            this.zapisz = new System.Windows.Forms.Button();
            this.otworzPlik = new System.Windows.Forms.Button();
            this.newColor = new System.Windows.Forms.Button();
            this.textBoxRozmiar = new System.Windows.Forms.TextBox();
            this.trackBarRozmiar = new System.Windows.Forms.TrackBar();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonAqua = new System.Windows.Forms.Button();
            this.buttonNiebieski = new System.Windows.Forms.Button();
            this.buttonSzary = new System.Windows.Forms.Button();
            this.buttonPomaranczowy = new System.Windows.Forms.Button();
            this.buttonRozowy = new System.Windows.Forms.Button();
            this.buttonBialy = new System.Windows.Forms.Button();
            this.buttonZielony = new System.Windows.Forms.Button();
            this.buttonZolty = new System.Windows.Forms.Button();
            this.buttonCzerwony = new System.Windows.Forms.Button();
            this.buttonCzarny = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRozmiar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.White;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 461);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 461);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(147, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 461);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel1_PreviewKeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.ButtonFill);
            this.panel2.Controls.Add(this.labelFPS);
            this.panel2.Controls.Add(this.buttonPomoc);
            this.panel2.Controls.Add(this.buttonWybranyKolor2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonWybranyKolor1);
            this.panel2.Controls.Add(this.labelWybranyStyl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonPelny);
            this.panel2.Controls.Add(this.buttonEllipse);
            this.panel2.Controls.Add(this.buttonAuto);
            this.panel2.Controls.Add(this.buttonProstokat);
            this.panel2.Controls.Add(this.NowyProjekt);
            this.panel2.Controls.Add(this.buttonLinia);
            this.panel2.Controls.Add(this.buttonPisanie);
            this.panel2.Controls.Add(this.zapisz);
            this.panel2.Controls.Add(this.otworzPlik);
            this.panel2.Controls.Add(this.newColor);
            this.panel2.Controls.Add(this.textBoxRozmiar);
            this.panel2.Controls.Add(this.trackBarRozmiar);
            this.panel2.Controls.Add(this.buttonWyczysc);
            this.panel2.Controls.Add(this.buttonAqua);
            this.panel2.Controls.Add(this.buttonNiebieski);
            this.panel2.Controls.Add(this.buttonSzary);
            this.panel2.Controls.Add(this.buttonPomaranczowy);
            this.panel2.Controls.Add(this.buttonRozowy);
            this.panel2.Controls.Add(this.buttonBialy);
            this.panel2.Controls.Add(this.buttonZielony);
            this.panel2.Controls.Add(this.buttonZolty);
            this.panel2.Controls.Add(this.buttonCzerwony);
            this.panel2.Controls.Add(this.buttonCzarny);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 461);
            this.panel2.TabIndex = 0;
            // 
            // ButtonFill
            // 
            this.ButtonFill.BackColor = System.Drawing.Color.Silver;
            this.ButtonFill.Location = new System.Drawing.Point(84, 428);
            this.ButtonFill.Name = "ButtonFill";
            this.ButtonFill.Size = new System.Drawing.Size(57, 30);
            this.ButtonFill.TabIndex = 48;
            this.ButtonFill.Text = "Fill";
            this.ButtonFill.UseVisualStyleBackColor = false;
            this.ButtonFill.Click += new System.EventHandler(this.ButtonFill_Click);
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFPS.Location = new System.Drawing.Point(6, 436);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(45, 18);
            this.labelFPS.TabIndex = 47;
            this.labelFPS.Text = "FPS: ";
            // 
            // buttonPomoc
            // 
            this.buttonPomoc.Location = new System.Drawing.Point(75, 330);
            this.buttonPomoc.Name = "buttonPomoc";
            this.buttonPomoc.Size = new System.Drawing.Size(70, 30);
            this.buttonPomoc.TabIndex = 46;
            this.buttonPomoc.Text = "Pomoc";
            this.buttonPomoc.UseVisualStyleBackColor = true;
            // 
            // buttonWybranyKolor2
            // 
            this.buttonWybranyKolor2.Location = new System.Drawing.Point(95, 383);
            this.buttonWybranyKolor2.Name = "buttonWybranyKolor2";
            this.buttonWybranyKolor2.Size = new System.Drawing.Size(23, 23);
            this.buttonWybranyKolor2.TabIndex = 45;
            this.buttonWybranyKolor2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Wybrany kolor2:";
            // 
            // buttonWybranyKolor1
            // 
            this.buttonWybranyKolor1.Location = new System.Drawing.Point(95, 360);
            this.buttonWybranyKolor1.Name = "buttonWybranyKolor1";
            this.buttonWybranyKolor1.Size = new System.Drawing.Size(23, 23);
            this.buttonWybranyKolor1.TabIndex = 43;
            this.buttonWybranyKolor1.UseVisualStyleBackColor = true;
            // 
            // labelWybranyStyl
            // 
            this.labelWybranyStyl.AutoSize = true;
            this.labelWybranyStyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWybranyStyl.Location = new System.Drawing.Point(3, 409);
            this.labelWybranyStyl.Name = "labelWybranyStyl";
            this.labelWybranyStyl.Size = new System.Drawing.Size(130, 15);
            this.labelWybranyStyl.TabIndex = 42;
            this.labelWybranyStyl.Text = "Wybrany styl: Prostokąt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Wybrany kolor1:";
            // 
            // buttonPelny
            // 
            this.buttonPelny.BackColor = System.Drawing.Color.Silver;
            this.buttonPelny.Location = new System.Drawing.Point(84, 193);
            this.buttonPelny.Name = "buttonPelny";
            this.buttonPelny.Size = new System.Drawing.Size(57, 30);
            this.buttonPelny.TabIndex = 40;
            this.buttonPelny.Text = "Pełny";
            this.buttonPelny.UseVisualStyleBackColor = false;
            this.buttonPelny.Click += new System.EventHandler(this.buttonPelny_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.Silver;
            this.buttonEllipse.Location = new System.Drawing.Point(84, 120);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(57, 30);
            this.buttonEllipse.TabIndex = 38;
            this.buttonEllipse.Text = "Elipsa";
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.Silver;
            this.buttonAuto.Location = new System.Drawing.Point(84, 156);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(57, 30);
            this.buttonAuto.TabIndex = 37;
            this.buttonAuto.Text = "Auto wył";
            this.buttonAuto.UseVisualStyleBackColor = false;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonProstokat
            // 
            this.buttonProstokat.BackColor = System.Drawing.Color.Silver;
            this.buttonProstokat.Location = new System.Drawing.Point(84, 84);
            this.buttonProstokat.Name = "buttonProstokat";
            this.buttonProstokat.Size = new System.Drawing.Size(60, 30);
            this.buttonProstokat.TabIndex = 36;
            this.buttonProstokat.Text = "Prostokąt";
            this.buttonProstokat.UseVisualStyleBackColor = false;
            this.buttonProstokat.Click += new System.EventHandler(this.buttonProstokat_Click);
            // 
            // NowyProjekt
            // 
            this.NowyProjekt.Location = new System.Drawing.Point(75, 300);
            this.NowyProjekt.Name = "NowyProjekt";
            this.NowyProjekt.Size = new System.Drawing.Size(70, 30);
            this.NowyProjekt.TabIndex = 35;
            this.NowyProjekt.Text = "Nowy";
            this.NowyProjekt.UseVisualStyleBackColor = true;
            this.NowyProjekt.Click += new System.EventHandler(this.NowyProjekt_Click);
            // 
            // buttonLinia
            // 
            this.buttonLinia.BackColor = System.Drawing.Color.Silver;
            this.buttonLinia.Location = new System.Drawing.Point(84, 48);
            this.buttonLinia.Name = "buttonLinia";
            this.buttonLinia.Size = new System.Drawing.Size(57, 30);
            this.buttonLinia.TabIndex = 34;
            this.buttonLinia.Text = "Linia";
            this.buttonLinia.UseVisualStyleBackColor = false;
            this.buttonLinia.Click += new System.EventHandler(this.buttonLinia_Click);
            // 
            // buttonPisanie
            // 
            this.buttonPisanie.BackColor = System.Drawing.Color.Silver;
            this.buttonPisanie.Location = new System.Drawing.Point(84, 12);
            this.buttonPisanie.Name = "buttonPisanie";
            this.buttonPisanie.Size = new System.Drawing.Size(60, 30);
            this.buttonPisanie.TabIndex = 31;
            this.buttonPisanie.Text = "Pisanie";
            this.buttonPisanie.UseVisualStyleBackColor = false;
            this.buttonPisanie.Click += new System.EventHandler(this.buttonPisanie_Click);
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(5, 300);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(70, 30);
            this.zapisz.TabIndex = 30;
            this.zapisz.Text = "Zapisz";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // otworzPlik
            // 
            this.otworzPlik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.otworzPlik.Location = new System.Drawing.Point(75, 270);
            this.otworzPlik.Name = "otworzPlik";
            this.otworzPlik.Size = new System.Drawing.Size(70, 30);
            this.otworzPlik.TabIndex = 29;
            this.otworzPlik.Text = "Otwórz";
            this.otworzPlik.UseVisualStyleBackColor = true;
            this.otworzPlik.Click += new System.EventHandler(this.otworzPlik_Click);
            // 
            // newColor
            // 
            this.newColor.Location = new System.Drawing.Point(5, 270);
            this.newColor.Name = "newColor";
            this.newColor.Size = new System.Drawing.Size(70, 30);
            this.newColor.TabIndex = 28;
            this.newColor.Text = "Inne kolory";
            this.newColor.UseVisualStyleBackColor = true;
            this.newColor.Click += new System.EventHandler(this.newColor_Click);
            // 
            // textBoxRozmiar
            // 
            this.textBoxRozmiar.Location = new System.Drawing.Point(12, 193);
            this.textBoxRozmiar.Name = "textBoxRozmiar";
            this.textBoxRozmiar.Size = new System.Drawing.Size(66, 20);
            this.textBoxRozmiar.TabIndex = 27;
            this.textBoxRozmiar.Text = "1";
            this.textBoxRozmiar.TextChanged += new System.EventHandler(this.textBoxRozmiar_TextChanged);
            // 
            // trackBarRozmiar
            // 
            this.trackBarRozmiar.Location = new System.Drawing.Point(3, 220);
            this.trackBarRozmiar.Maximum = 30;
            this.trackBarRozmiar.Minimum = 1;
            this.trackBarRozmiar.Name = "trackBarRozmiar";
            this.trackBarRozmiar.Size = new System.Drawing.Size(139, 45);
            this.trackBarRozmiar.TabIndex = 26;
            this.trackBarRozmiar.Value = 1;
            this.trackBarRozmiar.Scroll += new System.EventHandler(this.trackBarRozmiar_Scroll);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(5, 330);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(70, 30);
            this.buttonWyczysc.TabIndex = 25;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonAqua
            // 
            this.buttonAqua.BackColor = System.Drawing.Color.Aqua;
            this.buttonAqua.Location = new System.Drawing.Point(12, 156);
            this.buttonAqua.Name = "buttonAqua";
            this.buttonAqua.Size = new System.Drawing.Size(30, 30);
            this.buttonAqua.TabIndex = 24;
            this.buttonAqua.UseVisualStyleBackColor = false;
            this.buttonAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAqua1);
            // 
            // buttonNiebieski
            // 
            this.buttonNiebieski.BackColor = System.Drawing.Color.Blue;
            this.buttonNiebieski.Location = new System.Drawing.Point(48, 156);
            this.buttonNiebieski.Name = "buttonNiebieski";
            this.buttonNiebieski.Size = new System.Drawing.Size(30, 30);
            this.buttonNiebieski.TabIndex = 23;
            this.buttonNiebieski.UseVisualStyleBackColor = false;
            this.buttonNiebieski.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBlue);
            // 
            // buttonSzary
            // 
            this.buttonSzary.BackColor = System.Drawing.Color.Gray;
            this.buttonSzary.Location = new System.Drawing.Point(12, 120);
            this.buttonSzary.Name = "buttonSzary";
            this.buttonSzary.Size = new System.Drawing.Size(30, 30);
            this.buttonSzary.TabIndex = 22;
            this.buttonSzary.UseVisualStyleBackColor = false;
            this.buttonSzary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGrey);
            // 
            // buttonPomaranczowy
            // 
            this.buttonPomaranczowy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPomaranczowy.Location = new System.Drawing.Point(48, 120);
            this.buttonPomaranczowy.Name = "buttonPomaranczowy";
            this.buttonPomaranczowy.Size = new System.Drawing.Size(30, 30);
            this.buttonPomaranczowy.TabIndex = 21;
            this.buttonPomaranczowy.UseVisualStyleBackColor = false;
            this.buttonPomaranczowy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonOrange);
            // 
            // buttonRozowy
            // 
            this.buttonRozowy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonRozowy.Location = new System.Drawing.Point(12, 84);
            this.buttonRozowy.Name = "buttonRozowy";
            this.buttonRozowy.Size = new System.Drawing.Size(30, 30);
            this.buttonRozowy.TabIndex = 20;
            this.buttonRozowy.UseVisualStyleBackColor = false;
            this.buttonRozowy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPink);
            // 
            // buttonBialy
            // 
            this.buttonBialy.BackColor = System.Drawing.Color.White;
            this.buttonBialy.Location = new System.Drawing.Point(48, 84);
            this.buttonBialy.Name = "buttonBialy";
            this.buttonBialy.Size = new System.Drawing.Size(30, 30);
            this.buttonBialy.TabIndex = 19;
            this.buttonBialy.UseVisualStyleBackColor = false;
            this.buttonBialy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonWhite);
            // 
            // buttonZielony
            // 
            this.buttonZielony.BackColor = System.Drawing.Color.Green;
            this.buttonZielony.Location = new System.Drawing.Point(12, 48);
            this.buttonZielony.Name = "buttonZielony";
            this.buttonZielony.Size = new System.Drawing.Size(30, 30);
            this.buttonZielony.TabIndex = 18;
            this.buttonZielony.UseVisualStyleBackColor = false;
            this.buttonZielony.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGreen);
            // 
            // buttonZolty
            // 
            this.buttonZolty.BackColor = System.Drawing.Color.Yellow;
            this.buttonZolty.Location = new System.Drawing.Point(48, 48);
            this.buttonZolty.Name = "buttonZolty";
            this.buttonZolty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonZolty.Size = new System.Drawing.Size(30, 30);
            this.buttonZolty.TabIndex = 17;
            this.buttonZolty.UseVisualStyleBackColor = false;
            this.buttonZolty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonYellow);
            // 
            // buttonCzerwony
            // 
            this.buttonCzerwony.BackColor = System.Drawing.Color.Red;
            this.buttonCzerwony.Location = new System.Drawing.Point(12, 12);
            this.buttonCzerwony.Name = "buttonCzerwony";
            this.buttonCzerwony.Size = new System.Drawing.Size(30, 30);
            this.buttonCzerwony.TabIndex = 16;
            this.buttonCzerwony.UseVisualStyleBackColor = false;
            this.buttonCzerwony.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRed);
            // 
            // buttonCzarny
            // 
            this.buttonCzarny.BackColor = System.Drawing.Color.Black;
            this.buttonCzarny.Location = new System.Drawing.Point(48, 12);
            this.buttonCzarny.Name = "buttonCzarny";
            this.buttonCzarny.Size = new System.Drawing.Size(30, 30);
            this.buttonCzarny.TabIndex = 15;
            this.buttonCzarny.UseVisualStyleBackColor = false;
            this.buttonCzarny.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBlack);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRozmiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newColor;
        private System.Windows.Forms.TextBox textBoxRozmiar;
        private System.Windows.Forms.TrackBar trackBarRozmiar;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Button buttonAqua;
        private System.Windows.Forms.Button buttonNiebieski;
        private System.Windows.Forms.Button buttonSzary;
        private System.Windows.Forms.Button buttonPomaranczowy;
        private System.Windows.Forms.Button buttonRozowy;
        private System.Windows.Forms.Button buttonBialy;
        private System.Windows.Forms.Button buttonZielony;
        private System.Windows.Forms.Button buttonZolty;
        private System.Windows.Forms.Button buttonCzerwony;
        private System.Windows.Forms.Button buttonCzarny;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button otworzPlik;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Button buttonLinia;
        private System.Windows.Forms.Button buttonPisanie;
        private System.Windows.Forms.Button NowyProjekt;
        private System.Windows.Forms.Button buttonProstokat;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonPelny;
        private System.Windows.Forms.Label labelWybranyStyl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWybranyKolor1;
        private System.Windows.Forms.Button buttonWybranyKolor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button buttonPomoc;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.Button ButtonFill;
    }
}

