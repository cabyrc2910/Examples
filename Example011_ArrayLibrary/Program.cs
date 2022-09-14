void FillArray(int[] collection)
{
    int length = collection.Length;  //Длина массива
    int index = 0;  //Позиция index  по умолчанию 0
    while (index < length)  // Пока
    {
        collection[index] = new Random().Next(1, 10);
        index++; //index = index + 1;
    }
} 

void PrintArray(int[] col) // Метод void который печатает массив (ничего не возвращает)
{
    int count = col.Length;  // Количество элементоа массива
    int position = 0;  
    while (position < count)
    {
        Console.WriteLine(col[position]); //Вывод значения текущего элемента
        position++; // Увеличиваем значение текущей позиции
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // по умолчанию "0", 
    // но если не встречается ни одного элемента на позиции по умолчанию возвращаем значение "-1"
    while (index < count)
    {
        if(collection[index]== find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];  // Создай новай массив в котором 10 элементов

FillArray(array);
// array [4] = 4;   // Можем искуственно добавить значение 4 на позиции 4
// array [6] = 4;   // и ещё одно значение 4 на позиции 6

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // в качестве аргумента  массив, ищем 4
// Если введём в поиск (array, 444) элемент которого не существует - вывод позиции будет "0"
Console.WriteLine(pos);