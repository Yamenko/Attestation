
int count_row_less_three_symbols(string[] arr_str) {
    int count = 0;
    for (int i = 0; i < arr_str.Length; i++) { 
        if (arr_str[i].Length <= 3) { count++; }
    }
    return count;
}

string[] arr_max_three_symbols(string[] arr_str) {
    int size = count_row_less_three_symbols(arr_str);
    int index = 0;
    string[] tmp_arr = new string[size];
    for (int i = 0; i < arr_str.Length; i++)
    {
        if (arr_str[i].Length <= 3) { tmp_arr[index++] = arr_str[i]; }
    }
    return tmp_arr;
}


while (true)
{
    int size = 0;
    Console.WriteLine("Сколько элементов будет в массиве (0 - для выхода):");
    Int32.TryParse(Console.ReadLine(), out size);
    if (size == 0) { break; }

    string[] arr_str = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите строку {i+1}:") ;
        arr_str[i] = Console.ReadLine();
    }

    Console.WriteLine("Новый массив: ");
    Console.WriteLine(String.Join(" ", arr_max_three_symbols(arr_str)));
}