Console.Clear();

TaskSolution();

void TaskSolution()
{
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] text = new string[size];

    FillArray(text);
    PrintArray(text);

    void FillArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("Введите размер массива:");
    }

    void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(string.Join(", ", array));
        }
        Console.WriteLine();
    }
}




