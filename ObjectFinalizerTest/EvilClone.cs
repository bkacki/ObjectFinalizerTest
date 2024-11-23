using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFinalizerTest
{
    public class EvilClone
    {
        public static int CloneCount = 0;
        public int CloneID { get; } = ++CloneCount;

        public EvilClone() => Console.WriteLine("Klon nr {0} sieje zniszczenie.", CloneID);

        //finalizer
        ~EvilClone() => Console.WriteLine("Klon nr {0} został usunięty.", CloneID);
    }
}
