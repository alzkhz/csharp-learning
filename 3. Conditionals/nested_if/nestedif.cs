string user;
string pw;

Console.WriteLine("===== Login Account =====");


Console.Write("Masukkan Username: ");
user = Console.ReadLine();

Console.Write("Masukkan Password: ");
pw = Console.ReadLine();

if (user == "etmin")
{
    if (pw == "etmin123")
    {
        Console.WriteLine();
        Console.WriteLine("Login Berhasil");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Login Gagal");
        Console.WriteLine("Password Salah");
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("Login Gagal");
    Console.WriteLine("Username Tidak Ditemukan");
}

Console.WriteLine("========================");

