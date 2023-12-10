using System;
using System.Reflection;

class MyClass
{
    private void PrivateMethod()
    {
        Console.WriteLine("PrivateMethod вызван");
    }
}

class Program
{
    static void Main()
    {
        Type myClassType = typeof(MyClass);

        object instance = Activator.CreateInstance(myClassType);
        MyClass myObject = (MyClass)instance;

        MethodInfo privateMethodInfo = myClassType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);

        if (privateMethodInfo != null)
        {
            privateMethodInfo.Invoke(myObject, null);
        }
    }
}
