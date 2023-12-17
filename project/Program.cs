//создает массив строк из N элементов (N вводит пользователь), создает новый массив и заполняет его значениями из первого, длина которых меньше либо равна 3

//ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
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

