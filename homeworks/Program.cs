//задание1
Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 999)
{
    Console.WriteLine("Число не трехзначное, попробуйте ввести снова");
}
else 
{
    Console.WriteLine(num%100/10);
}

//задание2

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine(num + " -> третьей цифры нет");
}
else if (num > 99 && num < 1000)
{
    Console.WriteLine(num + " -> " + num%10);
}
else 
{
    Console.Write(num);
    while (num > 999)
        {
            num = num/10;
        }
     Console.WriteLine(" -> " + num%10);
}


//Задание3
Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
    {
        Console.WriteLine("Дня недели с таким порядковым номером не существует");
        Console.WriteLine("Попробуйте ввести номер снова");
    }
else if (number >= 1 && number < 6)
    {
         Console.WriteLine(number + " -> нет");
    }
else
    {
         Console.WriteLine(number + " -> да");
    }