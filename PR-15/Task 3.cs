using System;

class Program
{
    static void Main()
    {
        Type myClassType = typeof(MyClass);

        object instance = Activator.CreateInstance(myClassType);
        MyClass myObject = (MyClass)instance;

        myObject.PublicProperty = 42;
        Console.WriteLine("Измененное значение PublicProperty: " + myObject.PublicProperty);

        myObject.PublicMethod();
    }
}
