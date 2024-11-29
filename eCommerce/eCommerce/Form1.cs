namespace eCommerce
{
    public partial class Form1 : Form
    {
        Carrello carrello;
        Prodotto prodotto;
        public Form1()
        {
            InitializeComponent();
            carrello = new Carrello("000001");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaNumProdotti();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            carrello.aggiungiProdotto(prodotto);
            AggiornaGrafica("add");
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int prodottoSelezionato = listBox1.SelectedIndex;

                carrello.rimuoviProdottoVistaInClasse(prodottoSelezionato); 
                AggiornaGrafica("remove"); 
            }

        }

        private void comboBoxProdotti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodottoSelezionato = comboBox1.SelectedItem.ToString();

            string[] parti = prodottoSelezionato.Split(" - ");

                string marca = parti[0].Trim();
                string modello = parti[1].Trim();
                double prezzo = Convert.ToInt16(parti[2].Trim());
                string id = parti[3].Trim();

                prodotto = new Prodotto(marca, modello, id, prezzo);
            //MessageBox.Show(prodotto.Marca + " - " + prodotto.Modello + " - " + prodotto.Identificativo + " - " + prodotto.Prezzo);
        }

        private void AggiornaNumProdotti()
        {
            numProdotti.Text = Convert.ToString(carrello.ProdottiCarrello.Count);
        }
        private void AggiornaGrafica(string operazione)
        {
            AggiornaNumProdotti();
            if (operazione == "add")
                listBox1.Items.Add(prodotto.Marca + "  " + prodotto.Modello + " - " + prodotto.Identificativo + "  €" + prodotto.Prezzo);
            else
                if (operazione == "remove")
                listBox1.Items.Remove(listBox1.SelectedItem);
            else
                return;
        }
    }
}



