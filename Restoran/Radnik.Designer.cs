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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_naziv_priloga = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_filtriraj = new System.Windows.Forms.Button();
            this.btn_novi_racun = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cb_naziv_jela = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridview_prilozi = new System.Windows.Forms.DataGridView();
            this.gridview_jela = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_sacuvaj_racun = new System.Windows.Forms.Button();
            this.btn_obrisi_stavku = new System.Windows.Forms.Button();
            this.btn_izmeni_stavku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridview_stavke_racuna = new System.Windows.Forms.DataGridView();
            this.gridview_racuni = new System.Windows.Forms.DataGridView();
            this.btn_dodaj_stavku = new System.Windows.Forms.Button();
            this.lbl_od = new System.Windows.Forms.Label();
            this.lbl_do = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_prilozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_jela)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_stavke_racuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_racuni)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.btn_filtriraj);
            this.tabPage1.Controls.Add(this.btn_novi_racun);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gridview_prilozi);
            this.tabPage1.Controls.Add(this.gridview_jela);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jela i Prilozi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_naziv_priloga);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(156, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 94);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtriraj po Prilogu";
            // 
            // cb_naziv_priloga
            // 
            this.cb_naziv_priloga.FormattingEnabled = true;
            this.cb_naziv_priloga.Location = new System.Drawing.Point(6, 49);
            this.cb_naziv_priloga.Name = "cb_naziv_priloga";
            this.cb_naziv_priloga.Size = new System.Drawing.Size(123, 26);
            this.cb_naziv_priloga.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Naziv priloga";
            // 
            // btn_filtriraj
            // 
            this.btn_filtriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtriraj.Location = new System.Drawing.Point(171, 319);
            this.btn_filtriraj.Name = "btn_filtriraj";
            this.btn_filtriraj.Size = new System.Drawing.Size(114, 38);
            this.btn_filtriraj.TabIndex = 15;
            this.btn_filtriraj.Text = "Filtriraj";
            this.btn_filtriraj.UseVisualStyleBackColor = true;
            this.btn_filtriraj.Click += new System.EventHandler(this.btn_filtriraj_Click);
            // 
            // btn_novi_racun
            // 
            this.btn_novi_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novi_racun.Location = new System.Drawing.Point(171, 363);
            this.btn_novi_racun.Name = "btn_novi_racun";
            this.btn_novi_racun.Size = new System.Drawing.Size(114, 38);
            this.btn_novi_racun.TabIndex = 16;
            this.btn_novi_racun.Text = "Novi racun";
            this.btn_novi_racun.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_do);
            this.groupBox3.Controls.Add(this.lbl_od);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.trackBar2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.cb_naziv_jela);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 213);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtriraj po Jelu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cena do";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 100;
            this.trackBar2.Location = new System.Drawing.Point(3, 162);
            this.trackBar2.Maximum = 5000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(129, 45);
            this.trackBar2.SmallChange = 10;
            this.trackBar2.TabIndex = 6;
            this.trackBar2.TickFrequency = 100;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cena od";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(0, 97);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(129, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cb_naziv_jela
            // 
            this.cb_naziv_jela.FormattingEnabled = true;
            this.cb_naziv_jela.Location = new System.Drawing.Point(6, 49);
            this.cb_naziv_jela.Name = "cb_naziv_jela";
            this.cb_naziv_jela.Size = new System.Drawing.Size(123, 26);
            this.cb_naziv_jela.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Naziv jela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prilozi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jela";
            // 
            // gridview_prilozi
            // 
            this.gridview_prilozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_prilozi.DefaultCellStyle = dataGridViewCellStyle17;
            this.gridview_prilozi.Location = new System.Drawing.Point(367, 25);
            this.gridview_prilozi.Name = "gridview_prilozi";
            this.gridview_prilozi.Size = new System.Drawing.Size(350, 150);
            this.gridview_prilozi.TabIndex = 11;
            // 
            // gridview_jela
            // 
            this.gridview_jela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_jela.DefaultCellStyle = dataGridViewCellStyle18;
            this.gridview_jela.Location = new System.Drawing.Point(8, 25);
            this.gridview_jela.Name = "gridview_jela";
            this.gridview_jela.Size = new System.Drawing.Size(350, 150);
            this.gridview_jela.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_sacuvaj_racun);
            this.tabPage2.Controls.Add(this.btn_obrisi_stavku);
            this.tabPage2.Controls.Add(this.btn_izmeni_stavku);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.gridview_stavke_racuna);
            this.tabPage2.Controls.Add(this.gridview_racuni);
            this.tabPage2.Controls.Add(this.btn_dodaj_stavku);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Racuni";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_sacuvaj_racun
            // 
            this.btn_sacuvaj_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sacuvaj_racun.Location = new System.Drawing.Point(603, 363);
            this.btn_sacuvaj_racun.Name = "btn_sacuvaj_racun";
            this.btn_sacuvaj_racun.Size = new System.Drawing.Size(114, 38);
            this.btn_sacuvaj_racun.TabIndex = 20;
            this.btn_sacuvaj_racun.Text = "Sacuvaj racun";
            this.btn_sacuvaj_racun.UseVisualStyleBackColor = true;
            // 
            // btn_obrisi_stavku
            // 
            this.btn_obrisi_stavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi_stavku.Location = new System.Drawing.Point(603, 319);
            this.btn_obrisi_stavku.Name = "btn_obrisi_stavku";
            this.btn_obrisi_stavku.Size = new System.Drawing.Size(114, 38);
            this.btn_obrisi_stavku.TabIndex = 19;
            this.btn_obrisi_stavku.Text = "Obrisi stavku";
            this.btn_obrisi_stavku.UseVisualStyleBackColor = true;
            // 
            // btn_izmeni_stavku
            // 
            this.btn_izmeni_stavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni_stavku.Location = new System.Drawing.Point(603, 275);
            this.btn_izmeni_stavku.Name = "btn_izmeni_stavku";
            this.btn_izmeni_stavku.Size = new System.Drawing.Size(114, 38);
            this.btn_izmeni_stavku.TabIndex = 18;
            this.btn_izmeni_stavku.Text = "Izmeni stavku";
            this.btn_izmeni_stavku.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stavke Racuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Racuni";
            // 
            // gridview_stavke_racuna
            // 
            this.gridview_stavke_racuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_stavke_racuna.DefaultCellStyle = dataGridViewCellStyle19;
            this.gridview_stavke_racuna.Location = new System.Drawing.Point(367, 25);
            this.gridview_stavke_racuna.Name = "gridview_stavke_racuna";
            this.gridview_stavke_racuna.Size = new System.Drawing.Size(350, 150);
            this.gridview_stavke_racuna.TabIndex = 14;
            // 
            // gridview_racuni
            // 
            this.gridview_racuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_racuni.DefaultCellStyle = dataGridViewCellStyle20;
            this.gridview_racuni.Location = new System.Drawing.Point(8, 25);
            this.gridview_racuni.Name = "gridview_racuni";
            this.gridview_racuni.Size = new System.Drawing.Size(350, 150);
            this.gridview_racuni.TabIndex = 13;
            // 
            // btn_dodaj_stavku
            // 
            this.btn_dodaj_stavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj_stavku.Location = new System.Drawing.Point(603, 231);
            this.btn_dodaj_stavku.Name = "btn_dodaj_stavku";
            this.btn_dodaj_stavku.Size = new System.Drawing.Size(114, 38);
            this.btn_dodaj_stavku.TabIndex = 17;
            this.btn_dodaj_stavku.Text = "Dodaj stavku";
            this.btn_dodaj_stavku.UseVisualStyleBackColor = true;
            // 
            // lbl_od
            // 
            this.lbl_od.AutoSize = true;
            this.lbl_od.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_od.Location = new System.Drawing.Point(63, 78);
            this.lbl_od.Name = "lbl_od";
            this.lbl_od.Size = new System.Drawing.Size(14, 15);
            this.lbl_od.TabIndex = 18;
            this.lbl_od.Text = "0";
            // 
            // lbl_do
            // 
            this.lbl_do.AutoSize = true;
            this.lbl_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_do.Location = new System.Drawing.Point(63, 143);
            this.lbl_do.Name = "lbl_do";
            this.lbl_do.Size = new System.Drawing.Size(14, 15);
            this.lbl_do.TabIndex = 19;
            this.lbl_do.Text = "0";
            // 
            // Radnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "Radnik";
            this.Text = "Radnik";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_prilozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_jela)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_stavke_racuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_racuni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_naziv_priloga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_filtriraj;
        private System.Windows.Forms.Button btn_novi_racun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox cb_naziv_jela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridview_prilozi;
        private System.Windows.Forms.DataGridView gridview_jela;
        private System.Windows.Forms.Button btn_sacuvaj_racun;
        private System.Windows.Forms.Button btn_obrisi_stavku;
        private System.Windows.Forms.Button btn_izmeni_stavku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridview_stavke_racuna;
        private System.Windows.Forms.DataGridView gridview_racuni;
        private System.Windows.Forms.Button btn_dodaj_stavku;
        private System.Windows.Forms.Label lbl_do;
        private System.Windows.Forms.Label lbl_od;
    }
}