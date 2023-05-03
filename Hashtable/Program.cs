using System;
using System.Collections;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //HASHTABLE collection con chiave valore, non fisse
            Hashtable prova = new Hashtable();
            Hashtable prova2 = new Hashtable()
            {
                {"Lombardia", "milano"},
                {"Piemonte", "torino" },
                {"Puglia", "bari" }
            };

            prova2.Add("Veneto", "venezia");
            Console.WriteLine(prova2["Lombardia"]);

            //MODIFICARE
            prova2["Lombardia"] = "mantova";

            //ELIMINAZIONE
            prova2.Remove("Lombardia");

            //CICLI
            foreach(DictionaryEntry citta in prova2)
            {
                Console.WriteLine(citta.Key);
                Console.WriteLine(citta.Value);
            }
        }
    }
}