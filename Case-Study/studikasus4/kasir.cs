string barang;
int harga;
int jumlah;

Console.WriteLine();
    Console.WriteLine("==========KASIR==========");

Console.WriteLine();
    Console.Write("Nama Barang: ");
        barang = Console.ReadLine();

    Console.Write("Harga Barang: ");
     harga = Convert.ToInt32(Console.ReadLine());

    Console.Write("Jumlah Barang: ");
        jumlah = Convert.ToInt32(Console.ReadLine());

int total = harga * jumlah;

Console.WriteLine();
    Console.WriteLine("Total Harga = " + total);

Console.WriteLine();
    Console.WriteLine("=========================");


