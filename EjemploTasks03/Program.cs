


Console.WriteLine("Inicio del programa...");

Task tarea = Task.Factory.StartNew(() =>
{
    Console.WriteLine("Tarea ejecutándose...");
    Task.Delay(2000).Wait(); // Simula trabajo pesado
    Console.WriteLine("Tarea completada.");
});

tarea.Wait();

Console.WriteLine("Programa finalizado.");