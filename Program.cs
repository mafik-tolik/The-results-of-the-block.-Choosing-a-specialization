Console.Clear();

TaskSolution();

void TaskSolution()
{
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] text = new string[size];

    FillArray(text);

    void FillArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }
    }

    Console.WriteLine($"Вывод массива: [{string.Join(", ", text)}]");

}




