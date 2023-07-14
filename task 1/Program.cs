// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел необходимо проверить? - ");
int mas = int.Parse(Console.ReadLine());
Console.Write("Вводите по одному: ");
int plus = 0;
int[] Arr = new int[mas];
for (int i=0; i < Arr.Length; i++) 
{   
    Arr[i] = int.Parse(Console.ReadLine());
    if (Arr[i] > 0) plus++;
    if(i < Arr.Length-1) Console.Write("Следующее: ");
}

Console.Write("[");
for (int i=0; i < Arr.Length; i++)
{
    Console.Write(Arr[i]);
    if(i < Arr.Length-1) Console.Write(", ");
}
Console.Write("]");
if(plus != 1){
    Console.Write($" -> из них {plus} положительных.");
}
else{
    Console.Write($" -> из них {plus} положительное.");
}
