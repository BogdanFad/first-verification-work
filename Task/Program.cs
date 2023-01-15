// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.WriteLine("Введите значения через пробел: ");
string[] stringArray = Console.ReadLine()!.Split(' ');
for (int i = 0; i < stringArray.Length; i++)
{
    Console.Write(stringArray[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        Console.Write(stringArray[i] + " ");
    }
}
Console.WriteLine();