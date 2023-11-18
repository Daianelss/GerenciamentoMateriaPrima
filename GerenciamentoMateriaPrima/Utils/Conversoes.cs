using System.Globalization;

namespace GerenciamentoMateriaPrima.Utils
{
    public static class Conversoes
    {
        public static DateTime ConverterTextoParaData(string data, string padrao)
        {

            try
            {
                return DateTime.ParseExact(data, padrao, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }
    }
}
