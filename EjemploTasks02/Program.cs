Console.WriteLine("Inicio del programa...");

Task tarea1 = Task.Run(() => EjecutarTarea("Tarea 1", 2));
Task tarea2 = Task.Run(() => EjecutarTarea("Tarea 2", 3));
Task tarea3 = Task.Run(() => EjecutarTarea("Tarea 3", 1));

// Espera a que todas las tareas terminen
Task.WaitAll(tarea1, tarea2, tarea3);

Console.WriteLine("Todas las tareas han finalizado.");

void EjecutarTarea(string nombre, int segundos)
{
    Console.WriteLine($"{nombre} iniciada...");
    Task.Delay(segundos * 1000).Wait(); // Simula un trabajo pesado
    Console.WriteLine($"{nombre} completada.");
}