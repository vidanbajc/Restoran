namespace Restoran
{
    partial class Meni
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_naziv_priloga = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_filtriraj = new System.Windows.Forms.Button();
            this.btn_sacuvaj_stavku = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_do = new System.Windows.Forms.Label();
            this.lbl_od = new System.Windows.Forms.Label();
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
            this.btn_sacuvaj_racun = new System.Windows.Forms.Button();
            this.btn_izadji = new System.Windows.Forms.Button();
            this.id_priloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_priloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_priloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_jela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_jela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_jela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_prilozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_jela)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_naziv_priloga);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(923, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(208, 116);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtriraj po Prilogu";
            // 
            // cb_naziv_priloga
            // 
            this.cb_naziv_priloga.FormattingEnabled = true;
            this.cb_naziv_priloga.Location = new System.Drawing.Point(8, 60);
            this.cb_naziv_priloga.Margin = new System.Windows.Forms.Padding(4);
            this.cb_naziv_priloga.Name = "cb_naziv_priloga";
            this.cb_naziv_priloga.Size = new System.Drawing.Size(163, 32);
            this.cb_naziv_priloga.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Naziv priloga";
            // 
            // btn_filtriraj
            // 
            this.btn_filtriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtriraj.Location = new System.Drawing.Point(931, 169);
            this.btn_filtriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtriraj.Name = "btn_filtriraj";
            this.btn_filtriraj.Size = new System.Drawing.Size(175, 70);
            this.btn_filtriraj.TabIndex = 23;
            this.btn_filtriraj.Text = "Filtriraj";
            this.btn_filtriraj.UseVisualStyleBackColor = true;
            this.btn_filtriraj.Click += new System.EventHandler(this.btn_filtriraj_Click);
            // 
            // btn_sacuvaj_stavku
            // 
            this.btn_sacuvaj_stavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sacuvaj_stavku.Location = new System.Drawing.Point(931, 247);
            this.btn_sacuvaj_stavku.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sacuvaj_stavku.Name = "btn_sacuvaj_stavku";
            this.btn_sacuvaj_stavku.Size = new System.Drawing.Size(175, 70);
            this.btn_sacuvaj_stavku.TabIndex = 24;
            this.btn_sacuvaj_stavku.Text = "Sacuvaj stavku";
            this.btn_sacuvaj_stavku.UseVisualStyleBackColor = true;
            this.btn_sacuvaj_stavku.Click += new System.EventHandler(this.btn_sacuvaj_stavku_Click);
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
            this.groupBox3.Location = new System.Drawing.Point(703, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(189, 262);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtriraj po Jelu";
            // 
            // lbl_do
            // 
            this.lbl_do.AutoSize = true;
            this.lbl_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_do.Location = new System.Drawing.Point(84, 176);
            this.lbl_do.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_do.Name = "lbl_do";
            this.lbl_do.Size = new System.Drawing.Size(16, 18);
            this.lbl_do.TabIndex = 19;
            this.lbl_do.Text = "0";
            // 
            // lbl_od
            // 
            this.lbl_od.AutoSize = true;
            this.lbl_od.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_od.Location = new System.Drawing.Point(84, 96);
            this.lbl_od.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_od.Name = "lbl_od";
            this.lbl_od.Size = new System.Drawing.Size(16, 18);
            this.lbl_od.TabIndex = 18;
            this.lbl_od.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cena do";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 100;
            this.trackBar2.Location = new System.Drawing.Point(0, 199);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Maximum = 5000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(172, 56);
            this.trackBar2.SmallChange = 10;
            this.trackBar2.TabIndex = 6;
            this.trackBar2.TickFrequency = 100;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cena od";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(0, 119);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(172, 56);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cb_naziv_jela
            // 
            this.cb_naziv_jela.FormattingEnabled = true;
            this.cb_naziv_jela.Location = new System.Drawing.Point(8, 60);
            this.cb_naziv_jela.Margin = new System.Windows.Forms.Padding(4);
            this.cb_naziv_jela.Name = "cb_naziv_jela";
            this.cb_naziv_jela.Size = new System.Drawing.Size(163, 32);
            this.cb_naziv_jela.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Naziv jela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Prilozi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Jela";
            // 
            // gridview_prilozi
            // 
            this.gridview_prilozi.AllowUserToAddRows = false;
            this.gridview_prilozi.AllowUserToDeleteRows = false;
            this.gridview_prilozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_prilozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_priloga,
            this.naziv_priloga,
            this.cena_priloga});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_prilozi.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridview_prilozi.Location = new System.Drawing.Point(17, 314);
            this.gridview_prilozi.Margin = new System.Windows.Forms.Padding(4);
            this.gridview_prilozi.Name = "gridview_prilozi";
            this.gridview_prilozi.ReadOnly = true;
            this.gridview_prilozi.RowHeadersWidth = 51;
            this.gridview_prilozi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_prilozi.Size = new System.Drawing.Size(613, 228);
            this.gridview_prilozi.TabIndex = 19;
            // 
            // gridview_jela
            // 
            this.gridview_jela.AllowUserToAddRows = false;
            this.gridview_jela.AllowUserToDeleteRows = false;
            this.gridview_jela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_jela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_jela,
            this.naziv_jela,
            this.cena_jela});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_jela.DefaultCellStyle = dataGridViewCellStyle10;
            this.gridview_jela.Location = new System.Drawing.Point(17, 37);
            this.gridview_jela.Margin = new System.Windows.Forms.Padding(4);
            this.gridview_jela.Name = "gridview_jela";
            this.gridview_jela.ReadOnly = true;
            this.gridview_jela.RowHeadersWidth = 51;
            this.gridview_jela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_jela.Size = new System.Drawing.Size(613, 228);
            this.gridview_jela.TabIndex = 18;
            this.gridview_jela.SelectionChanged += new System.EventHandler(this.gridview_jela_SelectionChanged);
            // 
            // btn_sacuvaj_racun
            // 
            this.btn_sacuvaj_racun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sacuvaj_racun.Location = new System.Drawing.Point(931, 325);
            this.btn_sacuvaj_racun.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sacuvaj_racun.Name = "btn_sacuvaj_racun";
            this.btn_sacuvaj_racun.Size = new System.Drawing.Size(175, 70);
            this.btn_sacuvaj_racun.TabIndex = 26;
            this.btn_sacuvaj_racun.Text = "Sacuvaj racun";
            this.btn_sacuvaj_racun.UseVisualStyleBackColor = true;
            this.btn_sacuvaj_racun.Click += new System.EventHandler(this.btn_sacuvaj_racun_Click);
            // 
            // btn_izadji
            // 
            this.btn_izadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izadji.Location = new System.Drawing.Point(931, 403);
            this.btn_izadji.Margin = new System.Windows.Forms.Padding(4);
            this.btn_izadji.Name = "btn_izadji";
            this.btn_izadji.Size = new System.Drawing.Size(175, 70);
            this.btn_izadji.TabIndex = 27;
            this.btn_izadji.Text = "Izadji";
            this.btn_izadji.UseVisualStyleBackColor = true;
            this.btn_izadji.Click += new System.EventHandler(this.btn_izadji_Click);
            // 
            // id_priloga
            // 
            this.id_priloga.DataPropertyName = "id_prilog";
            this.id_priloga.HeaderText = "sifra";
            this.id_priloga.MinimumWidth = 6;
            this.id_priloga.Name = "id_priloga";
            this.id_priloga.ReadOnly = true;
            this.id_priloga.Width = 125;
            // 
            // naziv_priloga
            // 
            this.naziv_priloga.DataPropertyName = "naziv";
            this.naziv_priloga.HeaderText = "naziv";
            this.naziv_priloga.MinimumWidth = 6;
            this.naziv_priloga.Name = "naziv_priloga";
            this.naziv_priloga.ReadOnly = true;
            this.naziv_priloga.Width = 125;
            // 
            // cena_priloga
            // 
            this.cena_priloga.DataPropertyName = "cena";
            this.cena_priloga.HeaderText = "cena";
            this.cena_priloga.MinimumWidth = 6;
            this.cena_priloga.Name = "cena_priloga";
            this.cena_priloga.ReadOnly = true;
            this.cena_priloga.Width = 125;
            // 
            // id_jela
            // 
            this.id_jela.DataPropertyName = "id_jelo";
            this.id_jela.HeaderText = "sifra";
            this.id_jela.MinimumWidth = 6;
            this.id_jela.Name = "id_jela";
            this.id_jela.ReadOnly = true;
            this.id_jela.Width = 125;
            // 
            // naziv_jela
            // 
            this.naziv_jela.DataPropertyName = "naziv";
            this.naziv_jela.HeaderText = "naziv";
            this.naziv_jela.MinimumWidth = 6;
            this.naziv_jela.Name = "naziv_jela";
            this.naziv_jela.ReadOnly = true;
            this.naziv_jela.Width = 125;
            // 
            // cena_jela
            // 
            this.cena_jela.DataPropertyName = "cena";
            this.cena_jela.HeaderText = "cena";
            this.cena_jela.MinimumWidth = 6;
            this.cena_jela.Name = "cena_jela";
            this.cena_jela.ReadOnly = true;
            this.cena_jela.Width = 125;
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 555);
            this.Controls.Add(this.btn_izadji);
            this.Controls.Add(this.btn_sacuvaj_racun);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_filtriraj);
            this.Controls.Add(this.btn_sacuvaj_stavku);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridview_prilozi);
            this.Controls.Add(this.gridview_jela);
            this.Name = "Meni";
            this.Text = "Meni";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_prilozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_jela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_naziv_priloga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_filtriraj;
        private System.Windows.Forms.Button btn_sacuvaj_stavku;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_do;
        private System.Windows.Forms.Label lbl_od;
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
        private System.Windows.Forms.Button btn_izadji;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_priloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_priloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_priloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jela;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_jela;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_jela;
    }
}