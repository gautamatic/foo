public class Calculator
{

    // adds the second number to the first
    // and returns the resulting value    
    public int Add(int a, int b)
    {
        return a + b;
    }

    // subtracts the second number from the first
    // and returns the resulting value
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int MyCustomCalculation(int a, int b)
    {
        int x = a * 10;
        int y = b * 20;
        if(x + y > 100) 
        {
            Console.WriteLine("this will require a manager approval");
        }
        else
        {
            Console.WriteLine("this is okay for you to approve");
        }
        return (x * y) + (a + b);
    }

    public int Multiply(int a, int b)
    {
        return a * b + 1;
    }
}
