using System;
using System.Collections.Generic;

using ilunnie;
using ilunnie.Nuenv;
using ilunnie.Search;

List<int> BinarySearchTest<T>(List<T> collection)
{
    List<int> errors = new();
    Comparer<T> comparer = Comparer<T>.Default;
    for (int i = 0; i < collection.Count; i++)
    {
        T value = collection[i];
        int index = collection.BinarySearch<T>(value);
        if (index < 0 || comparer.Compare(value, collection[index]) != 0)
            errors.Add(i);
    }
    return errors;
}

// List<int> list = new() { 1, 2, 3, 5, 7, 8, 9 };
List<float> list = Space.ListInOrder(0, 1000, 10);
Console.WriteLine(list.ToArray().ToString<float>());
var errors = BinarySearchTest(list);

if (errors.Count > 0)
{
    Console.WriteLine("Erros ao buscar pelos index:");
    foreach (var error in errors)
        Console.WriteLine($"> {error} - Valor: {list[error]}");
}
else Console.WriteLine("Funcionou corretamente");