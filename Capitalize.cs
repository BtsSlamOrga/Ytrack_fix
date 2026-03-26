namespace CSharpDiscovery.Quest01
{
    public class Capitalize_Exercice
    {
        public static string Capitalize(string str)
        {
            if (str == null)
                return "";
            return str.ToUpper();
        }
    }
}