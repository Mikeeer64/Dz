int GetNamber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(),out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}

int x1 = GetNamber("Введите координату X для первой точки: ");
int y1 = GetNamber("Введите координату Y для первой точки: ");
int z1 = GetNamber("Введите координату Z для первой точки: ");
int x2 = GetNamber("Введите координату X для второго точки: ");
int y2 = GetNamber("Введите координату Y для второго точки: ");
int z2 = GetNamber("Введите координату Z для первой точки: ");

double sum1 = Math.Pow((x2 - x1), 2);
double sum2 = Math.Pow((y2 - y1), 2);
double sum3 = Math.Pow((z2 - z1), 2);

double result = Math.Sqrt(sum1 + sum2 + sum3);

Console.WriteLine(result);

