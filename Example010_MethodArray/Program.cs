// Найти индекс элемента с определенным значением

int[] array = {12, 224, 36, 45, 45, 36, 71, 82, 19};

int n = array.Length;
int find = 36;

int index = 0; // нумерация элементов в массиве начинается с 0 элемента

while (index < n)
{

if(array[index] == find)
{
    Console.WriteLine(index);
    break;
}

index++; //index = index + 1
}
