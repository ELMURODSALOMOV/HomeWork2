double num1, num2, result;
char operation;
System.Console.WriteLine("Kalkulyatorga xush kelibsiz:");
System.Console.Write("Birinchi sonni kiriting: ");
num1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Operatorni kiriting:");
operation = Convert.ToChar(Console.ReadLine());
System.Console.Write("Ikkinchi sonni kiriting: ");
num2 = Convert.ToDouble(Console.ReadLine());

switch (operation)
{
    case '+':
    result = num1 + num2;
    System.Console.WriteLine("Natija: " + result);
    break;
    case '-':
    result = num1 - num2;
    System.Console.WriteLine("Natija: " + result);
    break;
    case '*':
    result = num1 * num2;
    System.Console.WriteLine("Natija: " + result);
    break;
    case '/':
    result = num1 / num2;
    System.Console.WriteLine("Natija: " + result);
    break;
}

System.Console.Write("N musbat butun sonini kiriting: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 1; i <= N; i++)
{
    count += i;
}
System.Console.WriteLine($"1 dan N gacha bo'lgan sonlar yig'indisi: {count}");

System.Console.Write("Biror sonni kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
    System.Console.WriteLine("Juft son");
}
else
{
    System.Console.WriteLine("Toq son");
}