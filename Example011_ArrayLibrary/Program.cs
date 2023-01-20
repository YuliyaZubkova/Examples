// 

void FillArray(int[] collection) 
//collection - аргумент
//void - если метод (функция) ничего не возвращает 
//и в коде мы не используем оператор return
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++; //index = index + 1
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    //если элемента нет в списке - значит будет выдавать значение -1 
    //чтобы не путать 0 с нулевым индексом
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
//new int [10] - означает создать новый массив, 
//в котором будет 10 элементов
int[] array = new int [10]; 

FillArray(array);
PrintArray(array);
Console.WriteLine(); // вывод пустой строки

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
