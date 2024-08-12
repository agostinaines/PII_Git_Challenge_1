Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));

public class Division
{
    public static int Divide(int a, int b)
    {
        return a / b;
    }
}

<<<<<<< HEAD
// Esta clase implementa la operación SUMA
=======
>>>>>>> feature-multiplication
public class Addition
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

public class Multiplication
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}