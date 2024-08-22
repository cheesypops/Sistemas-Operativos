// See https://aka.ms/new-console-template for more information

using Labo1;
using System;
using System.Threading;

Console.WriteLine("Hello, World!");

// instancia del contador
Counter counter = new Counter();

// instanciar los hilos junto con las funciones que van a desempeñar
Thread numThread = new Thread(() => {
    while (!counter.getStopNum()) {
        counter.incrementNumCount();
        Console.WriteLine("Num: " + counter.getNumCount());
    }
});
Thread minusThread = new Thread(() => {
    while (!counter.getStopNum()) {
        counter.incrementMinusCount();
        Console.WriteLine("Minus: " + counter.getMinusCount());
    }
});
Thread capitalThread = new Thread(() => {
    while (counter.getCapitalCount() != 'Z') {
        counter.incrementCapitalCount();
        Console.WriteLine("Capital: " + counter.getCapitalCount());
    }
});

// iniciar los hilos, junto con sus funciones
numThread.Start();
minusThread.Start();
capitalThread.Start();


// esperar a que los hilos terminen
numThread.Join();
minusThread.Join();
capitalThread.Join();

Console.WriteLine("Fin del programa");