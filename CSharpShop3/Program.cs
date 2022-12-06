// See https://aka.ms/new-console-template for more information
using CSharpShop3;


Acqua uno = CreaBottiglia();

static Acqua? CreaBottiglia()
{
    //bool controllo = true;
    while (true) // controllo
    {
        try
        {
            Console.WriteLine("Inserisci la capienza della bottiglia");
            double capienzaUtente = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il pH dell'acqua");
            double phUtente = double.Parse(Console.ReadLine());

            Acqua bottle = new("H2o", "Frizzante", 2.00, 0.3, capienzaUtente, phUtente, "Monte");
            //controllo = false;
            Console.WriteLine(bottle.ToString());

            return bottle;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Reinserisci il pH tra 0 e 10");
        }
        //return null;

    }
}

 