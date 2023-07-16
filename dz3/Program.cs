/* Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
2 4 | 3 4 2
3 2 | 3 3 1
Результирующая матрица будет:
18 20 8
15 18 7 */

int m = InputNumbers("Введите количество строк 1-й матрицы -> ");
int n = InputNumbers("Введите количество столбцов 1-й матрицы -> ");
int o = InputNumbers("Введите количество строк 2-й матрицы -> ");
int p = InputNumbers("Введите количество столбцов 2-й матрицы -> ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");
Console.WriteLine();

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine("Первая матрица:");
Console.WriteLine();
WriteArray(firstMartrix);
Console.WriteLine();

int[,] secomdMartrix = new int[o, p];
CreateArray(secomdMartrix);
Console.WriteLine("Вторая матрица:");
Console.WriteLine();
WriteArray(secomdMartrix);
Console.WriteLine();

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
Console.WriteLine();
WriteArray(resultMatrix);
Console.WriteLine();

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
