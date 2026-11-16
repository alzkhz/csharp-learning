
Console.Write("Masukkan bilangan: ");
int bil = Convert.ToInt32(Console.ReadLine());

if (bil % 2 == 1)
{
    Console.WriteLine("{0} Bilangan Ganjil", bil);
}

if (bil % 5 == 0)
{
    Console.WriteLine("{0} Kelipatan 5", bil);
}

if (bil > 0)
{
    Console.WriteLine("{0} Bilangan Positif", bil);
}
