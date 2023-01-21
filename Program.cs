// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var context = new Context(new ConcreteStrategy1());
context.ExecuteAlgorithm();
context._concreteStrategy = new ConcreteStrategy2();
context.ExecuteAlgorithm();
public interface IStrategy
{
    public string Algorithm();
}


public class Context
{
    public IStrategy _concreteStrategy;
        public Context(IStrategy concreteStrategy)
    {
        _concreteStrategy = concreteStrategy;
    }

    public string ExecuteAlgorithm()
    {
        return _concreteStrategy.Algorithm();
    }
}

public class ConcreteStrategy1 : IStrategy
{
    public ConcreteStrategy1()
    {
        Console.WriteLine("ConcreteStrategy1 constractor");
    }

    public string Algorithm()
    {
        Console.WriteLine("ConcreteStrategy1");
        return "ConcreteStrategy1";
    }
}

public class ConcreteStrategy2 : IStrategy
{
    public ConcreteStrategy2()
    {
        Console.WriteLine("ConcreteStrategy2 constractor");
    }

    public string Algorithm()
    {
        Console.WriteLine("ConcreteStrategy2");
        return "ConcreteStrategy2";
    }
}