// задача 

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int GetSumAllDigits(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number = number /10;
    }
    return result;
}

bool IsNumberValid(int number)
{
    if(number < 0)
    return false;

    return true;
}

int number = Prompt("Введите число: ");

if(IsNumberValid(number))
{
    int SumDigits = GetSumAllDigits(number);
    Console.WriteLine("Сумма всех цифр в числе = " + SumDigits);
}
else
{
    Console.WriteLine("Программф с такими числами не работает");
}

