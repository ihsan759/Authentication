namespace Authentication_tugas
{
    internal class Menu
    {
        Auth auth = new Auth();
        public void view()
        {
            Console.WriteLine("======Authentication======");
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. Show User");
            Console.WriteLine("3. Search User");
            Console.WriteLine("4. Login User");
            Console.WriteLine("5. Exit");
            Console.Write("Pilih : ");
            string pilih = Console.ReadLine();
            switch (pilih)
            {
                case "1":
                    Console.Clear();
                    auth.create();
                    view();
                    break;
                case "2":
                    Console.Clear();
                    auth.Read();
                    view();
                    break;
                case "3":
                    Console.Clear();
                    auth.Get();
                    view();
                    break;
                case "4":
                    Console.Clear();
                    auth.login();
                    view();
                    break;
                case "5":
                    Console.WriteLine("Menutup aplikasi...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pilihan anda tidak tersedia silahkan coba kembali....");
                    Console.WriteLine();
                    Console.Write("Tekan apapun untuk melanjutkan...");
                    Console.ReadKey();
                    Console.Clear();
                    view();
                    break;
            }
        }
    }
}
