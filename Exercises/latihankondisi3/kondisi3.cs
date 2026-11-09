bool member;

Console.Write("Member bukan (true/false)? ");
member = Convert.ToBoolean(Console.ReadLine());

if (member) {
    Console.WriteLine("Diskon 50%");
}
else {
    Console.WriteLine("Harga Biasa");
}