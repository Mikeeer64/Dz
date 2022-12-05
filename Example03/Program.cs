int GetNamber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите число больше 0.");
        }
    }

    return result;
}

int namber = GetNamber("Введите число: ");

for (int i = 1; i <= namber; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}
