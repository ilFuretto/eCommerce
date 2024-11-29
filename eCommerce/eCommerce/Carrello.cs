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
        }
        public string Identificativo
        {
            get { return identificativo; }
        }
        public void aggiungiProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            prodottiCarrello.Add(prodotto);
        }
        public void rimuoviProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            prodottiCarrello.Remove(prodotto);
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
        }

        public Carrello(string identificativo)
        {
            this.identificativo = identificativo;
            prodottiCarrello = new List<Prodotto>();
        }
    }
}
