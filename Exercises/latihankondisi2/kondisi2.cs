Console.Write("Masukkan nilai: ");
int nilai = Convert.ToInt32(Console.ReadLine());

if (nilai >= 90) {
    Console.WriteLine("Gold");
}
else if (nilai >= 80) {
    Console.WriteLine("Silver");
}
else if (nilai >= 50) {
    Console.WriteLine("Bronze");
}
else {
    Console.WriteLine("Tidak Lulus");
}