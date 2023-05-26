using Common;
using Proracuni_na_osnovu_zahteva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServisZaRacunanje
    {
        public event IzracunajDelegat MinimumConsumptionCalculated;
        public event IzracunajDelegat MaximumConsumptionCalculated;

        public float CalculateMinimumConsumption(Load[] loads)
        {
            float minimum = float.MaxValue;
            foreach (var load in loads)
            {
                if (load.MeasuredValue1 < minimum)
                    minimum = load.MeasuredValue1;
            }

            // Podignite događaj MinimumConsumptionCalculated
            if (MinimumConsumptionCalculated != null)
                MinimumConsumptionCalculated(loads);

            return minimum;
        }
        public float CalculateMaximumConsumption(Load[] loads)
        {
            float maximum = float.MinValue;
            foreach (var load in loads)
            {
                if (load.MeasuredValue1 > maximum)
                    maximum = load.MeasuredValue1;
            }

            // Podignite događaj MaximumConsumptionCalculated
            if (MaximumConsumptionCalculated != null)
                MaximumConsumptionCalculated(loads);

            return maximum;
        }
    }
}
