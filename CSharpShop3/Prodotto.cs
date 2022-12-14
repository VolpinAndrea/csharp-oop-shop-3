using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;
        public static int numero = 0;

        Random RandomClass = new Random();
        public Prodotto()
        {
            this.codice = RandomClass.Next(1, 10000);
            conta();
        }

        public Prodotto(string nome, string descrizione, double prezzo, double iva) : this()
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string newNome)
        {
            this.nome = newNome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }
        public void SetDescrizione(string newDescrizione)
        {
            this.descrizione = newDescrizione;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }
        public void SetPrezzo(double newPrezzo)
        {
            this.prezzo = newPrezzo;
        }
        public double GetIva()
        {
            return this.iva;
        }
        public int GetNumero()
        {
            return numero;
        }
        public void SetIva(double newIva)
        {
            this.iva = newIva;
        }

        public double prezzoIva()
        {
            return this.prezzo + this.iva;
        }
        public string nomeEsteso()
        {
            return this.codice + this.nome;
        }
        public static void conta() => numero++;

        public override string? ToString()
        {
            return "Codice: " + this.codice + "\nNome: " + this.nome + "\nDescrizione: " + descrizione + "\nPrezzo: " + this.prezzo + "\nIVA: " + this.iva + "\nPrezo con IVA : " + string.Format("{0:F2}", prezzoIva()) + "\nNome esteso: " + nomeEsteso();
        }
    }
}
