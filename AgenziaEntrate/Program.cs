using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaEntrate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i dati del contribuente: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Data di nascita (formato gg/mm/aaaa): ");
            DateTime dataNascita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null); // quì convertiamo la stringa di una data in un oggetto DateTime

            Console.Write("Codice fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.WriteLine("Sesso (M/F): ");
            char sesso = Console.ReadLine().ToUpper()[0]; // toUpper ci assicura che il carattere inserito sia convertito in maiuscolo

            Console.Write("Comune di residenza: ");
            string comuneResidenza = Console.ReadLine();

            Console.Write("Reddito Annuale: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine()); // convertiamo la stringa ottenuta in un tipo decimal

            // creazione dell'oggetto Contribuente
            Contribuente contribuente1 = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

             // calcolo dell'imposta da versare
            decimal impostaDaVersare = contribuente1.CalcolaImposta();

            Console.WriteLine("\nRISULTATO RIEPILOGATIVO:");
            Console.WriteLine($"Contribuente: {contribuente1.Nome} {contribuente1.Cognome},");
            Console.WriteLine($"nato il {contribuente1.DataDiNascita.ToString("dd/MM/yyyy")} ({contribuente1.Sesso}),");
            Console.WriteLine($"residente in {contribuente1.ComuneDiResidenza},");
            Console.WriteLine($"codice fiscale: {contribuente1.CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: $ {contribuente1.RedditoAnnuale} ");
            Console.WriteLine($"IMPOSTA DA VERSARE: $ {impostaDaVersare} ");


            Console.ReadLine();
        }
    }
}
