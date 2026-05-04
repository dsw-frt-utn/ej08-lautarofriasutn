using System.Text.RegularExpressions;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null) return "SIN-CODIGO";

            string procesado = code.Trim().ToUpper();

            return Regex.Replace(procesado, @"\s+", "-"); 
        }
    }
}