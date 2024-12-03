using System.Text.Json;

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
            AggiornaCostoTotale();
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
                int indiceProdottoSelezionato = listBox1.SelectedIndex;

                Prodotto prodottoSelezionato = carrello.ProdottiCarrello[indiceProdottoSelezionato];
                carrello.rimuoviProdotto(prodottoSelezionato);

                AggiornaGrafica("remove");
            }

        }
        private void btnSvuota_Click(object sender, EventArgs e)
        {
            carrello.svuotaCarrello();
            AggiornaGrafica("removeAll");
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string filePath = "carrello.json";
            string jsonString = JsonSerializer.Serialize(carrello.ProdottiCarrello);//prendo la lista dei prodotti e la trasformo in una stringa formattata in JSON
            File.WriteAllText(filePath, jsonString);//scrivo la stringa JSON nel file specificato
            MessageBox.Show("Carrello salvato con successo!");
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            string filePath = "carrello.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath); //leggo il contenuto del file e lo memorizzo in una stringa
                List<Prodotto> prodotti = JsonSerializer.Deserialize<List<Prodotto>>(jsonString);//prendo la stringa JSON e la converto di nuovo in una lista di oggetti Prodotto
                carrello.ProdottiCarrello = prodotti;
                foreach (Prodotto prodotto in carrello.ProdottiCarrello) 
                { 
                    carrello.CostoTotale += prodotto.Prezzo; 
                }
                AggiornaGrafica("carica");
                MessageBox.Show("Carrello caricato con successo!");
            }
            else
            {
                MessageBox.Show("File non trovato.");
            }
        }


        private void comboBoxProdotti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodottoSelezionato = comboBox1.SelectedItem.ToString();

            string[] parti = prodottoSelezionato.Split(" - ");

            string marca = parti[0].Trim(); //ho usato trim per rimuovere eventuali spazi bianchi prima e dopo
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

        private void AggiornaCostoTotale()
        {
            costoTotale.Text = "€" + Convert.ToString(carrello.CostoTotale);
        }
        private void AggiornaGrafica(string operazione)
        {
            AggiornaNumProdotti();
            AggiornaCostoTotale();
            if (operazione == "add")
            {
                listBox1.Items.Add(prodotto.Marca + "  " + prodotto.Modello + " - " + prodotto.Identificativo + "  €" + prodotto.Prezzo);
            }
            else if (operazione == "remove")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else if (operazione == "removeAll")
            {
                listBox1.Items.Clear();
            }
            else if (operazione == "carica")
            {
                listBox1.Items.Clear();
                foreach (var prodotto in carrello.ProdottiCarrello)
                {
                    listBox1.Items.Add(prodotto.Marca + "  " + prodotto.Modello + " - " + prodotto.Identificativo + "  €" + prodotto.Prezzo);
                }
            }
            else
            {
                return;
            }
        }



    }
}



