namespace eCommerce
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
            btnAggiungi = new Button();
            btnRimuovi = new Button();
            label1 = new Label();
            numProdotti = new Label();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnSvuota = new Button();
            label3 = new Label();
            costoTotale = new Label();
            btnSalva = new Button();
            btnCarica = new Button();
            costoScontato = new Label();
            label5 = new Label();
            prodottiElettronici = new ComboBox();
            prodottiAlimentari = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // btnAggiungi
            // 
            btnAggiungi.BackColor = Color.Lime;
            btnAggiungi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungi.Location = new Point(659, 204);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(129, 63);
            btnAggiungi.TabIndex = 0;
            btnAggiungi.Text = "AGGIUNGI PRODOTTO";
            btnAggiungi.UseVisualStyleBackColor = false;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnRimuovi
            // 
            btnRimuovi.BackColor = Color.Red;
            btnRimuovi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRimuovi.Location = new Point(209, 204);
            btnRimuovi.Name = "btnRimuovi";
            btnRimuovi.Size = new Size(129, 63);
            btnRimuovi.TabIndex = 1;
            btnRimuovi.Text = "RIMUOVI PRODOTTO";
            btnRimuovi.UseVisualStyleBackColor = false;
            btnRimuovi.Click += btnRimuovi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 44);
            label1.Name = "label1";
            label1.Size = new Size(336, 25);
            label1.TabIndex = 3;
            label1.Text = "NUMERO PRODOTTI NEL CARRELLO:";
            // 
            // numProdotti
            // 
            numProdotti.AutoSize = true;
            numProdotti.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            numProdotti.Location = new Point(542, 40);
            numProdotti.Name = "numProdotti";
            numProdotti.Size = new Size(72, 30);
            numProdotti.TabIndex = 4;
            numProdotti.Text = "label2";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(191, 349);
            listBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nike - felpa - 70", "Adidas - felpa - 60", "Gucci - felpa - 220", "NorthFace - felpa - 55" });
            comboBox1.Location = new Point(394, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBoxProdotti_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(452, 99);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 7;
            label2.Text = "PRODOTTO";
            // 
            // btnSvuota
            // 
            btnSvuota.BackColor = Color.Yellow;
            btnSvuota.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSvuota.Location = new Point(430, 204);
            btnSvuota.Name = "btnSvuota";
            btnSvuota.Size = new Size(129, 63);
            btnSvuota.TabIndex = 8;
            btnSvuota.Text = "SVUOTA CARRELLO";
            btnSvuota.UseVisualStyleBackColor = false;
            btnSvuota.Click += btnSvuota_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 398);
            label3.Name = "label3";
            label3.Size = new Size(252, 21);
            label3.TabIndex = 9;
            label3.Text = "COSTO TOTALE NON SCONTATO:";
            // 
            // costoTotale
            // 
            costoTotale.AutoSize = true;
            costoTotale.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            costoTotale.Location = new Point(251, 391);
            costoTotale.Name = "costoTotale";
            costoTotale.Size = new Size(72, 30);
            costoTotale.TabIndex = 10;
            costoTotale.Text = "label2";
            // 
            // btnSalva
            // 
            btnSalva.BackColor = Color.FromArgb(0, 192, 192);
            btnSalva.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalva.Location = new Point(277, 343);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(183, 36);
            btnSalva.TabIndex = 11;
            btnSalva.Text = "SALVA CARRELLO";
            btnSalva.UseVisualStyleBackColor = false;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnCarica
            // 
            btnCarica.BackColor = Color.FromArgb(0, 192, 192);
            btnCarica.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarica.Location = new Point(523, 343);
            btnCarica.Name = "btnCarica";
            btnCarica.Size = new Size(183, 36);
            btnCarica.TabIndex = 12;
            btnCarica.Text = "CARICA CARRELLO";
            btnCarica.UseVisualStyleBackColor = false;
            btnCarica.Click += btnCarica_Click;
            // 
            // costoScontato
            // 
            costoScontato.AutoSize = true;
            costoScontato.BackColor = Color.FromArgb(0, 192, 0);
            costoScontato.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            costoScontato.Location = new Point(219, 421);
            costoScontato.Name = "costoScontato";
            costoScontato.Size = new Size(72, 30);
            costoScontato.TabIndex = 14;
            costoScontato.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 192, 0);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 426);
            label5.Name = "label5";
            label5.Size = new Size(210, 21);
            label5.TabIndex = 13;
            label5.Text = "COSTO TOTALE SCONTATO:";
            // 
            // prodottiElettronici
            // 
            prodottiElettronici.FormattingEnabled = true;
            prodottiElettronici.Items.AddRange(new object[] { "Panasonic - TV_S65A - 299", "Sony - TV_Bravia - 479", "Samsung - TV_M7 - 379" });
            prodottiElettronici.Location = new Point(394, 123);
            prodottiElettronici.Name = "prodottiElettronici";
            prodottiElettronici.Size = new Size(206, 23);
            prodottiElettronici.TabIndex = 15;
            prodottiElettronici.SelectedIndexChanged += prodottiElettronici_SelectedIndexChanged;
            // 
            // prodottiAlimentari
            // 
            prodottiAlimentari.FormattingEnabled = true;
            prodottiAlimentari.Items.AddRange(new object[] { "Melinda - Mela (al kg) - 1", "Chiquita - Banana (al kg) - 3 ", "Barilla - Pasta - 2" });
            prodottiAlimentari.Location = new Point(394, 123);
            prodottiAlimentari.Name = "prodottiAlimentari";
            prodottiAlimentari.Size = new Size(206, 23);
            prodottiAlimentari.TabIndex = 16;
            prodottiAlimentari.SelectedIndexChanged += prodottiAlimentari_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.FromArgb(0, 0, 192);
            radioButton1.Location = new Point(249, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(131, 21);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Prodotti Generici";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += TipoProdotto;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.FromArgb(0, 0, 192);
            radioButton2.Location = new Point(435, 73);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(144, 21);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Prodotti elettronici";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += TipoProdotto;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.FromArgb(0, 0, 192);
            radioButton3.Location = new Point(642, 74);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(146, 21);
            radioButton3.TabIndex = 19;
            radioButton3.TabStop = true;
            radioButton3.Text = "Prodotti Alimentari";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += TipoProdotto;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(prodottiAlimentari);
            Controls.Add(prodottiElettronici);
            Controls.Add(costoScontato);
            Controls.Add(label5);
            Controls.Add(btnCarica);
            Controls.Add(btnSalva);
            Controls.Add(costoTotale);
            Controls.Add(label3);
            Controls.Add(btnSvuota);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(numProdotti);
            Controls.Add(label1);
            Controls.Add(btnRimuovi);
            Controls.Add(btnAggiungi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAggiungi;
        private Button btnRimuovi;
        private Label label1;
        private Label numProdotti;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Button btnSvuota;
        private Label label3;
        private Label costoTotale;
        private Button btnSalva;
        private Button btnCarica;
        private Label costoScontato;
        private Label label5;
        private ComboBox prodottiElettronici;
        private ComboBox prodottiAlimentari;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}