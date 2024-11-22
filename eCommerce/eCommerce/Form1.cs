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
            aggiornaNumProdotti();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Prodotto prodotto = new Prodotto("EA", "FC25", "000001", 35);
            carrello.aggiungiProdotto(prodotto);
            aggiornaNumProdotti();
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {

            aggiornaNumProdotti();
        }

        private void aggiornaNumProdotti()
        {
            numProdotti.Text = Convert.ToString(carrello.ProdottiCarrello.Count);

        }
    }
}