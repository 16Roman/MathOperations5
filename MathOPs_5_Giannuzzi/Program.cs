namespace MathOPs_5_Giannuzzi
{ 
    internal class Program
    { 
        static void Main(string[] args)
        { 
Console.WriteLine("Math Operations Exercise 5");
//Read Values
Console.Write("Enter Interger #1:");
string stringNum1 = Console.ReadLine();
int Num1=int.Parse(stringNum1);

Console.Write("Enter Interger #2:");
string stringNum2 = Console.ReadLine();
int Num2 = int.Parse(stringNum2);

Console.Write("Enter Interger #3:");
string stringNum3 = Console.ReadLine();
int Num3 = int.Parse(stringNum3);

Console.Write("Enter Interger #4:");
string stringNum4 = Console.ReadLine();
int Num4 = int.Parse(stringNum4);

Console.Write("Enter Interger #5:");
string stringNum5 = Console.ReadLine();
int Num5 = int.Parse(stringNum5);

int negativeAmount=0;
int positiveAmount=0;
int zeroAmount=0;
//Calc Values
if(Num1==0)
{
    zeroAmount++;
}
if (Num1>=1)
{
    positiveAmount++;
}
if(Num1<=-1)
{
    negativeAmount++;
}

if (Num2 == 0)
{
    zeroAmount++;
}
if (Num2 >= 1)
{
    positiveAmount++;
}
if (Num2 <= -1)
{
    negativeAmount++;
}

if (Num3 == 0)
{
    zeroAmount++;
}
if (Num3 >= 1)
{
    positiveAmount++;
}
if (Num3 <= -1)
{
    negativeAmount++;
}

if (Num4 == 0)
{
    zeroAmount++;
}
if (Num4 >= 1)
{
    positiveAmount++;
}
if (Num4 <= -1)
{
    negativeAmount++;
}

if (Num5 == 0)
{
    zeroAmount++;
}
if (Num5 >= 1)
{
    positiveAmount++;
}
if (Num5 <= -1)
{
    negativeAmount++;
}

//Display Values

Console.WriteLine($"{negativeAmount} negative intergers entered, {positiveAmount} positive intergers entered, {zeroAmount} zeros entered");
Console.WriteLine("Press Any Key to Exit");
Console.ReadKey();
        }
    }
}