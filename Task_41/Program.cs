// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[m];
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива");
    int temp = Convert.ToInt32(Console.ReadLine());
    arr[i] = temp;

    if (arr[i] > 0)
    {
        count++;        
    }

}

Console.WriteLine();
Console.WriteLine("Массив");
Console.WriteLine(String.Join(",", arr));
Console.WriteLine("Количество чисел больше 0: " +count);
