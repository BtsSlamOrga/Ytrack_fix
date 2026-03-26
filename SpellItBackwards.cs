namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            char[] chars = str.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars);
        }
    }
}