int angka1;
int angka2;
string opr;

Console.WriteLine();
Console.WriteLine("==========KALKULATOR==========");

Console.WriteLine();
Console.WriteLine("Panduan Operator:");
Console.WriteLine("(+) --> Tambah");
Console.WriteLine("(-) --> Kurang");
Console.WriteLine("(*) --> Kali");
Console.WriteLine("(/) --> Bagi");

Console.WriteLine();
Console.Write("Masukkan angka pertama: ");
angka1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Masukkan operator: ");
opr = Console.ReadLine();

Console.Write("Masukkan angka kedua: ");
angka2 = Convert.ToInt32(Console.ReadLine());

int tambah = angka1 + angka2;
int kurang = angka1 - angka2;
int kali = angka1 * angka2;
double bagi = (double)angka1 / angka2;

Console.WriteLine();
if (opr == "+")
{
    Console.WriteLine("Hasil = " + tambah);
}
else if (opr == "-")
{
    Console.WriteLine("Hasil = " + kurang);
}
else if (opr == "*")
{
    Console.WriteLine("Hasil = " + kali);
}
else if (opr == "/")
{
    Console.WriteLine("Hasil = " + bagi);
}
else
{
    Console.WriteLine("Input tidak valid");
}

Console.WriteLine();
Console.WriteLine("==============================");