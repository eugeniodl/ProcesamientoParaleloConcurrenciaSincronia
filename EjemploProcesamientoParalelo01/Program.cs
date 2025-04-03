


using System.Diagnostics;

var numeros = Enumerable.Range(1, 1000000000);
var sw = new Stopwatch();
sw.Start();

var numerosPares = from num in 
                       numeros.AsParallel().AsOrdered()
                   where num % 2 == 0
                   select num;

sw.Stop();

Console.WriteLine("{0} números pares de {1} números. " +
    "Tiempo: {2}", numerosPares.Count(), numeros.Count(),
    sw.ElapsedMilliseconds);