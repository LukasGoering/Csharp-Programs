using System;

public class Program
{
    public async Task PerformLongOperationAsync()
    {
        try
        {
            
            Console.WriteLine("Operation started.");
            await Task.Delay(3000);
            throw new InvalidOperationException("Simulated long operation error.");
            Console.WriteLine("Operation completed");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"The method PerformLongOperationAsync failed due to the exception: {ex.Message}");
        } 
    }

    public static void Main()
    {
        Program program = new Program();
        Task.Run(async () => await program.PerformLongOperationAsync()).Wait();
        Console.WriteLine("Main method completed.");
    }
}