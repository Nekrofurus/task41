// Пользователь с клавиатуры вводим M чисел. Посчитайте сколько чисел больше 0 ввел пользователь
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 - >3
Console.WriteLine("Для рассчета количества значений >0");
Console.Write("Введите количество элементов для проверки (M) = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] UserInputArray(int size)
{
    int[] array = new int[size];
        for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}е число из {size} - ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int AboveZeroArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < size; i++)
        {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int[] userInputArray = UserInputArray(size);
Console.Write($"Количество чисел >0 = {AboveZeroArray(userInputArray)}");
