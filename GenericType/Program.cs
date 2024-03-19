using System;


class Program
{
    static void Main(string[] args)
    {
        //int tipi döndüren genericclass
        GenericClass<int> intGenericClass = new GenericClass<int>(10);
        int intValue = intGenericClass.GetValue();
        Console.WriteLine(intValue);

        //string tiipi döndüren genericclass
        GenericClass<string> stringGenericClass = new GenericClass<string>("Ben string tipi döndüren GC!");
        string stringValue=stringGenericClass.GetValue();
        Console.WriteLine(stringValue); 
    }
}
public class GenericClass<T>
{
    private T genericField;
    public GenericClass(T value) //ctor metodu
    {
        genericField = value;
    }
    public T GetValue()
    {
        return genericField;
    }
}
