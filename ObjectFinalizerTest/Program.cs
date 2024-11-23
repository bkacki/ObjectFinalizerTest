namespace ObjectFinalizerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var evilClones = new List<EvilClone>();

            while (true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'a':
                        evilClones.Add(new EvilClone());
                        break;
                    case 'c':
                        Console.WriteLine("Opróżnienie listy, czas: {0}", stopwatch.ElapsedMilliseconds);
                        evilClones.Clear();
                        break;
                    case 'g':
                        Console.WriteLine("Odzyskanie pamięci, czas: {0}", stopwatch.ElapsedMilliseconds);
                        GC.Collect();
                        break;
                }
            }
        }
    }
}
