using Internal;

namespace Main 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Base obj = new Child();
            obj.show();
            System.Console.WriteLine(obj.data);
        }
    }

    public class Base
    {
        public int data = 0;

        public virtual void show(){
            System.Console.WriteLine("Base Class Show " + data);
        }
    }

    public class Child : Base
    {
        public new int data = 19;
        public override void show(){
            System.Console.WriteLine("Child Class show " + data);
        }
    }

    public class ChildOfPublicInMain : Public
    {
        public static void show()
        {
            System.Console.WriteLine(name);
        }
    }
}