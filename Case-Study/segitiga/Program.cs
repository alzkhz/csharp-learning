Console.Write("Masukkan angka pertama: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Masukkan angka kedua: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Masukkan angka ketiga: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("Segitiga Sama Sisi");
}

else if (a == b || b == c || a == c)
{
    Console.WriteLine("Segitiga Sama Kaki");
}

else
{
    Console.WriteLine("Segitiga Sembarang");
}