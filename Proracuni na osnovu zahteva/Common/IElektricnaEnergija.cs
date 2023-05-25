using Proracuni_na_osnovu_zahteva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Common
{
    [ServiceContract]
    public interface IElektricnaEnergija
    {
        [OperationContract]
        Load getEnergija(int min,int max=0,int stand=0);
    }
}
