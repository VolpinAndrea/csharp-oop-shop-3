// See https://aka.ms/new-console-template for more information
using CSharpShop3;


Acqua uno = CreaBottiglia();
Console.WriteLine(uno.ToString());

Console.WriteLine("Quanto vuoi bere?");
double sete = double.Parse(Console.ReadLine());
uno.Bevi(sete);

Console.WriteLine("Di quanto vuoi riempire?");
double aggiungi = double.Parse(Console.ReadLine());
uno.Riempi(aggiungi);
Console.WriteLine("Al momento ci sono: " + Acqua.ConvertiInGalloni(uno.GetCapienza()) + " Galloni");
Console.WriteLine();



// Conrtolli solo su questi 2 dati: pH e Capienza. Gli altri inseriti manualmente
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

            return bottle;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Reinserire i dati della bottiglia");
        }
       // return null;

    }
}
// NON CAPISCO L'ERORRE
/*static Acqua? CreaBottigliaNoWhileTrue()
{
    Acqua bottle = null;
    while (bottle != null) 
    {
        try
        {
            Console.WriteLine("Inserisci la capienza della bottiglia");
            double capienzaUtente = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il pH dell'acqua");
            double phUtente = double.Parse(Console.ReadLine());

            bottle = new("H2o", "Frizzante", 2.00, 0.3, capienzaUtente, phUtente, "Monte");

            return bottle;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Reinserire i dati della bottiglia");
        }
        return bottle;

    }
}*/


