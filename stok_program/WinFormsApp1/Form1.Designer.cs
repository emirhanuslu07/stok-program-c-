namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            label4 = new Label();
            txtTarihi = new TextBox();
            label3 = new Label();
            txtMiktari = new TextBox();
            label2 = new Label();
            txtTuru = new TextBox();
            label1 = new Label();
            txtSahibi = new TextBox();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btnGüncelle = new Button();
            label5 = new Label();
            label7 = new Label();
            G_txtSahibi = new TextBox();
            G_txtMiktari = new TextBox();
            G_txtTarihi = new TextBox();
            G_txtTuru = new TextBox();
            label8 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            btnKayitSil = new Button();
            btnKayitMenu = new Button();
            btnGüncelleMenu = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(163, 206);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(425, 116);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtTarihi);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtMiktari);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtTuru);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtSahibi);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(417, 88);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Yeni Kayıt";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(4, 54);
            button2.Name = "button2";
            button2.Size = new Size(408, 28);
            button2.TabIndex = 8;
            button2.Text = "Yeni Kayıt Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(316, 4);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 7;
            label4.Text = "Tarihi";
            // 
            // txtTarihi
            // 
            txtTarihi.Location = new Point(313, 25);
            txtTarihi.Name = "txtTarihi";
            txtTarihi.Size = new Size(100, 23);
            txtTarihi.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(213, 4);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Miktarı";
            // 
            // txtMiktari
            // 
            txtMiktari.Location = new Point(210, 25);
            txtMiktari.Name = "txtMiktari";
            txtMiktari.Size = new Size(100, 23);
            txtMiktari.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(110, 4);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 3;
            label2.Text = "Türü";
            // 
            // txtTuru
            // 
            txtTuru.Location = new Point(107, 25);
            txtTuru.Name = "txtTuru";
            txtTuru.Size = new Size(100, 23);
            txtTuru.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 1;
            label1.Text = "Sahibi";
            // 
            // txtSahibi
            // 
            txtSahibi.Location = new Point(4, 25);
            txtSahibi.Name = "txtSahibi";
            txtSahibi.Size = new Size(100, 23);
            txtSahibi.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(417, 88);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Güncelleme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGüncelle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(G_txtSahibi);
            groupBox1.Controls.Add(G_txtMiktari);
            groupBox1.Controls.Add(G_txtTarihi);
            groupBox1.Controls.Add(G_txtTuru);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(-2, -12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 96);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGüncelle.Location = new Point(6, 65);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(408, 28);
            btnGüncelle.TabIndex = 9;
            btnGüncelle.Text = "Kayıtı Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(318, 16);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 15;
            label5.Text = "Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(112, 16);
            label7.Name = "label7";
            label7.Size = new Size(38, 21);
            label7.TabIndex = 11;
            label7.Text = "Türü";
            // 
            // G_txtSahibi
            // 
            G_txtSahibi.Location = new Point(6, 37);
            G_txtSahibi.Name = "G_txtSahibi";
            G_txtSahibi.Size = new Size(100, 23);
            G_txtSahibi.TabIndex = 8;
            // 
            // G_txtMiktari
            // 
            G_txtMiktari.Location = new Point(212, 37);
            G_txtMiktari.Name = "G_txtMiktari";
            G_txtMiktari.Size = new Size(100, 23);
            G_txtMiktari.TabIndex = 12;
            // 
            // G_txtTarihi
            // 
            G_txtTarihi.Location = new Point(315, 37);
            G_txtTarihi.Name = "G_txtTarihi";
            G_txtTarihi.Size = new Size(100, 23);
            G_txtTarihi.TabIndex = 14;
            // 
            // G_txtTuru
            // 
            G_txtTuru.Location = new Point(109, 37);
            G_txtTuru.Name = "G_txtTuru";
            G_txtTuru.Size = new Size(100, 23);
            G_txtTuru.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 16);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 9;
            label8.Text = "Sahibi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(215, 16);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 13;
            label6.Text = "Miktarı";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(163, 9);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(425, 191);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // btnKayitSil
            // 
            btnKayitSil.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitSil.Location = new Point(8, 77);
            btnKayitSil.Name = "btnKayitSil";
            btnKayitSil.Size = new Size(149, 28);
            btnKayitSil.TabIndex = 4;
            btnKayitSil.Text = "Kayıt Sil";
            btnKayitSil.UseVisualStyleBackColor = true;
            btnKayitSil.Click += btnKayitSil_Click;
            // 
            // btnKayitMenu
            // 
            btnKayitMenu.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitMenu.Location = new Point(8, 9);
            btnKayitMenu.Name = "btnKayitMenu";
            btnKayitMenu.Size = new Size(149, 28);
            btnKayitMenu.TabIndex = 5;
            btnKayitMenu.Text = "Kayıt Menüsü";
            btnKayitMenu.UseVisualStyleBackColor = true;
            btnKayitMenu.Click += btnKayitMenu_Click;
            // 
            // btnGüncelleMenu
            // 
            btnGüncelleMenu.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGüncelleMenu.Location = new Point(8, 43);
            btnGüncelleMenu.Name = "btnGüncelleMenu";
            btnGüncelleMenu.Size = new Size(149, 28);
            btnGüncelleMenu.TabIndex = 6;
            btnGüncelleMenu.Text = "Güncelleme Menüsü";
            btnGüncelleMenu.UseVisualStyleBackColor = true;
            btnGüncelleMenu.Click += btnGüncelleMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(597, 331);
            Controls.Add(btnGüncelleMenu);
            Controls.Add(btnKayitMenu);
            Controls.Add(btnKayitSil);
            Controls.Add(dataGridView1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button btnKayitSil;
        private Button btnKayitMenu;
        private Label label4;
        private TextBox txtTarihi;
        private Label label3;
        private TextBox txtMiktari;
        private Label label2;
        private TextBox txtTuru;
        private Label label1;
        private TextBox txtSahibi;
        private Button btnGüncelleMenu;
        private Label label5;
        private TextBox G_txtSahibi;
        private TextBox G_txtTarihi;
        private Label label8;
        private Label label6;
        private TextBox G_txtTuru;
        private TextBox G_txtMiktari;
        private Label label7;
        private Button button2;
        private Button btnGüncelle;
        private GroupBox groupBox1;
    }
}