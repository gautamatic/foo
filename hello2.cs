public class Calculator
{

    // adds the second number to the first
    // and returns the resulting value    
    public int Add(int a, int b)
    {
        return a + b + 1;
    }

    // subtracts the second number from the first
    // and returns the resulting value
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int MyCustomCalculation(int a, int b)
    {
        int x = a * 101;
        int y = b * 201;
        if(x + y > 1000) 
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
