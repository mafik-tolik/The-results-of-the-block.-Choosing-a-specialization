Console.Clear();

TaskSolution();

void TaskSolution()
{
    Console.WriteLine("Введите размер массива:");
    int size1 = Convert.ToInt32(Console.ReadLine());

    string[] text = new string[size1];

    FillArray(text);

    void FillArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
            if (array[i] == null) array[i] = String.Empty;
        }
    }

    Console.WriteLine($"Вывод первоначального массива: [{string.Join(", ", text)}]");

    int Count(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i].Length < 4) count++;
        return count;
    }

    int size2 = Count(text);
    string[] threeSymbols = new string[size2];

    Console.WriteLine("Размер второго массива: " + size2);
}




