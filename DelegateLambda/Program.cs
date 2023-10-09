namespace DelegateLambda
{
    internal class Program
    {
        delegate void MyDelegate1(int a, int b);
        delegate int MyDelegate2(int a);
        static void Main(string[] args)
        {
            //Khi chua su dung delegate
            Console.WriteLine("Not use delegate");
            Tong(4, 6);
            UCLN(4, 6);
            SoSanh(4, 6);

            Tong(4, 6);
            UCLN(4, 6);
            SoSanh(4, 6);
            //Khi su dung delegate
            Console.WriteLine("Use delegate");
            //Cach 1 tao delegate
            MyDelegate1 md1 = new MyDelegate1(Tong);
            md1(4, 6);
            md1 += UCLN;
            md1 += SoSanh;
            md1 -= SoSanh;
            //Cach 2 ta delegate
            MyDelegate2 md2 = delegate (int a)
            {
                return a * a;
            };
            //Bien hinh
            MyDelegate2 md3 = a => a * a;
        }

        public static void Tong(int a, int b) => Console.WriteLine($"a + b = {a+b}");
        

        public static void UCLN(int m, int n)
        {
            while(m != n)
            {
                if (m > n) m = m - n;
                else n = n - m;
            }
            Console.WriteLine($"UCLN = {m}");
        }

        public static void SoSanh(int m, int n)
        {
            if (m == n) Console.WriteLine("m = n");
            if (m < n) Console.WriteLine("m < n");
            else Console.WriteLine("m > n");
        }

        public static int BinhPhuong(int a) => a * a;
    }
}