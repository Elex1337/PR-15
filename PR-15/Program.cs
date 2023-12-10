using System;
using System.Reflection;

class MyClass
{
    private int privateField;
    public string publicField;

    public int PublicProperty { get; set; }
    private string PrivateProperty { get; set; }

    public MyClass() { }
    private MyClass(int privateField, string privateProperty)
    {
        this.privateField = privateField;
        PrivateProperty = privateProperty;
    }

    public void PublicMethod() { Console.WriteLine("PublicMethod"); }
    private void PrivateMethod() { Console.WriteLine("PrivateMethod"); }
}

class Program
{
    static void Main()
    {
        Type myClassType = typeof(MyClass);

        Console.WriteLine("Имя класса: " + myClassType.Name);

        Console.WriteLine("\nКонструкторы:");
        ConstructorInfo[] constructors = myClassType.GetConstructors();
        foreach (var constructor in constructors)
        {
            Console.WriteLine($"  {constructor}");
        }

        Console.WriteLine("\nПоля и свойства:");
        FieldInfo[] fields = myClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        PropertyInfo[] properties = myClassType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (var field in fields)
        {
            Console.WriteLine($"  {field.FieldType.Name} {field.Name} ({field.Attributes})");
        }

        foreach (var property in properties)
        {
            Console.WriteLine($"  {property.PropertyType.Name} {property.Name} ({property.Attributes})");
        }

        Console.WriteLine("\nМетоды:");
        MethodInfo[] methods = myClassType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        foreach (var method in methods)
        {
            Console.WriteLine($"  {method.ReturnType.Name} {method.Name} ({method.Attributes})");
        }
    }
}
