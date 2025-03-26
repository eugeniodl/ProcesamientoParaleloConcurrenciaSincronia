Console.WriteLine("Inicio del programa...");

Task tarea = Task.Run(() =>
{
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine($"Tarea en ejecución: {i}");
		Task.Delay(1000).Wait(); // Simula una tarea pesada
	}
});

tarea.Wait(); // Espera a que la tarea termine

Console.WriteLine("Tarea completada.");