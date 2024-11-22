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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            prodottiToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            numProdotti = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAggiungi
            // 
            btnAggiungi.BackColor = Color.Lime;
            btnAggiungi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungi.Location = new Point(469, 240);
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
            btnRimuovi.Location = new Point(187, 240);
            btnRimuovi.Name = "btnRimuovi";
            btnRimuovi.Size = new Size(129, 63);
            btnRimuovi.TabIndex = 1;
            btnRimuovi.Text = "RIMUOVI PRODOTTO";
            btnRimuovi.UseVisualStyleBackColor = false;
            btnRimuovi.Click += btnRimuovi_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, prodottiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // prodottiToolStripMenuItem
            // 
            prodottiToolStripMenuItem.Name = "prodottiToolStripMenuItem";
            prodottiToolStripMenuItem.Size = new Size(62, 20);
            prodottiToolStripMenuItem.Text = "Prodotti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(218, 174);
            label1.Name = "label1";
            label1.Size = new Size(336, 25);
            label1.TabIndex = 3;
            label1.Text = "NUMERO PRODOTTI NEL CARRELLO:";
            // 
            // numProdotti
            // 
            numProdotti.AutoSize = true;
            numProdotti.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            numProdotti.Location = new Point(560, 170);
            numProdotti.Name = "numProdotti";
            numProdotti.Size = new Size(72, 30);
            numProdotti.TabIndex = 4;
            numProdotti.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numProdotti);
            Controls.Add(label1);
            Controls.Add(btnRimuovi);
            Controls.Add(btnAggiungi);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAggiungi;
        private Button btnRimuovi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem prodottiToolStripMenuItem;
        private Label label1;
        private Label numProdotti;
    }
}