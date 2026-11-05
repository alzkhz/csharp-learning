int x;
int y;

    Console.Write("Masukkan angka pertama: ");
        x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Masukkan angka kedua: ");
        y = Convert.ToInt32(Console.ReadLine());

// operator aritmatika
int tambah = x + y;
int kurang = x - y;
int kali = x * y;
int bagi = x / y;
int sisa = x % y;

    Console.WriteLine();
    Console.WriteLine("=====ARITMATIKA=====");
    Console.WriteLine();
    Console.WriteLine($"Hasil Penjumlahan: {tambah}");
    Console.WriteLine($"Hasil Pengurangan: {kurang}");
    Console.WriteLine($"Hasil Perkalian: {kali}");
    Console.WriteLine($"Hasil Pembagian: {bagi}");
    Console.WriteLine($"Sisa Pembagian: {sisa}");
    Console.WriteLine();

// operator komparsi
    Console.WriteLine("=====KOMPARASI=====");
    Console.WriteLine();
    Console.WriteLine(x > y);
    Console.WriteLine(x < y);
    Console.WriteLine(x == y);
    Console.WriteLine(x != y);
    Console.WriteLine();

// operator logika
bool human = true;
bool animal = false;

    Console.WriteLine("=====LOGIKA=====");
    Console.WriteLine(human && animal);
    Console.WriteLine(human || animal);
    Console.WriteLine(!human);
