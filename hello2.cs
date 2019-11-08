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

    // this is a custom calculation
    // it will derive more values
    public int MyCustomCalculation(int a, int b)
    {
        int x = a * 10;
        int y = b * 20;
        if(x + y > 100) 
        {
            Console.WriteLine("this will require a manager approval");
        }
        return (x * y) + (a + b);
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}