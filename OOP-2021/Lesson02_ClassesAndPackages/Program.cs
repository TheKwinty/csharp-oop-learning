using Lesson02_ClassesAndPackages_MyClass1;

namespace Lesson02_ClassesAndPackages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass1 instance = new MyClass1();
            instance.Show();

            Lesson02_ClassesAndPackages_MyClass2.MyClass2 instance2 = new Lesson02_ClassesAndPackages_MyClass2.MyClass2();
            instance2.Show();
        }
    }
}
