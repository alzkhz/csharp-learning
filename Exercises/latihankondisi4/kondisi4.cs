int umur;
string lulus;

Console.WriteLine();
Console.WriteLine("=====Syarat Mendapatkan SIM=====");
Console.WriteLine();

Console.Write("Berapa umur anda? ");
umur = Convert.ToInt32(Console.ReadLine());

Console.Write("Apakah lulus tes (ya/tidak)? ");
lulus = Console.ReadLine();

if (umur >= 17 && (lulus == "ya" || lulus == "Ya" || lulus == "yaa" || lulus == "Yaa" || lulus == "YA" || lulus == "YAA"))
{
    Console.WriteLine("Anda berhak mendapatkan SIM");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Anda belum bisa mendapatkan SIM");
}

Console.WriteLine();
Console.WriteLine("=================================");