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
            SuspendLayout();
            // 
            // btnAggiungi
            // 
            btnAggiungi.BackColor = Color.Lime;
            btnAggiungi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungi.Location = new Point(659, 230);
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
            btnRimuovi.Location = new Point(209, 230);
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
            comboBox1.Items.AddRange(new object[] { "Panasonic - TV_S65A - 299", "Sony - TV_Bravia - 479", "Samsung - TV_M7 - 379", "Nike - felpa - 70", "Adidas - felpa - 60", "Gucci - felpa - 220", "NorthFace - felpa - 55" });
            comboBox1.Location = new Point(394, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBoxProdotti_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(452, 125);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 7;
            label2.Text = "PRODOTTO";
            // 
            // btnSvuota
            // 
            btnSvuota.BackColor = Color.Yellow;
            btnSvuota.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSvuota.Location = new Point(430, 230);
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
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 416);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 9;
            label3.Text = "COSTO TOTALE:";
            // 
            // costoTotale
            // 
            costoTotale.AutoSize = true;
            costoTotale.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            costoTotale.Location = new Point(157, 411);
            costoTotale.Name = "costoTotale";
            costoTotale.Size = new Size(72, 30);
            costoTotale.TabIndex = 10;
            costoTotale.Text = "label2";
            // 
            // btnSalva
            // 
            btnSalva.BackColor = Color.FromArgb(0, 192, 192);
            btnSalva.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalva.Location = new Point(278, 383);
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
            btnCarica.Location = new Point(524, 383);
            btnCarica.Name = "btnCarica";
            btnCarica.Size = new Size(183, 36);
            btnCarica.TabIndex = 12;
            btnCarica.Text = "CARICA CARRELLO";
            btnCarica.UseVisualStyleBackColor = false;
            btnCarica.Click += btnCarica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}