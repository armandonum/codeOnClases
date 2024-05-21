

public class Program{
public delegate int  MathOperation(int a, int b);
public static int Add(int a, int b) 
{
return a+b;
}

public static int Subtract(int a, int b) 
{
    return a-b;
}



public static void main(String[] arg)
{
    //instance of delegate 
    MathOperation operation=Add;

    //get delegate for the addition and show the result

    int result= operation(10,5);
    Console.WriteLine($"addition : {result}");

    //new delegate for the method subtraction
    operation=Subtract;

    //get delegate for the subtraction and show result 
    result=operation(10,5);
    Console.WriteLine($"substraction : {result}");


    MathOperation operation2=Subtract;
    operation2+=Add;

   int result3=operation2(10,5);
    Console.WriteLine($"substraction : {result3}");



}
}

