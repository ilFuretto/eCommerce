using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class Carrello
    {
        private string identificativo;

        private List<Prodotto> prodottiCarrello;

        public List<Prodotto> ProdottiCarrello
        {
            get { return prodottiCarrello; }
            set { prodottiCarrello = value; }
        }
        public string Identificativo
        {
            get { return identificativo; }
        }

        private double costoTotale;
        public double CostoTotale
        {
            get { return costoTotale; }
            set { costoTotale = value; }
        }

        public void aggiungiProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            prodottiCarrello.Add(prodotto);
            CostoTotale += prodotto.Prezzo;
        }
        public void rimuoviProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            prodottiCarrello.Remove(prodotto);
            CostoTotale -= prodotto.Prezzo;
        }
        public void rimuoviProdottoVistaInClasse(int indice)
        {
            if (indice == null)
                return;
            if (indice > -1)
                prodottiCarrello.RemoveAt(indice);
        }
        public void svuotaCarrello()
        {
            prodottiCarrello.Clear();
            CostoTotale = 0.0;
        }

        public Carrello(string identificativo)
        {
            this.identificativo = identificativo;
            prodottiCarrello = new List<Prodotto>();
            costoTotale = 0.0;
        }
    }
}
