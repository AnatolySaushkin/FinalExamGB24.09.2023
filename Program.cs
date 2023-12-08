// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string Prompt(string message)
{
    System.Console.Write(message);
    string result = System.Console.ReadLine()!;
    return result;
}

System.Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 0;
string[] Array1 = GenerateArray(N);
Console.Write("Результат выполнения задачи: ");
PrintArray(Array1);
CountNewArray(N);
string[] Array2 = GenerateNewArray(M);
PrintNewArray(Array2);

// Задаем элементы массива
string[] GenerateArray(int N)
{
    string[] Array1 = new string[N];
    for (int i = 0; i < N; i++)
    {
        Array1[i] = Prompt($"Введите Элемент массива № {i + 1}: ");
    }
    return Array1;
}
void PrintArray(string[] Array1)
{
    for (int i = 0; i < N; i++)
    {
        System.Console.Write(Array1[i] + " ");
    }
    System.Console.Write(" -> ");
}

int CountNewArray(int N)
{
    for (int i = 0; i < N; i++)
    {
        if (Array1[i].Length <= 3)
        {
            M++;
        }
    }
    return M;
}

string[] GenerateNewArray(int M)
{
    string[] Array2 = new string[M];
    int a = 0;
    for (int i = 0; i < N; i++)
    {
        if (Array1[i].Length <= 3)
        {
            Array2[a] = Array1[i];
            a++; 
        }
    }
    return Array2;
}

void PrintNewArray(string[] Array2)
{
    for (int i = 0; i < M; i++)
    {
        System.Console.Write(Array2[i] + " ");
    }
}



////Задача №1 Выполнить сложение выражений. 
//// Задача №2. Вывести результат на экран. 
