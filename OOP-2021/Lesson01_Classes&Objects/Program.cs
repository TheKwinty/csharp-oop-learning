using Lesson01_Classes_Objects.Hometask;

namespace Lesson01_Classes_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClassA variableA = new MyClassA();
            variableA.FieldClassA = "MyClassA is working!";
            variableA.ShowFieldClassA();

            MyClassB variableB = new MyClassB();
            variableB.FieldClassB = "MyClassB is working!";
            variableB.ShowFieldClassB();

        }
    }
}
