namespace GerenciamentoMateriaPrima.Helpers.Extensions
{
    public static class ExtensionStrings
    {

        public static double ConverterParaDouble(this string valor)
        {
            try
            {
                return Convert.ToDouble(valor);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
