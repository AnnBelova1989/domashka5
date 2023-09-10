//Пользователь вводит с клавиатуры кол-во чисел. Посчитать, сколько чисел  >0 ввел пользователь:
int Input(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int Itog(int num)
{
    int count=0;
    for (int i = 1; i <= num; i++)
    {
        if (int.Parse(Console.ReadLine()) > 0)
        {
            count = count + 1;
        }
    }
        return count;
}

int m = Input("Введите колличество элементов: ");
int itog = Itog(m);

System.Console.WriteLine($"Чисел больше нуля {itog}  ");
