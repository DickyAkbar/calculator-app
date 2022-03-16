class Program
{
        static void Main(string[] args)
        {
            int pilihan;
            int angka1 = 0;
            int angka2 = 0;
            float jawab;

            Console.WriteLine("Pilih Menu Calculator : " +Environment.NewLine+ " ");
            Console.WriteLine("1. Penambahan" + Environment.NewLine + "2. Pengurangan" + Environment.NewLine + "3. Perkalian" +Environment.NewLine + "4. Pembagian" +Environment.NewLine+ " ");

            Console.Write("Inputkan Nomor Menu [1..4] :");
            pilihan = Convert.ToInt32(Console.ReadLine());


            if (pilihan == 1) 
            {
                Console.Write(" " + Environment.NewLine + "Inputkan Nilai A : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan Nilai B : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                jawab = angka1 + angka2;
                Console.WriteLine("Hasil Penambahan " +angka1.ToString()+ " + " +angka2.ToString()+ " = " +jawab.ToString() );
            }
            else if (pilihan == 2)
            {
                Console.Write(" " + Environment.NewLine + "Inputkan Nilai A : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan Nilai B : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                jawab = angka1 - angka2;
                Console.WriteLine("Hasil Pengurangan " + angka1.ToString() + " - " + angka2.ToString() + " = " + jawab.ToString());
            }
            else if (pilihan == 3)
            {
                Console.Write(" " + Environment.NewLine + "Inputkan Nilai A : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan Nilai B : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                jawab = angka1 * angka2;
                Console.WriteLine("Hasil Perkalian " + angka1.ToString() + " * " + angka2.ToString() + " = " + jawab.ToString());
            }
            else if (pilihan == 4)
            {
                Console.Write(" " + Environment.NewLine + "Inputkan Nilai A : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan Nilai B : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                jawab = angka1 / angka2;
                Console.WriteLine("Hasil Pembagian " + angka1.ToString() + " / " + angka2.ToString() + " = " + jawab.ToString());
            }
            else
            {
                Console.WriteLine(" " +Environment.NewLine+ "Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.Write(" " +Environment.NewLine+ "Tekan sembarang key untuk keluar");
            Console.ReadKey(true);
        }
}
