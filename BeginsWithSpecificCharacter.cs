namespace CSharpDiscovery.Quest01
{
    public class BeginsWithSpecificCharacter_Exercice
    {
        public static bool BeginsWithSpecificCharacter(string str, char begin)
        {
            if (str == null)
                return false;
            return str[0] == begin;
        }
    }
}