// Сформировать трехмерный массив не повторяющимися двузначными числами, 
// показать его построчно на экран выводя индексы соответствующего элемента

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    if(number >= 10 && number < 100) return number;
    else return InputNumber("You enter wrong number!!! "
                        + "Please enter numbers from 10 to 99 ");
}

int[,,] FillCube(int rows, int columns, int diagonal, int minNum, int maxNum)
{
    int[,,] cube = new int[rows, columns, diagonal];
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = NewNumber(minNum, maxNum);
            }
        }
    }
    return cube;
}

int NewNumber(int minNum, int maxNum)
{
    HashSet<int> numbers = new HashSet<int>();
    Random random = new Random();
    while (true)
    {
        var number = random.Next(minNum, maxNum + 1);
        if (!numbers.Contains(number))
        {
            numbers.Add(number);
            return number;
        }
    }
}

void PrintCube(int[,,] cube)
{
     for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.WriteLine($"Element <{cube[i, j, k]}> by index [{i}, {j}, {k}]");
            }
        }
    }
}

Console.Clear();
int rows = 2;
int columns = 2;
int diagonal = 2;
int mininmum = InputNumber("Minimum two digit number: ");
int maximum = InputNumber("Maximum two digit number: ");

int[,,] cube = FillCube(rows, columns, diagonal, mininmum, maximum);
Console.WriteLine("3D:");
PrintCube(cube);