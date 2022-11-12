// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int Power(int num, int exp)
{
    if (exp <= 0)
    {
        return 1;
    }

    return num * Power(num, exp - 1);
}

int num = Prompt("Введите число A");
int exp = Prompt("Введите число B");  // exponentiation

int result = Power(num, exp);
System.Console.WriteLine(result);

