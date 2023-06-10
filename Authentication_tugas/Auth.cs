namespace Authentication_tugas
{
    internal class Auth : CRUD
    {
        public void login()
        {
            Console.WriteLine("=========Login Akun===========");
            Console.Write("Username : ");
            string username = Console.ReadLine();
            Console.Write("Password : ");
            string password = Console.ReadLine();
            User akun = users.FirstOrDefault(user => user.username.Contains(username) && user.password.Contains(password));
            if (akun != null)
            {
                Console.WriteLine("Selamat datang : " + akun.firstName + " " + akun.lastName);
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Username atau password salah");
                Console.Write("Tekan apapun untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
