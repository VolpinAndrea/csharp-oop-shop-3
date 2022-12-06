using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    internal class SacchettoFrutta : Prodotto
    {
        public string marca;
        private List<string> frutti;



        public SacchettoFrutta(string nome, string descrizione, double prezzo, double iva, string marca, List<string> frutti) : base(nome, descrizione, prezzo, iva)
        {
            this.marca = marca;
            this.frutti = frutti;
        }
        public string GetMarca()
        {
            return marca;
        }
        public void AggiungiFrutto(string newFrutto)
        {
            if (frutti.Count >= 5)
            {
                Console.WriteLine("--Il sacchetto è pieno");
            }
            else
            {
                Console.WriteLine("--Hai aggiunto " + newFrutto + " al sacchetto");
                frutti.Add(newFrutto);
            }
        }
        public void MangiaPrimo()
        {
            if (frutti.Count <= 0)
            {
                Console.WriteLine("--Il sacchetto è vuoto! Non hai mangiato nulla");
            }
            else
            {
                frutti.RemoveAt(0);
                Console.WriteLine("--Hai mangito il primo elemento del sacchetto");
            }
        }
        //public override void StampaTutto()
        //{
        //    base.StampaTutto();
        //    Console.WriteLine("Marca: " + marca);
        //    Console.Write("Contiene: ");
        //    StampaFruttiLista();
        //}
        private void StampaFruttiLista()
        {
            foreach (string frutto in this.frutti)
            {
                Console.Write(frutto + " ");
            }
        }
    }
}
