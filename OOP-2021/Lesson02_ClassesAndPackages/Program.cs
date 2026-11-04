using OOP2021.Lesson02.MyClass1;

namespace Lesson02_ClassesAndPackages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass1 instance = new MyClass1();
            instance.Show();

            OOP2021.Lesson02.MyClass2.MyClass2 instance2 = new OOP2021.Lesson02.MyClass2.MyClass2();
            instance2.Show();
        }
    }
}
