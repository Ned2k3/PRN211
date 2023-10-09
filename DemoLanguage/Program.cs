// See https://aka.ms/new-console-template for more information

//C# giong voi Java
//Kieu du lieu, khai bao bien, if, for, while, tao ham
using System.Security.Claims;

while (true)
{
    Console.WriteLine("1.Basic");
    Console.WriteLine("2.Array");
    Console.WriteLine("3.String");
    Console.WriteLine("4.List");
    Console.WriteLine("0.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 0: return;
        case 1:
            {
                DemoBasic();
                break; 
            }
        case 2:
            {
                DemoArray();
                break;
            }
        case 3:
            {
                DemoString();
                break;
            }
        case 4:
            {
                DemoList();
                break;
            }
    }
}

void DemoBasic()
{
    int n;
    //1.Nhap 1 so nguyen tu ban phim neu sai nhap lai
    do
    {
        try
        {
            Console.WriteLine("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid");
        }
    }
    while (true);
    //2. n co phai so nguyen to hay khong?
    if (isPrime(n))
    {
        Console.WriteLine("n is prime");
    }
    else
    {
        Console.WriteLine("n is not prime");
    }
    //3. Hien thi n hop so daua tien
    hienThiHopSo(n);
}

bool isPrime(int n)
{
    if (n < 2)
    {
        return false;
    }
    // check so nguyen to khi n >= 2
    int squareRoot = (int)Math.Sqrt(n);
    for (int i = 2; i <= squareRoot; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
void hienThiHopSo(int n)
{
    int count = 0;
    Console.Write($"{n} hop so dau tien: ");
    for(int i = 4; i >= 4; i++)
    {
        if (!isPrime(i))
        {
            Console.Write(i + " ");
            count++;
        }
        if (count == n)
        {
            Console.WriteLine();
            break;
        }
    }
}

void DemoArray()
{
    int[] a = { 3, 4, 5, 7, 12, 14, 13, 23, 15, 21 };
    //1. Co bao nhieu phan tu tan cung la so 3 trong bang
    int count = 0;
    foreach(int i in a)
    {
        if (i % 10 == 3) count++;
    }
    Console.WriteLine($"Co {count} phan tu tan cung la so 3 trong mang");
    //2. Tim min trong so cac phan tu la hop so le
    int min = 0;
    foreach(int i in a)
    {
        if(!isPrime(i) && (i % 2 != 0))
        {
            if (min == 0)
            {
                min = i;
            }
            else
            {
                if (i <= min) min = i;
            }
        }
    }
    Console.WriteLine($"Min cua hop so le la: {min}");
}

void DemoString()
{
    //1.Nhap full name va hien thi last name + first name + surname
    //VD: Nguyen Dinh Tuan Anh 
    // Last name: Nguyen
    //First name: Anh
    //Surname: Dinh Tuan
    Console.Write("Enter full name: ");
    string? full_name = Console.ReadLine();
    string[] s = full_name.Split(" ");
    Console.WriteLine($"Lastname: {formatString(s[0])}");
    Console.WriteLine($"Firstname: {formatString(s[s.Length - 1])}");
    string surname = "";
    for(int i = 1; i < s.Length - 1; i++)
    {
        if (!string.IsNullOrEmpty(s[i])) surname += formatString(s[i]) + " ";
    }
    Console.WriteLine($"Surname: {surname.Trim()}");
}

string formatString(string str)
{
    return str.ToUpper()[0].ToString() + str.Substring(1).ToLower();
}

void DemoList()
{
    List<String> list = new List<string>()
    {
        "Dao Xuan Quang",
        "Ha Manh Dat",
        "Nguyen Ngoc Vu"
    };
    //1. Show list hien tai
    Console.WriteLine("Cac phan tu co trong list: ");
    list.ForEach(str => { Console.WriteLine(str); });
    //2. Show nhung nguoi ten ban dau bang chu 'A'
    Console.WriteLine("Cac phan tu co trong list ten bat dau bang A: ");
    foreach(string str in list)
    {
        string[] arr = GetNameArray(str);
        if (arr[arr.Length - 1].StartsWith("A"))
            Console.WriteLine(str);
    }
    //3. Co bao nhieu nguoi last name dai hon first name
    Console.WriteLine($"So nguoi co last name dai hon first name la: {CountNameWithCondition(list)}");
    //4. Tinh tong ky tu first name cua nhung nguoi ma ho ten chua chuoi 'an'
    foreach (string str in list)
    {
        if (str.Contains("an"))
        {
            string[] arr = GetNameArray(str);
            Console.WriteLine($"{str}: {arr[arr.Length - 1].Length}");
        }
    }
}

int CountNameWithCondition(List<String> list)
{
    int count = 0;
    foreach (String str in list)
    {
        String[] arr = GetNameArray(str);
        if (arr[0].Length > arr[arr.Length - 1].Length) count++;
    }
    return count;
}

string[] GetNameArray(string str)
{
    string[] arr = str.Split(" ");
    return arr;
}



