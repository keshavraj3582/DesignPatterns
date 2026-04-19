using System;
public interface IThali
{
    public void PrePare();
}
public class BasicThali:IThali
{
    public void PrePare()
    {
        Console.WriteLine("Deliver Basic Thali");
    }
}
public class StandardThali:IThali
{
    public void PrePare()
    {
        Console.WriteLine("Deliver Standarad Thali");
    }
}
public class DeluxThali:IThali
{
    public void PrePare()
    {
        Console.WriteLine("Deliver Delux Thali");
    }
}
//
public class WheatThaliBasic:IThali
{
    public void PrePare()
    {
        Console.WriteLine("Deliver Basic Thali");
    }
}
public class WheatThaliStandard:IThali
{
    public void PrePare()
    {
        Console.WriteLine("Deliver Standarad Thali");
    }
}
public class WheatThaliDelux:IThali
{
    public void PrePare()
    {
        Console.WriteLine("Deliver Delux Thali");
    }
}

//
public class Thali
{
    IThali DeliverThali;
    public Thali(IThali thali)
    {
        DeliverThali=thali;
    }
    public void Delivery()
    {
        DeliverThali.PrePare();
    }
}
public interface IThaliFactory
{
    IThali CreateThali(int choice);
}
public class BasicThaliFactory():IThaliFactory
{
    public IThali CreateThali(int choice)
    {
        return choice switch
        {
            1=>new BasicThali(),
            2=>new StandardThali(),
            3=>new DeluxThali(),
            _=>throw new InvalidDataException("Unsupported Choice")
        };
    }
}
public class WheatThaliFactory():IThaliFactory
{
    public IThali CreateThali(int choice)
    {
        return choice switch
        {
            1=>new WheatThaliBasic(),
            2=>new WheatThaliStandard(),
            3=>new WheatThaliDelux(),
            _=> throw new InvalidDataException("Unsupported Choice")
        };
        
    }
}

public class Client
{
    static void Main()  
    {
        IThali thali= new WheatThaliFactory().CreateThali(3);
        thali.PrePare();
    }
}