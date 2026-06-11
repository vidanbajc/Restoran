namespace Restoran
{
    partial class Administrator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridview_prilozi = new System.Windows.Forms.DataGridView();
            this.id_priloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_priloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_priloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_jela = new System.Windows.Forms.DataGridView();
            this.id_jela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_jela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_jela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_naziv_jelo_prilog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_cena_jelo_prilog = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_odjavi_se = new System.Windows.Forms.Button();
            this.btn_novo_jelo_prilog = new System.Windows.Forms.Button();
            this.btn_obrisi_jelo_prilog = new System.Windows.Forms.Button();
            this.btn_izmeni_jelo_prilog = new System.Windows.Forms.Button();
            this.btn_povezi_jelo_prilog = new System.Windows.Forms.Button();
            this.rb_jelo = new System.Windows.Forms.RadioButton();
            this.rb_prilog = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_prilozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_jela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cena_jelo_prilog)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Prilozi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 24;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_prilozi.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_prilozi.Location = new System.Drawing.Point(16, 246);
            this.gridview_prilozi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridview_prilozi.Name = "gridview_prilozi";
            this.gridview_prilozi.ReadOnly = true;
            this.gridview_prilozi.RowHeadersWidth = 51;
            this.gridview_prilozi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_prilozi.Size = new System.Drawing.Size(571, 166);
            this.gridview_prilozi.TabIndex = 23;
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
            // gridview_jela
            // 
            this.gridview_jela.AllowUserToAddRows = false;
            this.gridview_jela.AllowUserToDeleteRows = false;
            this.gridview_jela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_jela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_jela,
            this.naziv_jela,
            this.cena_jela});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_jela.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_jela.Location = new System.Drawing.Point(16, 38);
            this.gridview_jela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridview_jela.Name = "gridview_jela";
            this.gridview_jela.ReadOnly = true;
            this.gridview_jela.RowHeadersWidth = 51;
            this.gridview_jela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_jela.Size = new System.Drawing.Size(571, 166);
            this.gridview_jela.TabIndex = 22;
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
            // tb_naziv_jelo_prilog
            // 
            this.tb_naziv_jelo_prilog.Location = new System.Drawing.Point(616, 57);
            this.tb_naziv_jelo_prilog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_naziv_jelo_prilog.Name = "tb_naziv_jelo_prilog";
            this.tb_naziv_jelo_prilog.Size = new System.Drawing.Size(132, 22);
            this.tb_naziv_jelo_prilog.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Naziv jela/priloga";
            // 
            // nud_cena_jelo_prilog
            // 
            this.nud_cena_jelo_prilog.Location = new System.Drawing.Point(616, 112);
            this.nud_cena_jelo_prilog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_cena_jelo_prilog.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_cena_jelo_prilog.Name = "nud_cena_jelo_prilog";
            this.nud_cena_jelo_prilog.Size = new System.Drawing.Size(133, 22);
            this.nud_cena_jelo_prilog.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cena jela/priloga";
            // 
            // btn_odjavi_se
            // 
            this.btn_odjavi_se.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odjavi_se.Location = new System.Drawing.Point(783, 342);
            this.btn_odjavi_se.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_odjavi_se.Name = "btn_odjavi_se";
            this.btn_odjavi_se.Size = new System.Drawing.Size(175, 70);
            this.btn_odjavi_se.TabIndex = 35;
            this.btn_odjavi_se.Text = "Izadji";
            this.btn_odjavi_se.UseVisualStyleBackColor = true;
            this.btn_odjavi_se.Click += new System.EventHandler(this.btn_odjavi_se_Click);
            // 
            // btn_novo_jelo_prilog
            // 
            this.btn_novo_jelo_prilog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo_jelo_prilog.Location = new System.Drawing.Point(783, 31);
            this.btn_novo_jelo_prilog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_novo_jelo_prilog.Name = "btn_novo_jelo_prilog";
            this.btn_novo_jelo_prilog.Size = new System.Drawing.Size(175, 70);
            this.btn_novo_jelo_prilog.TabIndex = 34;
            this.btn_novo_jelo_prilog.Text = "Novo jelo/prilog";
            this.btn_novo_jelo_prilog.UseVisualStyleBackColor = true;
            this.btn_novo_jelo_prilog.Click += new System.EventHandler(this.btn_novo_jelo_prilog_Click);
            // 
            // btn_obrisi_jelo_prilog
            // 
            this.btn_obrisi_jelo_prilog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi_jelo_prilog.Location = new System.Drawing.Point(783, 187);
            this.btn_obrisi_jelo_prilog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_obrisi_jelo_prilog.Name = "btn_obrisi_jelo_prilog";
            this.btn_obrisi_jelo_prilog.Size = new System.Drawing.Size(175, 70);
            this.btn_obrisi_jelo_prilog.TabIndex = 33;
            this.btn_obrisi_jelo_prilog.Text = "Obrisi jelo/prilog";
            this.btn_obrisi_jelo_prilog.UseVisualStyleBackColor = true;
            this.btn_obrisi_jelo_prilog.Click += new System.EventHandler(this.btn_obrisi_jelo_prilog_Click);
            // 
            // btn_izmeni_jelo_prilog
            // 
            this.btn_izmeni_jelo_prilog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni_jelo_prilog.Location = new System.Drawing.Point(783, 108);
            this.btn_izmeni_jelo_prilog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_izmeni_jelo_prilog.Name = "btn_izmeni_jelo_prilog";
            this.btn_izmeni_jelo_prilog.Size = new System.Drawing.Size(175, 70);
            this.btn_izmeni_jelo_prilog.TabIndex = 32;
            this.btn_izmeni_jelo_prilog.Text = "Izmeni jelo/prilog";
            this.btn_izmeni_jelo_prilog.UseVisualStyleBackColor = true;
            this.btn_izmeni_jelo_prilog.Click += new System.EventHandler(this.btn_izmeni_jelo_prilog_Click);
            // 
            // btn_povezi_jelo_prilog
            // 
            this.btn_povezi_jelo_prilog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_povezi_jelo_prilog.Location = new System.Drawing.Point(783, 265);
            this.btn_povezi_jelo_prilog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_povezi_jelo_prilog.Name = "btn_povezi_jelo_prilog";
            this.btn_povezi_jelo_prilog.Size = new System.Drawing.Size(175, 70);
            this.btn_povezi_jelo_prilog.TabIndex = 31;
            this.btn_povezi_jelo_prilog.Text = "Povezi jelo i prilog";
            this.btn_povezi_jelo_prilog.UseVisualStyleBackColor = true;
            this.btn_povezi_jelo_prilog.Click += new System.EventHandler(this.btn_povezi_jelo_prilog_Click);
            // 
            // rb_jelo
            // 
            this.rb_jelo.AutoSize = true;
            this.rb_jelo.Checked = true;
            this.rb_jelo.Location = new System.Drawing.Point(616, 145);
            this.rb_jelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_jelo.Name = "rb_jelo";
            this.rb_jelo.Size = new System.Drawing.Size(54, 20);
            this.rb_jelo.TabIndex = 36;
            this.rb_jelo.TabStop = true;
            this.rb_jelo.Text = "Jelo";
            this.rb_jelo.UseVisualStyleBackColor = true;
            // 
            // rb_prilog
            // 
            this.rb_prilog.AutoSize = true;
            this.rb_prilog.Location = new System.Drawing.Point(616, 174);
            this.rb_prilog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_prilog.Name = "rb_prilog";
            this.rb_prilog.Size = new System.Drawing.Size(63, 20);
            this.rb_prilog.TabIndex = 37;
            this.rb_prilog.Text = "Prilog";
            this.rb_prilog.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 427);
            this.Controls.Add(this.rb_prilog);
            this.Controls.Add(this.rb_jelo);
            this.Controls.Add(this.btn_odjavi_se);
            this.Controls.Add(this.btn_novo_jelo_prilog);
            this.Controls.Add(this.btn_obrisi_jelo_prilog);
            this.Controls.Add(this.btn_izmeni_jelo_prilog);
            this.Controls.Add(this.btn_povezi_jelo_prilog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_cena_jelo_prilog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_naziv_jelo_prilog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridview_prilozi);
            this.Controls.Add(this.gridview_jela);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.gridview_prilozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_jela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cena_jelo_prilog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridview_prilozi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_priloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_priloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_priloga;
        private System.Windows.Forms.DataGridView gridview_jela;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jela;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_jela;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_jela;
        private System.Windows.Forms.TextBox tb_naziv_jelo_prilog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_cena_jelo_prilog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_odjavi_se;
        private System.Windows.Forms.Button btn_novo_jelo_prilog;
        private System.Windows.Forms.Button btn_obrisi_jelo_prilog;
        private System.Windows.Forms.Button btn_izmeni_jelo_prilog;
        private System.Windows.Forms.Button btn_povezi_jelo_prilog;
        private System.Windows.Forms.RadioButton rb_jelo;
        private System.Windows.Forms.RadioButton rb_prilog;
    }
}