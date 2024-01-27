using System;
using System.Collections.Generic;

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);
fila.Enqueue(6);

foreach (int itens in fila)
{
    Console.WriteLine(itens);
}

Console.WriteLine($"Removendo o item: {fila.Dequeue()}");
fila.Enqueue(7);

foreach (int itens in fila)
{
    Console.WriteLine(itens);
}