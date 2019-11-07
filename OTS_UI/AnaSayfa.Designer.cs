namespace OTS_UI
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWhatsapp = new System.Windows.Forms.Button();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDiller = new System.Windows.Forms.Button();
            this.btnBolgeler = new System.Windows.Forms.Button();
            this.btnYerler = new System.Windows.Forms.Button();
            this.btnRehberler = new System.Windows.Forms.Button();
            this.btnTurlar = new System.Windows.Forms.Button();
            this.btnBiletSorgula = new System.Windows.Forms.Button();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.otsturuc1 = new OTS_UI.UserControls.OTSTURUC();
            this.kampanyaUC1 = new OTS_UI.UserControls.KampanyaUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnWhatsapp);
            this.panel1.Controls.Add(this.btnTwitter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 68);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1015, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 62);
            this.btnExit.TabIndex = 16;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.FlatAppearance.BorderSize = 0;
            this.btnWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhatsapp.ForeColor = System.Drawing.Color.White;
            this.btnWhatsapp.Image = ((System.Drawing.Image)(resources.GetObject("btnWhatsapp.Image")));
            this.btnWhatsapp.Location = new System.Drawing.Point(773, 3);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(73, 62);
            this.btnWhatsapp.TabIndex = 15;
            this.btnWhatsapp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWhatsapp.UseVisualStyleBackColor = true;
            this.btnWhatsapp.Click += new System.EventHandler(this.BtnWhatsapp_Click);
            // 
            // btnTwitter
            // 
            this.btnTwitter.FlatAppearance.BorderSize = 0;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.ForeColor = System.Drawing.Color.White;
            this.btnTwitter.Image = ((System.Drawing.Image)(resources.GetObject("btnTwitter.Image")));
            this.btnTwitter.Location = new System.Drawing.Point(848, 3);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(73, 62);
            this.btnTwitter.TabIndex = 12;
            this.btnTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTwitter.UseVisualStyleBackColor = true;
            this.btnTwitter.Click += new System.EventHandler(this.BtnTwitter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHakkinda);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 79);
            this.panel2.TabIndex = 2;
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.FlatAppearance.BorderSize = 0;
            this.btnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHakkinda.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkinda.Image")));
            this.btnHakkinda.Location = new System.Drawing.Point(987, 6);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(120, 67);
            this.btnHakkinda.TabIndex = 4;
            this.btnHakkinda.Text = "Hakkında";
            this.btnHakkinda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHakkinda.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖTSTUR   Hiç olmadığı kadar gezeceksiniz. ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.btnDiller);
            this.panel3.Controls.Add(this.btnBolgeler);
            this.panel3.Controls.Add(this.btnYerler);
            this.panel3.Controls.Add(this.btnRehberler);
            this.panel3.Controls.Add(this.btnTurlar);
            this.panel3.Controls.Add(this.btnBiletSorgula);
            this.panel3.Controls.Add(this.btnBiletAl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 471);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1110, 154);
            this.panel3.TabIndex = 3;
            // 
            // btnDiller
            // 
            this.btnDiller.FlatAppearance.BorderSize = 0;
            this.btnDiller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiller.ForeColor = System.Drawing.Color.White;
            this.btnDiller.Image = ((System.Drawing.Image)(resources.GetObject("btnDiller.Image")));
            this.btnDiller.Location = new System.Drawing.Point(909, 15);
            this.btnDiller.Name = "btnDiller";
            this.btnDiller.Size = new System.Drawing.Size(148, 127);
            this.btnDiller.TabIndex = 11;
            this.btnDiller.Text = "Diller";
            this.btnDiller.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiller.UseVisualStyleBackColor = true;
            this.btnDiller.Click += new System.EventHandler(this.btnDiller_Click);
            // 
            // btnBolgeler
            // 
            this.btnBolgeler.FlatAppearance.BorderSize = 0;
            this.btnBolgeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBolgeler.ForeColor = System.Drawing.Color.White;
            this.btnBolgeler.Image = ((System.Drawing.Image)(resources.GetObject("btnBolgeler.Image")));
            this.btnBolgeler.Location = new System.Drawing.Point(756, 15);
            this.btnBolgeler.Name = "btnBolgeler";
            this.btnBolgeler.Size = new System.Drawing.Size(148, 127);
            this.btnBolgeler.TabIndex = 10;
            this.btnBolgeler.Text = "Bölgeler";
            this.btnBolgeler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBolgeler.UseVisualStyleBackColor = true;
            this.btnBolgeler.Click += new System.EventHandler(this.btnBolgeler_Click);
            // 
            // btnYerler
            // 
            this.btnYerler.FlatAppearance.BorderSize = 0;
            this.btnYerler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYerler.ForeColor = System.Drawing.Color.White;
            this.btnYerler.Image = ((System.Drawing.Image)(resources.GetObject("btnYerler.Image")));
            this.btnYerler.Location = new System.Drawing.Point(611, 15);
            this.btnYerler.Name = "btnYerler";
            this.btnYerler.Size = new System.Drawing.Size(148, 127);
            this.btnYerler.TabIndex = 9;
            this.btnYerler.Text = "Yerler";
            this.btnYerler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYerler.UseVisualStyleBackColor = true;
            this.btnYerler.Click += new System.EventHandler(this.btnYerler_Click);
            // 
            // btnRehberler
            // 
            this.btnRehberler.FlatAppearance.BorderSize = 0;
            this.btnRehberler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRehberler.ForeColor = System.Drawing.Color.White;
            this.btnRehberler.Image = ((System.Drawing.Image)(resources.GetObject("btnRehberler.Image")));
            this.btnRehberler.Location = new System.Drawing.Point(457, 15);
            this.btnRehberler.Name = "btnRehberler";
            this.btnRehberler.Size = new System.Drawing.Size(148, 127);
            this.btnRehberler.TabIndex = 8;
            this.btnRehberler.Text = "Rehberler";
            this.btnRehberler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRehberler.UseVisualStyleBackColor = true;
            this.btnRehberler.Click += new System.EventHandler(this.btnRehberler_Click);
            // 
            // btnTurlar
            // 
            this.btnTurlar.FlatAppearance.BorderSize = 0;
            this.btnTurlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurlar.ForeColor = System.Drawing.Color.White;
            this.btnTurlar.Image = ((System.Drawing.Image)(resources.GetObject("btnTurlar.Image")));
            this.btnTurlar.Location = new System.Drawing.Point(312, 15);
            this.btnTurlar.Name = "btnTurlar";
            this.btnTurlar.Size = new System.Drawing.Size(148, 127);
            this.btnTurlar.TabIndex = 7;
            this.btnTurlar.Text = "Turlar";
            this.btnTurlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTurlar.UseVisualStyleBackColor = true;
            this.btnTurlar.Click += new System.EventHandler(this.btnTurlar_Click);
            // 
            // btnBiletSorgula
            // 
            this.btnBiletSorgula.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBiletSorgula.FlatAppearance.BorderSize = 0;
            this.btnBiletSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiletSorgula.ForeColor = System.Drawing.Color.White;
            this.btnBiletSorgula.Image = ((System.Drawing.Image)(resources.GetObject("btnBiletSorgula.Image")));
            this.btnBiletSorgula.Location = new System.Drawing.Point(158, 15);
            this.btnBiletSorgula.Name = "btnBiletSorgula";
            this.btnBiletSorgula.Size = new System.Drawing.Size(148, 127);
            this.btnBiletSorgula.TabIndex = 6;
            this.btnBiletSorgula.Text = "Bilet Sorgula";
            this.btnBiletSorgula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBiletSorgula.UseVisualStyleBackColor = false;
            this.btnBiletSorgula.Click += new System.EventHandler(this.btnBiletSorgula_Click);
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.FlatAppearance.BorderSize = 0;
            this.btnBiletAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiletAl.ForeColor = System.Drawing.Color.White;
            this.btnBiletAl.Image = ((System.Drawing.Image)(resources.GetObject("btnBiletAl.Image")));
            this.btnBiletAl.Location = new System.Drawing.Point(13, 15);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(148, 127);
            this.btnBiletAl.TabIndex = 5;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.otsturuc1);
            this.panel4.Controls.Add(this.kampanyaUC1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1110, 324);
            this.panel4.TabIndex = 4;
            // 
            // otsturuc1
            // 
            this.otsturuc1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otsturuc1.BackgroundImage")));
            this.otsturuc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.otsturuc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otsturuc1.Location = new System.Drawing.Point(0, 0);
            this.otsturuc1.Name = "otsturuc1";
            this.otsturuc1.Size = new System.Drawing.Size(1110, 324);
            this.otsturuc1.TabIndex = 1;
            // 
            // kampanyaUC1
            // 
            this.kampanyaUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kampanyaUC1.BackgroundImage")));
            this.kampanyaUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kampanyaUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kampanyaUC1.Location = new System.Drawing.Point(0, 0);
            this.kampanyaUC1.Name = "kampanyaUC1";
            this.kampanyaUC1.Size = new System.Drawing.Size(1110, 324);
            this.kampanyaUC1.TabIndex = 0;
            this.kampanyaUC1.Visible = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1110, 625);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.Button btnDiller;
        private System.Windows.Forms.Button btnBolgeler;
        private System.Windows.Forms.Button btnYerler;
        private System.Windows.Forms.Button btnRehberler;
        private System.Windows.Forms.Button btnTurlar;
        private System.Windows.Forms.Button btnBiletSorgula;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Button btnWhatsapp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private UserControls.OTSTURUC otsturuc1;
        private UserControls.KampanyaUC kampanyaUC1;
    }
}