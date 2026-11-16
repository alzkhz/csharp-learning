Console.Write("Masukkan hari dalam angka (1-7): ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Senin");
        break;

    case 2:
        Console.WriteLine("Selasa");
        break;

    case 3:
        Console.WriteLine("Rabu");
        break;

    case 4:
        Console.WriteLine("Kamis");
        break;

    case 5:
        Console.WriteLine("Jumat");
        break;

    case 6:
        Console.WriteLine("Sabtu");
        break;

    case 7:
        Console.WriteLine("Minggu");
        break;

    default:
        Console.WriteLine("Input Salah");
        break;
}
