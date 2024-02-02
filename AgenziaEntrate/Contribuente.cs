using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaEntrate
{
    internal class Contribuente
    {
        // Proprietà della classe
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public char Sesso { get; set; }
        public string ComuneDiResidenza { get; set; }
        public decimal RedditoAnnuale { get; set; }

        //Costruttore della classe
        public Contribuente(string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, char sesso, string comuneDiResidenza, decimal redditoAnnuale)
        {
            // Inizializzazione delle proprietà con i valori passati al costruttore
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneDiResidenza = comuneDiResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        // metodo per calcolare l'imposta da versare
        public decimal CalcolaImposta()
        {
            // variabile che memorizza l'imposta
            decimal imposta = 0;
            
            // Calcolo dell'imposta in base al reddito inserito
            if(RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23m;
            }
            else if(RedditoAnnuale <= 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;
            }
            else if(RedditoAnnuale <= 55000)
            {
                imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;
            }
            else if(RedditoAnnuale <= 75000)
            {
                imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;
            }
            else
            {
                imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m;
            }
            // Restituisce l'imposta calcolata
            return imposta;
        }
    }
}
