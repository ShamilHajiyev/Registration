using System;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Password set olundugu zaman icerisinde minimum 1 eded olmalidir ve minimum 1 herfi boyuk olmalidir.
            //Console Application run olundugu zaman admin username ve passwordunu daxil edir.
            //Eger daxil olunan deyer Username memberinin sertlerini odemirse  istifadeciden yeniden username-ni daxil etmesi teleb olunmalidir.
            //Eyni qaydada daxil olunan deyer Password memberinin sertlerini odemirse istifadeciden yeniden password-u daxil etmesi teleb olunmalidir.
            //Eger her sey duzgundurse console-da IsSuperAdmin ve Section deyerleri qeyd olunur ve admin datasi yaranir.
            //En sonda adminin butun datalarini geriye qaytaran bir method-u cagiraraq ekranda Adminin datalarini yazdirirsiz ve application bitir.
       
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            Admin admin = new Admin(username, password, true, "Section A");
            Console.WriteLine($"\nSuper admin: {admin.IsSuperAdmin}\nSection: {admin.Section}");
        }
    }
}
