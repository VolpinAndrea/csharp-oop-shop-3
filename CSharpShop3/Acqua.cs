using CSharpShop3.CustomExeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3
{
    internal class Acqua : Prodotto //<<Attore>
    {
        private double capienza;
        public double pH;
        public string sorgente;
        const double galloni = 3.785;

        public Acqua(string nome, string descrizione, double prezzo, double iva, double capienza, double pH, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            SetCapienza(capienza);
            //this.pH = pH;
            SetpH(pH);
            this.sorgente = sorgente;
        }
        // GET

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

        // SET

        public void SetpH(double newpH)
        {
            if (newpH < 0 || newpH > 10)
            {
                throw new ArgumentOutOfRangeException("ph non valido");
            }
            else
            {
                this.pH = newpH;
            }
        }

        public void SetSorgente(string newSorgente)
        {
            this.sorgente = newSorgente;
        }
        public void SetCapienza(double newCapienza)
        {
            if (newCapienza < 0 || newCapienza > 2)
            {
                throw new ArgumentOutOfRangeException("capienza noin valida");
            }
            else
            {
                this.capienza = newCapienza;
            }
            
        }

        public void Bevi(double quanto)
        {
            
            if(quanto < 0)
            {
                throw new ArgumentOutOfRangeException("Non puoi bere in negativo. Non succede nulla");
            }
            else if (quanto > this.capienza)
            {
                SetCapienza(0);
                throw new BeviTroppoException("hai bevuto troppo!. Hai ancora sete");
            }
            else
            {
                Console.WriteLine("Hai bevuto " + quanto + "L ne rimangono " + string.Format("{0:F1}", this.capienza - quanto) + "L");
                this.capienza = capienza - quanto;   
            }
            
        }
        public void Riempi(double quanto)
        {
            if (quanto < 0)
            {
                throw new ArgumentOutOfRangeException("Non puoi riempire in negativo. Non succede nulla");
            }
            else if (quanto + capienza > 2)
            {
                double dato = quanto + capienza - 2;
                SetCapienza(2);
                throw new RiempiTroppoException("Hai messo troppa acqua, la bottiglia è piena ma hai perso: " + dato + "L");
            }
            else
            {
                Console.WriteLine("--Hai riempito di " + quanto + "L, la bottiglia ora contiene " + string.Format("{0:F1}", this.capienza + quanto) + "L");
                this.capienza = capienza + quanto;
            }
        }
        //public static double ConvertiInGalloni(double litri)
        //{
        //    return litri*3.785;
        //}
        public static double ConvertiInGalloni(double litri)
        {
            return litri * galloni;
        }

        public override string? ToString()
        {
            return base.ToString() + "\nCapienza:" + string.Format("{0:F1}", (this.capienza)) + "L | Sorgente: " + sorgente + " | pH " + pH;
        }
    }
}
