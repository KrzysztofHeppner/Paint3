namespace Paint3
{
    partial class Kolory
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
            this.buttonKolor = new System.Windows.Forms.Button();
            this.prawyKolor = new System.Windows.Forms.Button();
            this.lewyKolor = new System.Windows.Forms.Button();
            this.textBoxNiebieski = new System.Windows.Forms.TextBox();
            this.textBoxZielony = new System.Windows.Forms.TextBox();
            this.buttonNiebieski = new System.Windows.Forms.Button();
            this.buttonZielony = new System.Windows.Forms.Button();
            this.textBoxCzerwony = new System.Windows.Forms.TextBox();
            this.buttonCzerwonyKolory = new System.Windows.Forms.Button();
            this.trackBarNiebieski = new System.Windows.Forms.TrackBar();
            this.trackBarZielony = new System.Windows.Forms.TrackBar();
            this.trackBarCzerwony = new System.Windows.Forms.TrackBar();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.buttonAlpha = new System.Windows.Forms.Button();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNiebieski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZielony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCzerwony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKolor
            // 
            this.buttonKolor.BackColor = System.Drawing.Color.Black;
            this.buttonKolor.Location = new System.Drawing.Point(195, 265);
            this.buttonKolor.Name = "buttonKolor";
            this.buttonKolor.Size = new System.Drawing.Size(60, 60);
            this.buttonKolor.TabIndex = 30;
            this.buttonKolor.UseVisualStyleBackColor = false;
            // 
            // prawyKolor
            // 
            this.prawyKolor.Location = new System.Drawing.Point(320, 280);
            this.prawyKolor.Name = "prawyKolor";
            this.prawyKolor.Size = new System.Drawing.Size(75, 23);
            this.prawyKolor.TabIndex = 29;
            this.prawyKolor.Text = "Prawy kolor";
            this.prawyKolor.UseVisualStyleBackColor = true;
            this.prawyKolor.Click += new System.EventHandler(this.prawyKolor_Click);
            // 
            // lewyKolor
            // 
            this.lewyKolor.Location = new System.Drawing.Point(60, 280);
            this.lewyKolor.Name = "lewyKolor";
            this.lewyKolor.Size = new System.Drawing.Size(75, 23);
            this.lewyKolor.TabIndex = 28;
            this.lewyKolor.Text = "Lewy kolor";
            this.lewyKolor.UseVisualStyleBackColor = true;
            this.lewyKolor.Click += new System.EventHandler(this.lewyKolor_Click);
            // 
            // textBoxNiebieski
            // 
            this.textBoxNiebieski.BackColor = System.Drawing.Color.White;
            this.textBoxNiebieski.Location = new System.Drawing.Point(400, 220);
            this.textBoxNiebieski.Name = "textBoxNiebieski";
            this.textBoxNiebieski.Size = new System.Drawing.Size(70, 20);
            this.textBoxNiebieski.TabIndex = 27;
            this.textBoxNiebieski.Text = "0";
            this.textBoxNiebieski.TextChanged += new System.EventHandler(this.textBoxNiebieski_TextChanged);
            // 
            // textBoxZielony
            // 
            this.textBoxZielony.BackColor = System.Drawing.Color.White;
            this.textBoxZielony.Location = new System.Drawing.Point(400, 170);
            this.textBoxZielony.Name = "textBoxZielony";
            this.textBoxZielony.Size = new System.Drawing.Size(70, 20);
            this.textBoxZielony.TabIndex = 26;
            this.textBoxZielony.Text = "0";
            this.textBoxZielony.TextChanged += new System.EventHandler(this.textBoxZielony_TextChanged);
            // 
            // buttonNiebieski
            // 
            this.buttonNiebieski.BackColor = System.Drawing.Color.Blue;
            this.buttonNiebieski.Location = new System.Drawing.Point(12, 210);
            this.buttonNiebieski.Name = "buttonNiebieski";
            this.buttonNiebieski.Size = new System.Drawing.Size(30, 30);
            this.buttonNiebieski.TabIndex = 25;
            this.buttonNiebieski.UseVisualStyleBackColor = false;
            // 
            // buttonZielony
            // 
            this.buttonZielony.BackColor = System.Drawing.Color.Green;
            this.buttonZielony.Location = new System.Drawing.Point(12, 160);
            this.buttonZielony.Name = "buttonZielony";
            this.buttonZielony.Size = new System.Drawing.Size(30, 30);
            this.buttonZielony.TabIndex = 24;
            this.buttonZielony.UseVisualStyleBackColor = false;
            // 
            // textBoxCzerwony
            // 
            this.textBoxCzerwony.BackColor = System.Drawing.Color.White;
            this.textBoxCzerwony.Location = new System.Drawing.Point(400, 120);
            this.textBoxCzerwony.Name = "textBoxCzerwony";
            this.textBoxCzerwony.Size = new System.Drawing.Size(70, 20);
            this.textBoxCzerwony.TabIndex = 23;
            this.textBoxCzerwony.Text = "0";
            this.textBoxCzerwony.TextChanged += new System.EventHandler(this.textBoxCzerwony_TextChanged);
            // 
            // buttonCzerwonyKolory
            // 
            this.buttonCzerwonyKolory.BackColor = System.Drawing.Color.Red;
            this.buttonCzerwonyKolory.Location = new System.Drawing.Point(12, 110);
            this.buttonCzerwonyKolory.Name = "buttonCzerwonyKolory";
            this.buttonCzerwonyKolory.Size = new System.Drawing.Size(30, 30);
            this.buttonCzerwonyKolory.TabIndex = 22;
            this.buttonCzerwonyKolory.UseVisualStyleBackColor = false;
            // 
            // trackBarNiebieski
            // 
            this.trackBarNiebieski.Location = new System.Drawing.Point(50, 210);
            this.trackBarNiebieski.Maximum = 255;
            this.trackBarNiebieski.Name = "trackBarNiebieski";
            this.trackBarNiebieski.Size = new System.Drawing.Size(346, 45);
            this.trackBarNiebieski.TabIndex = 20;
            this.trackBarNiebieski.Scroll += new System.EventHandler(this.trackBarNiebieski_Scroll);
            // 
            // trackBarZielony
            // 
            this.trackBarZielony.Location = new System.Drawing.Point(50, 160);
            this.trackBarZielony.Maximum = 255;
            this.trackBarZielony.Name = "trackBarZielony";
            this.trackBarZielony.Size = new System.Drawing.Size(346, 45);
            this.trackBarZielony.TabIndex = 19;
            this.trackBarZielony.Scroll += new System.EventHandler(this.trackBarZielony_Scroll);
            // 
            // trackBarCzerwony
            // 
            this.trackBarCzerwony.Location = new System.Drawing.Point(50, 110);
            this.trackBarCzerwony.Maximum = 255;
            this.trackBarCzerwony.Name = "trackBarCzerwony";
            this.trackBarCzerwony.Size = new System.Drawing.Size(346, 45);
            this.trackBarCzerwony.TabIndex = 18;
            this.trackBarCzerwony.Scroll += new System.EventHandler(this.trackBarCzerwony_Scroll);
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.BackColor = System.Drawing.Color.White;
            this.textBoxAlpha.Location = new System.Drawing.Point(400, 70);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(70, 20);
            this.textBoxAlpha.TabIndex = 33;
            this.textBoxAlpha.Text = "0";
            this.textBoxAlpha.TextChanged += new System.EventHandler(this.textBoxAlpha_TextChanged);
            // 
            // buttonAlpha
            // 
            this.buttonAlpha.BackColor = System.Drawing.Color.White;
            this.buttonAlpha.Location = new System.Drawing.Point(12, 60);
            this.buttonAlpha.Name = "buttonAlpha";
            this.buttonAlpha.Size = new System.Drawing.Size(30, 30);
            this.buttonAlpha.TabIndex = 32;
            this.buttonAlpha.UseVisualStyleBackColor = false;
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.Location = new System.Drawing.Point(50, 60);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(346, 45);
            this.trackBarAlpha.TabIndex = 31;
            this.trackBarAlpha.Value = 255;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.trackBarAlpha_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ustaw Kolor";
            // 
            // Kolory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.buttonAlpha);
            this.Controls.Add(this.trackBarAlpha);
            this.Controls.Add(this.buttonKolor);
            this.Controls.Add(this.prawyKolor);
            this.Controls.Add(this.lewyKolor);
            this.Controls.Add(this.textBoxNiebieski);
            this.Controls.Add(this.textBoxZielony);
            this.Controls.Add(this.buttonNiebieski);
            this.Controls.Add(this.buttonZielony);
            this.Controls.Add(this.textBoxCzerwony);
            this.Controls.Add(this.buttonCzerwonyKolory);
            this.Controls.Add(this.trackBarNiebieski);
            this.Controls.Add(this.trackBarZielony);
            this.Controls.Add(this.trackBarCzerwony);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Kolory";
            this.Text = "Kolory";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNiebieski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZielony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCzerwony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKolor;
        private System.Windows.Forms.Button prawyKolor;
        private System.Windows.Forms.Button lewyKolor;
        private System.Windows.Forms.TextBox textBoxNiebieski;
        private System.Windows.Forms.TextBox textBoxZielony;
        private System.Windows.Forms.Button buttonNiebieski;
        private System.Windows.Forms.Button buttonZielony;
        private System.Windows.Forms.TextBox textBoxCzerwony;
        private System.Windows.Forms.Button buttonCzerwonyKolory;
        private System.Windows.Forms.TrackBar trackBarNiebieski;
        private System.Windows.Forms.TrackBar trackBarZielony;
        private System.Windows.Forms.TrackBar trackBarCzerwony;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Button buttonAlpha;
        private System.Windows.Forms.TrackBar trackBarAlpha;
        private System.Windows.Forms.Label label1;
    }
}