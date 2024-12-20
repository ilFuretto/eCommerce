using System.Text.Json;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce
{
    public partial class Form1 : Form
    {
        private SoundPlayer audioCassa;
        private Carrello carrello;
        private Prodotto prodotto;
        private int idInt;
        private string id;
        public Form1()
        {
            InitializeComponent();
            carrello = new Carrello("000001");
            audioCassa = new SoundPlayer(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audio", "audio_cassa.wav"));
            idInt = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaNumProdotti();
            AggiornaCostoTotale();
            prodottiElettronici.Visible = false;
            prodottiAlimentari.Visible = false;


        }

        private void TipoProdotto(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Visible = true;
                prodottiElettronici.Visible = false;
                prodottiAlimentari.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                comboBox1.Visible = false;
                prodottiElettronici.Visible = true;
                prodottiAlimentari.Visible = false;
            }
            else if (radioButton3.Checked)
            {
                comboBox1.Visible = false;
                prodottiElettronici.Visible = false;
                prodottiAlimentari.Visible = true;
            }

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null && prodottiAlimentari.SelectedItem == null && prodottiElettronici == null)
                return;
            foreach (Prodotto prod in carrello.ProdottiCarrello)
            {
                if (prodotto == prod)
                {
                    MessageBox.Show("PRODOTTO GIA' INSERITO!", "ERRORE");
                    return;
                }
            }

            id = idInt.ToString("D6");
            MessageBox.Show(id);
            carrello.aggiungiProdotto(prodotto);
            AggiornaGrafica("add");
            audioCassa.Play();
            idInt++;
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
                idInt = carrello.ProdottiCarrello.Count + 1;
                carrello.CostoTotale = 0.0;
                carrello.CostoScontato = 0.0;
                foreach (Prodotto prodotto in carrello.ProdottiCarrello)
                {
                    //MessageBox.Show(prodotto.Identificativo.ToString());
                    carrello.CostoTotale += prodotto.Prezzo; 
                    carrello.CostoScontato += prodotto.PrezzoEffettivo;
                }
                AggiornaGrafica("carica");
                audioCassa.Play();
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
            double prezzo = Convert.ToDouble(parti[2].Trim());

            prodotto = new Prodotto(marca, modello, id, prezzo);
            //MessageBox.Show(prodotto.Marca + " - " + prodotto.Modello + " - " + prodotto.Identificativo + " - " + prodotto.Prezzo);
        }
        private void prodottiAlimentari_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodottoSelezionato = prodottiAlimentari.SelectedItem.ToString();


            string[] parti = prodottoSelezionato.Split(" - ");

            string marca = parti[0].Trim();
            string modello = parti[1].Trim();
            double prezzo = Convert.ToInt16(parti[2].Trim());

            prodotto = new ProdottoAlimentare(marca, modello, id, prezzo);
        }

        private void prodottiElettronici_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodottoSelezionato = prodottiElettronici.SelectedItem.ToString();

            string[] parti = prodottoSelezionato.Split(" - ");

            string marca = parti[0].Trim();
            string modello = parti[1].Trim();
            double prezzo = Convert.ToInt16(parti[2].Trim());

            prodotto = new ProdottoElettronico(marca, modello, id, prezzo);
        }
        private void AggiornaNumProdotti()
        {
            numProdotti.Text = Convert.ToString(carrello.ProdottiCarrello.Count);
        }

        private void AggiornaCostoTotale()
        {
            costoTotale.Text = "�" + Convert.ToString(carrello.CostoTotale);
            costoScontato.Text = "�" + Convert.ToString(carrello.CostoScontato);
        }
        private void AggiornaGrafica(string operazione)
        {
            AggiornaNumProdotti();
            AggiornaCostoTotale();
            if (operazione == "add")
            {
                listBox1.Items.Add(prodotto.Modello + "  " + prodotto.Marca + " - �" + prodotto.Prezzo);
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
                    listBox1.Items.Add(prodotto.Modello + "  " + prodotto.Marca + " - �" + prodotto.Prezzo);
                }
            }
            else
            {
                return;
            }
        }

        
    }
}



