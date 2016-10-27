using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FourWeb.ExternalServices.Correios
{
    /// <summary>
    /// Implementação do Web Service dos Correios baseada na especificação.
    /// <seealso cref="https://www.correios.com.br/para-sua-empresa/servicos-para-o-seu-contrato/precos-e-prazos"/>
    /// </summary>
    public class CorreiosService
    {
        private const string BASE_ADDRESS = "http://ws.correios.com.br/calculador/";

        public async Task<CorreiosResult> CalculatePriceAndDeadlineAsync(
            string sourcePostalCode,
            string destPostalCode,
            double weightInKg,
            double length,
            double height,
            double width,
            double diameter,
            CorreiosServiceType serviceType = CorreiosServiceType.PAC_Varejo)
        {
            // Valores fixos utilizados para qualquer requisição
            var nCdFormato = CorreiosFormatType.Caixa_Pacote;
            var sCdMaoPropria = "N";
            var nVlValorDeclarado = 0.00;
            var sCdAvisoRecebimento = "N";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BASE_ADDRESS);
                var requestUri = $"CalcPrecoPrazo.asmx/CalcPrecoPrazo?nCdEmpresa=&sDsSenha=&nCdServico={(int)serviceType}&sCepOrigem={sourcePostalCode}&sCepDestino={destPostalCode}&nVlPeso={weightInKg}&nCdFormato={(int)nCdFormato}&nVlComprimento={length}&nVlAltura={height}&nVlLargura={width}&nVlDiametro={diameter}&sCdMaoPropria={sCdMaoPropria}&nVlValorDeclarado={nVlValorDeclarado}&sCdAvisoRecebimento={sCdAvisoRecebimento}";
                var response = await client.GetAsync(requestUri);
            }

            return new CorreiosResult();
        }
    }
}
