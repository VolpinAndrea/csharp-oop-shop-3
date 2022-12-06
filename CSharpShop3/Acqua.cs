using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    internal class Acqua : Prodotto //<<Attore>
    {
        private double capienza;
        public double pH;
        public string sorgente;

        public Acqua(string nome, string descrizione, double prezzo, double iva, double capienza, double pH, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            SetCapienza(capienza);
            this.pH = pH;
            this.sorgente = sorgente;
        }

        public double GetCapienza()
        {
            return this.capienza;
        }
        public double GetpH()
        {
            return this.pH;
        }
        public string GetSorgente()
        {
            return this.sorgente;
        }
        public void SetSorgente(string newSorgente)
        {
            this.sorgente = newSorgente;
        }
        public void SetCapienza(double newCapienza)
        {
            if (newCapienza >= 0 && newCapienza <= 1.5)
            {
                this.capienza = newCapienza;
            }
            else if (newCapienza > 1.5)
            {
                Console.WriteLine("troppa acqua insrita, settato a 1,5 Litri");
                this.capienza = 1.5;
            }
            else
            {
                Console.WriteLine("numero acqua non valido inserito 0 Litri");
                this.capienza = 0;

            }
        }

        public void Bevi(double quanto)
        {
            if (quanto > capienza)
            {
                Console.WriteLine("--Hai bevuto tutta l'acqua, e hai ancora sete!");
                SetCapienza(0);
            }
            else if (quanto < 0)
            {
                Console.WriteLine("--Hai inserito un numero non valido");
            }
            else
            {
                Console.WriteLine("--Hai bevuto " + quanto + "L ne rimangono " + string.Format("{0:F1}", this.capienza - quanto) + "L");
                this.capienza = capienza - quanto;
            }
        }
        public void Riempi(double quanto)
        {
            if (quanto + capienza > 1.5)
            {
                Console.WriteLine("--Hai messo troppa acqua, la bottiglia è piena ma hai perso: " + (quanto + capienza - 1.5) + "L");
                SetCapienza(1.5);
            }
            else if (quanto < 0)
            {
                Console.WriteLine("--Hai inserito un numero non valido la bottiglia rimane uguale");
            }
            else
            {
                Console.WriteLine("--Hai riempito di " + quanto + "L, la bottiglia ora contiene " + string.Format("{0:F1}", this.capienza + quanto) + "L");
                this.capienza = capienza + quanto;
            }
        }

        public override void StampaTutto()
        {
            base.StampaTutto();
            Console.WriteLine("Capienza:" + string.Format("{0:F1}", (this.capienza)) + "L | Sorgente: " + sorgente + " | pH " + pH);
            Console.WriteLine("-----------------------------------");
        }

        public override string? ToString()
        {
            return base.ToString() + "\nCapienza:" + string.Format("{0:F1}", (this.capienza)) + "L | Sorgente: " + sorgente + " | pH " + pH;
        }
    }
}
