string country;
string city;
string adress;
int home_number;

Console.Write("Masukkan Negara: ");
country = Console.ReadLine();

Console.Write("Masukkan Kota: ");
city = Console.ReadLine();

Console.Write("Masukkan Alamat: ");
adress = Console.ReadLine();

Console.Write("Masukkan Nomor Rumah: ");
home_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("=====INFORMASI TEMPAT TINGGAL=====");
Console.WriteLine();
Console.WriteLine("Negara: " + country);
Console.WriteLine("Kota: " + city);
Console.WriteLine("Alamat: " + adress);
Console.WriteLine("Nomor Rumah: " + home_number);
Console.WriteLine();
Console.WriteLine("==================================");