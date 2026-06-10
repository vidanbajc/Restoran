namespace Restoran
{
    partial class Radnik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_obrisi_stavku = new System.Windows.Forms.Button();
            this.btn_izmeni_stavku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridview_stavke_racuna = new System.Windows.Forms.DataGridView();
            this.id_racun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_jelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prilog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_jelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_prilog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_racuni = new System.Windows.Forms.DataGridView();
            this.id_racuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupna_cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_dodaj_stavku = new System.Windows.Forms.Button();
            this.btn_novi_racun = new System.Windows.Forms.Button();
            this.btn_odjavi_se = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_stavke_racuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_racuni)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_obrisi_stavku
            // 
            this.btn_obrisi_stavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi_stavku.Location = new System.Drawing.Point(672, 332);
            this.btn_obrisi_stavku.Margin = new System.Windows.Forms.Padding(4);
            this.btn_obrisi_stavku.Name = "btn_obrisi_stavku";
            this.btn_obrisi_stavku.Size = new System.Drawing.Size(175, 70);
            this.btn_obrisi_stavku.TabIndex = 27;
            this.btn_obrisi_stavku.Text = "Obrisi stavku";
            this.btn_obrisi_stavku.UseVisualStyleBackColor = true;
            // 
            // btn_izmeni_stavku
            // 
            this.btn_izmeni_stavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni_stavku.Location = new System.Drawing.Point(672, 254);
            this.btn_izmeni_stavku.Margin = new System.Windows.Forms.Padding(4);
            this.btn_izmeni_stavku.Name = "btn_izmeni_stavku";
            this.btn_izmeni_stavku.Size = new System.Drawing.Size(175, 70);
            this.btn_izmeni_stavku.TabIndex = 26;
            this.btn_izmeni_stavku.Text = "Izmeni stavku";
            this.btn_izmeni_stavku.UseVisualStyleBackColor = true;
            this.btn_izmeni_stavku.Click += new System.EventHandler(this.btn_izmeni_stavku_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stavke Racuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Racuni";
            // 
            // gridview_stavke_racuna
            // 
            this.gridview_stavke_racuna.AllowUserToAddRows = false;
            this.gridview_stavke_racuna.AllowUserToDeleteRows = false;
            this.gridview_stavke_racuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_stavke_racuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_racun,
            this.id_jelo,
            this.id_prilog,
            this.cena_jelo,
            this.cena_prilog,
            this.kolicina});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_stavke_racuna.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_stavke_racuna.Location = new System.Drawing.Point(17, 314);
            this.gridview_stavke_racuna.Margin = new System.Windows.Forms.Padding(4);
            this.gridview_stavke_racuna.Name = "gridview_stavke_racuna";
            this.gridview_stavke_racuna.ReadOnly = true;
            this.gridview_stavke_racuna.RowHeadersWidth = 51;
            this.gridview_stavke_racuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_stavke_racuna.Size = new System.Drawing.Size(613, 228);
            this.gridview_stavke_racuna.TabIndex = 22;
            // 
            // id_racun
            // 
            this.id_racun.DataPropertyName = "id_racun";
            this.id_racun.HeaderText = "sifra racuna";
            this.id_racun.MinimumWidth = 6;
            this.id_racun.Name = "id_racun";
            this.id_racun.ReadOnly = true;
            this.id_racun.Width = 125;
            // 
            // id_jelo
            // 
            this.id_jelo.DataPropertyName = "id_jelo";
            this.id_jelo.HeaderText = "sifra jela";
            this.id_jelo.MinimumWidth = 6;
            this.id_jelo.Name = "id_jelo";
            this.id_jelo.ReadOnly = true;
            this.id_jelo.Width = 125;
            // 
            // id_prilog
            // 
            this.id_prilog.DataPropertyName = "id_prilog";
            this.id_prilog.HeaderText = "sifra prilog";
            this.id_prilog.MinimumWidth = 6;
            this.id_prilog.Name = "id_prilog";
            this.id_prilog.ReadOnly = true;
            this.id_prilog.Width = 125;
            // 
            // cena_jelo
            // 
            this.cena_jelo.DataPropertyName = "cenaJelo";
            this.cena_jelo.HeaderText = "cena jela";
            this.cena_jelo.MinimumWidth = 6;
            this.cena_jelo.Name = "cena_jelo";
            this.cena_jelo.ReadOnly = true;
            this.cena_jelo.Width = 125;
            // 
            // cena_prilog
            // 
            this.cena_prilog.DataPropertyName = "cenaPrilog";
            this.cena_prilog.HeaderText = "cena priloga";
            this.cena_prilog.MinimumWidth = 6;
            this.cena_prilog.Name = "cena_prilog";
            this.cena_prilog.ReadOnly = true;
            this.cena_prilog.Width = 125;
            // 
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "kolicina";
            this.kolicina.MinimumWidth = 6;
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            this.kolicina.Width = 125;
            // 
            // gridview_racuni
            // 
            this.gridview_racuni.AllowUserToAddRows = false;
            this.gridview_racuni.AllowUserToDeleteRows = false;
            this.gridview_racuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_racuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_racuna,
            this.ukupna_cena});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_racuni.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_racuni.Location = new System.Drawing.Point(17, 38);
            this.gridview_racuni.Margin = new System.Windows.Forms.Padding(4);
            this.gridview_racuni.Name = "gridview_racuni";
            this.gridview_racuni.ReadOnly = true;
            this.gridview_racuni.RowHeadersWidth = 51;
            this.gridview_racuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_racuni.Size = new System.Drawing.Size(613, 228);
            this.gridview_racuni.TabIndex = 21;
            this.gridview_racuni.SelectionChanged += new System.EventHandler(this.gridview_racuni_SelectionChanged);
            // 
            // id_racuna
            // 
            this.id_racuna.DataPropertyName = "id_racun";
            this.id_racuna.HeaderText = "sifra";
            this.id_racuna.MinimumWidth = 6;
            this.id_racuna.Name = "id_racuna";
            this.id_racuna.ReadOnly = true;
            this.id_racuna.Width = 125;
            // 
            // ukupna_cena
            // 
            this.ukupna_cena.DataPropertyName = "ukupna_cena";
            this.ukupna_cena.HeaderText = "ukupna cena";
            this.ukupna_cena.MinimumWidth = 6;
            this.ukupna_cena.Name = "ukupna_cena";
            this.ukupna_cena.ReadOnly = true;
            this.ukupna_cena.Width = 125;
            // 
            // btn_dodaj_stavku
            // 
            this.btn_dodaj_stavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj_stavku.Location = new System.Drawing.Point(672, 176);
            this.btn_dodaj_stavku.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dodaj_stavku.Name = "btn_dodaj_stavku";
            this.btn_dodaj_stavku.Size = new System.Drawing.Size(175, 70);
            this.btn_dodaj_stavku.TabIndex = 25;
            this.btn_dodaj_stavku.Text = "Dodaj stavku";
            this.btn_dodaj_stavku.UseVisualStyleBackColor = true;
            this.btn_dodaj_stavku.Click += new System.EventHandler(this.btn_dodaj_stavku_Click);
            // 
            // btn_novi_racun
            // 
            this.btn_novi_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novi_racun.Location = new System.Drawing.Point(672, 98);
            this.btn_novi_racun.Margin = new System.Windows.Forms.Padding(4);
            this.btn_novi_racun.Name = "btn_novi_racun";
            this.btn_novi_racun.Size = new System.Drawing.Size(175, 70);
            this.btn_novi_racun.TabIndex = 29;
            this.btn_novi_racun.Text = "Novi racun";
            this.btn_novi_racun.UseVisualStyleBackColor = true;
            this.btn_novi_racun.Click += new System.EventHandler(this.btn_novi_racun_Click);
            // 
            // btn_odjavi_se
            // 
            this.btn_odjavi_se.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odjavi_se.Location = new System.Drawing.Point(672, 410);
            this.btn_odjavi_se.Margin = new System.Windows.Forms.Padding(4);
            this.btn_odjavi_se.Name = "btn_odjavi_se";
            this.btn_odjavi_se.Size = new System.Drawing.Size(175, 70);
            this.btn_odjavi_se.TabIndex = 30;
            this.btn_odjavi_se.Text = "Izadji";
            this.btn_odjavi_se.UseVisualStyleBackColor = true;
            this.btn_odjavi_se.Click += new System.EventHandler(this.btn_odjavi_se_Click);
            // 
            // Radnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 555);
            this.Controls.Add(this.btn_odjavi_se);
            this.Controls.Add(this.btn_novi_racun);
            this.Controls.Add(this.btn_obrisi_stavku);
            this.Controls.Add(this.btn_izmeni_stavku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridview_stavke_racuna);
            this.Controls.Add(this.gridview_racuni);
            this.Controls.Add(this.btn_dodaj_stavku);
            this.Name = "Radnik";
            this.Text = "Racuni";
            ((System.ComponentModel.ISupportInitialize)(this.gridview_stavke_racuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_racuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_obrisi_stavku;
        private System.Windows.Forms.Button btn_izmeni_stavku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridview_stavke_racuna;
        private System.Windows.Forms.DataGridView gridview_racuni;
        private System.Windows.Forms.Button btn_dodaj_stavku;
        private System.Windows.Forms.Button btn_novi_racun;
        private System.Windows.Forms.Button btn_odjavi_se;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_racuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupna_cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_racun;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prilog;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_jelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_prilog;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
    }
}