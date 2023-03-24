namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dersler = new string[]
            {
                "C#",
                "Java",
                "Python",
                "javascript"
            };

            for (int i = 0; i < dersler.Length; i++)
            {
                Console.WriteLine(dersler[i]);
            }
        }
    }
}