Task tarea = Task.Run(() =>
{
    throw new InvalidOperationException("Ocurrió un error en la tarea.");
});

try
{
	tarea.Wait();
}
catch (AggregateException ex)
{
	foreach (var e in ex.InnerExceptions) // Asegura que todas las excepciones internas sean accesibles
    {
        Console.WriteLine($"Excepción capturada: {e.Message}");
    }
}
