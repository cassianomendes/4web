using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.ExternalServices.Correios
{
    public class CorreiosService
    {
        private const string WEB_SERVICE = "http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx";

        public CorreiosResult CalculatePriceAndDeadline(
            string sourcePostalCode, 
            string destination, 
            decimal weightInKg,
            decimal length,
            decimal height,
            decimal width,
            decimal diameter,
            CorreiosServiceType serviceType = CorreiosServiceType.PAC_Varejo)
        {
            // sCdMaoPropria = "N"
            // nVlValorDeclarado = 0.00
            // sCdAvisoRecebimento = "N"

            return new CorreiosResult();
        }
    }
}
