Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine()); //задаем размерность первоначального массива

// пользователь вводит элементы массива. Каждый с новой строки
string[] massiv = new string[size];
for (int i = 0; i < size; i++)
{
    massiv[i] = Console.ReadLine();
}

// выявляем в первоначальном массиве элементы, длина которых меньше или равна 3
string[] massivNew = new string[0];
int j = 0;
for (int i = 0; i < massiv.Length; i++)
{
    string a = massiv[i];
    if (a.Length <= 3)
    {
        Array.Resize(ref massivNew, massivNew.Length + 1); // Array.Resize - позволяет увеличивать размер массива
        massivNew[j] = massiv[i];
        j++;
    }
}

Console.WriteLine($"Массив из строк -> [{String.Join(", ", massiv)}]"); //Выводим первоначальный массив с разделителем 
Console.WriteLine($"Новый массив -> [{String.Join(", ", massivNew)}]"); //Выводим полученный массив с разделителем 