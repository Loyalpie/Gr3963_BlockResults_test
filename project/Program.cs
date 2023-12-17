//создает массив строк из N элементов (N вводит пользователь), создает новый массив и заполняет его значениями из первого, длина которых меньше либо равна 3

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//метод создает новый массив и заполняет его строками, длина которых меньши либо равна 3
string[] CreateNewArray(string[] array)
{
    int len = 0; // переменная, которая будет использоваться в новом массиве для его длины

    //проверяет все элементы исходного массива. если длина элемента <= 3 увеличивает len на 1
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) len++;
    }

    string[] newArray = new string[len]; //создаем новый массив длины len

    //заполняет новый массив строками с длиной меньше либо равной 3

    int index = 0; //переменная для индексов нового элемента

    //цикл заполнения нового массива
    for (int i = 0; i < array.Length; i++)
    {
        //если элемент исходного массива <= 3 то присваивает его значение элементу нового массива
        if (array[i].Length <= 3) 
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

//метод генерации массива
string[] GenArray(int len)
{
    string[] array = new string[len]; //создание массива

    //заполнение массива
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i} элемент массива: ");
        array[i] = Console.ReadLine(); //ввод значений массива с клавы
    }
    return array; //возвращение массива
}

//метод "рисования" одномерного массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int len = ReadData("Введите количество элементов массива: "); //длина исходного массива

string[] array = GenArray(len); //создание исходного массвиа
PrintArray(array); // вывод исходного массвиа

string[] newArray = CreateNewArray(array); //создание нового массива
PrintArray(newArray); //вывод нового массива