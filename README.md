From Strategy Pattern to Lambda Expressions
===========================================


1. Define a delegate, then inject the strategy using one of the following delegate creation style: 

```
// Declare a delegate.
delegate void Del(string str);

// Declare a method with the same signature as the delegate.
static void Notify(string name)
{
    Console.WriteLine("Notification received for: {0}", name);
}

// Create an instance of the delegate.
Del del1 = new Del(Notify);

// C# 2.0 provides a simpler way to declare an instance of Del.
Del del2 = Notify;

// Instantiate Del by using an anonymous method.
Del del3 = delegate(string name)
    { Console.WriteLine("Notification received for: {0}", name); };

// Instantiate Del by using a lambda expression.
Del del4 = name =>  { Console.WriteLine("Notification received for: {0}", name); };
```

2. Inject the strategy as a class method

3. Define strategies as local functions in place of methods. Remove the delegate and use a built-in delegate (`Action` or `Function`):

Remember that parametrized strategy can be a closure.

```
public class Foo
{
    public int Calculate(int a, int b)
    {
        int Add(int x, int y)  // Func<int, int, int>
        {                      //                 ^
            return x + y;      //             returned value
        }
        
        return Add(a, b);
    }
}
```


4. Use lambdas! Replace local functions with inline defined lambda expressions.

```
public class Foo
{
    private readonly Func<int, int, int> _strategy;

    public Foo(Func<int, int, int> strategy)
    {
        _strategy = strategy;
    }
    
    public int Calculate(int a, int b)
    {           
        return _strategy(a, b);
    }
}
```
