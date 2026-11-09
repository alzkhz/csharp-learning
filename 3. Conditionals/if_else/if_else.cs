int nilai;

Console.Write("Masukkan nilai: ");
nilai = Convert.ToInt32(Console.ReadLine());

if (nilai >= 90)
{
    Console.WriteLine("Predikat: A");
}
else if (nilai >= 70)
{
    Console.WriteLine("Predikat: B");
}
else if (nilai >= 60)
{
    Console.WriteLine("Predikat: C");
}
else if (nilai >= 40)
{
    Console.WriteLine("Predikat: D");
}
else if (nilai >= 20)
{
    Console.WriteLine("Predikat: E");
}
else if (nilai >= 0)
{
    Console.WriteLine("REMEDIAL");
}
else
{
    Console.WriteLine("Input Tidak Valid");
}
