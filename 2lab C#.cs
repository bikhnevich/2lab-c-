using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Kvadrat
    {
        protected int storona;

        public Kvadrat()
        {
            storona = 0;
        }

        public Kvadrat(int st)
        {
            storona = st;
        }

        public int Storona
        {
            get { return storona; }
            set { storona = value; }
        }

        public virtual string Info()
        {
            return string.Format("Kvadrat");
        }

        public virtual int Area()
        {
            return storona * storona;
        }

        public virtual int Perimeter()
        {
            return 4 * storona;
        }

        public virtual double Diagonal()
        {
            return Math.Sqrt(2 * storona * storona);
        }
    };

    class Piramida:Kvadrat
    {
        protected int visota;
        public Piramida()
            : base()
        {
            visota = 0;
        }

        public Piramida(int st, int vst)
            : base(st)
        {
            visota = vst;
        }
        public int Visota
        {
            get { return visota; }
            set { visota = value; }
        }

        public override string Info()
        {
            return string.Format("Piramida");
        }

        public override int Area()
        {
            return base.Area() * storona * storona + 4 * (1/2*storona * visota);
        }
        public override int Perimeter()
        {
            return base.Perimeter() * (3 * storona) * 4 + 4 * storona;
        }
        public override double Diagonal()
        {
            return Math.Sqrt(base.Diagonal() * storona);
        }
        public double Objom()
        {
            return storona * (storona *  storona * storona + 2 * storona * visota) * 1 / 3 * visota;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int storona;
            Console.WriteLine("Введите длину стороны :");
            storona = Convert.ToInt32(Console.ReadLine());
            Kvadrat kv1 = new Kvadrat(storona);

            Console.WriteLine(kv1.Info());
            Console.WriteLine("Area {0}", kv1.Area());
            Console.WriteLine("Perimeter {0}", kv1.Perimeter());
            Console.WriteLine("Diagonal {0}", kv1.Diagonal());
            Console.WriteLine();

            int visota;
            Console.WriteLine("Введите длину высоты :");
            visota = Convert.ToInt32(Console.ReadLine());

            Piramida pr1 = new Piramida(storona, visota);
            Console.WriteLine(pr1.Info());
            Console.WriteLine("Area {0}", pr1.Area());
            Console.WriteLine("Perimeter {0}", pr1.Perimeter());
            Console.WriteLine("Diagonal {0}", pr1.Diagonal());
            Console.WriteLine("Objom {0}", pr1.Objom());

            Console.ReadKey();
        }
    }
}