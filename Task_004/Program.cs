// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void TrianglePascale(int side)
{
   for (int i = 0; i < side; i++)
    {
        for (int c = 0; c <= (side - i); c++) 
        {
            Console.Write(" "); 
        }
        for (int c = 0; c <= i; c++)
        {
            Console.Write(" ");
            Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); 
        }
        Console.WriteLine();
        Console.WriteLine(); 
    }
}

int factorial(int digit)
{
    int x = 1;
    for (int i = 1; i <= digit; i++) 
        x *= i;
    return x;
}


int sideTriangle = InputNumber("Specify the length of the side of the triangle: ");
TrianglePascale(sideTriangle);