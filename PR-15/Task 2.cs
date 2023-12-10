using System;

class Program
{
    static void Main()
    {
        Type myClassType = typeof(MyClass);

        object instance = Activator.CreateInstance(myClassType);

        Console.WriteLine("Экземпляр MyClass создан успешно.");

        MyClass myObject = (MyClass)instance;
    }
}
