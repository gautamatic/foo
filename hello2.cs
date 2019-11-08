public class Calculator
{

    // adds the second number to the first
    // and returns the resulting value    
    // and adds one
    public int Add(int a, int b)
    {
        return a + b + 1;
    }

    // subtracts the second number from the first
    // and returns the resulting value
    // adds one
    public int Subtract(int a, int b)
    {
        return a - b + 1;
    }

    public int MyCustomCalculation(int a, int b)
    {
        int x = a * 10;
        int y = b * 20;
        if(x + y > 100) 
        {
            Console.WriteLine("this will require a manager approval");
        }
        else if (x + y < 50)
        {
            Console.WriteLine("this is okay for you to approve");
        }
        else 
        {
            // do nothing 
        }
        return (x * y) + (a + b);
    }
}
