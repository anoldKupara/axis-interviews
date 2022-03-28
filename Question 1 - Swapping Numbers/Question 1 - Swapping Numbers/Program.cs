using System;
public class Exercise5
{
    public static void Main(string[] args)
    {
        int number1, number2, temp;
        Console.Write("\n1st number : ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("\n2nd number : ");
        number2 = int.Parse(Console.ReadLine());
        temp = number1;
        number1 = number2;
        number2 = temp;
        Console.Write("\n Expected Output ");
        Console.WriteLine();
        Console.Write("\n1st number : " + number1);
        Console.WriteLine();
        Console.Write("\n2nd number : " + number2);
        Console.Read();
    }
}