namespace eCommerce
{
    public partial class Form1 : Form
    {
        Carrello carrello;
        public Form1()
        {
            InitializeComponent();
            carrello = new Carrello("000001");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaGrafica();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            //Prodotto prodotto = new Prodotto("EA", "FC25", "000001", 35);
            //carrello.aggiungiProdotto(prodotto);
            AggiornaGrafica();
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {

            AggiornaGrafica();

        }

        private void AggiornaNumProdotti()
        {
            numProdotti.Text = Convert.ToString(carrello.ProdottiCarrello.Count);
        }
        private void AggiornaGrafica()
        {
            AggiornaNumProdotti();
        }
    }
}



/*private void comboBoxProdotti_SelectedIndexChanged(object sender, EventArgs e)
{
    // Ottieni l'elemento selezionato
    string prodottoSelezionato = comboBoxProdotti.SelectedItem.ToString();

    // Esegui lo split della stringa per separare marca e identificativo
    string[] parti = prodottoSelezionato.Split('-');

    // Ottieni la marca e l'identificativo (assicurati che l'array abbia almeno 2 elementi)
    if (parti.Length == 2)
    {
        string marca = parti[0].Trim(); // Rimuove eventuali spazi extra
        string id = parti[1].Trim();    // Rimuove eventuali spazi extra

        // Crea un oggetto Prodotto con la marca e l'id
        Prodotto prodotto = new Prodotto(marca, id);

        // Mostra una message box o fai altre operazioni con l'oggetto Prodotto
        MessageBox.Show($"Prodotto selezionato: {prodotto.Marca} - {prodotto.Id}");

        // Aggiungi il prodotto al carrello o fai altre operazioni
        carrello.aggiungiProdotto(prodotto);
    }
    else
    {
        // Gestisci l'errore, ad esempio se la stringa non è nel formato corretto
        MessageBox.Show("Formato prodotto non valido.");
    }
}
*/