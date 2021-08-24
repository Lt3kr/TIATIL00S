class Calculator
{
    public void Main()
    {
        this.Calc();
    }

    public void Calc()
    {
        Console.WriteLine("Number one: ");
        int NumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number two: ");
        int NumberTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(NumberOne+NumberTwo);
    }
}

(new Calculator()).Main();