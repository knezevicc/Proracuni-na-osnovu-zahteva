using Proracuni_na_osnovu_zahteva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Client
{
    public class Program
    {
        //za sad sve sto je ovde implementirano:
        //mehanizam koji periodicno proverava
        //da li postoje novi podaci i salje ih klijentskoj aplikaciji
        //+delegati


        private static Timer dataUpdateTimer;
        static void Main(string[] args)
        {
            //timer
            dataUpdateTimer = new Timer();
            dataUpdateTimer.Interval = 5000; // Interval u milisekundama (ovde je postavljen na 5 sekundi)
            dataUpdateTimer.Elapsed += DataUpdateTimerElapsed;
            dataUpdateTimer.Start();

            //delegati
            //servis za računanje ne postoji nigde
                // ServisZaRacunanje calculationService = new ServisZaRacunanje();
                //calculationService.MinimumConsumptionCalculated += MinimumConsumptionCalculatedHandler;
                //calculationService.MaximumConsumptionCalculated += MaximumConsumptionCalculatedHandler;
            Console.WriteLine("server je pokrenut");
            Console.ReadKey();
        }

        private static void DataUpdateTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Metoda koja se izvršava na svakom intervalu tajmera
            // Implementirajte kod za proveru novih podataka i slanje servisu
        }

        //ove dve metode vezame su za delegate
        private static void MinimumConsumptionCalculatedHandler(Load[] loads)
        {
            // Implementirajte logiku za obradu događaja proračuna minimalne potrošnje
        }

        private static void MaximumConsumptionCalculatedHandler(Load[] loads)
        {
            // Implementirajte logiku za obradu događaja proračuna maksimalne potrošnje
        }
    }
}
