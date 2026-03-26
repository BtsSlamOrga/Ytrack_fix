namespace CSharpDiscovery.Quest01
{
    public class ContainsSpecificSubstring_Exercice
    {
        public static bool ContainsSpecificSubstring(string str, string pattern)
        {
            if (str == null || pattern == null)
                return false;
            return str.Contains(pattern);
        }
    }
}