using System;

public class Program () {

    // Asynchronous simulated download method
    public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started.");
        try {
            // Optional: Introduce intentional error
            throw new InvalidOperationException("Simulated exception during download.");

            await Task.Delay(3000);     // Simulate Download by delay
            Console.WriteLine("Download completed.");
        }
        catch
        {
            // Handle any errors that occur during the download process
            Console.WriteLine($"An unknown error occured while downloading the data.");
        }
    }

    // Asynchronous Upload Task Simulation
    public async Task UploadDataAsync()
    {
        Console.WriteLine("Upload started.");
        await Task.Delay(4000);     // Simulate Upload by delay
        Console.WriteLine("Upload completed.");
    }

    public static async Task Main()
    {
        // Create an instance of the Program class
        Program program = new Program();
        await Task.WhenAll(
            program.DownloadDataAsync(),
            program.UploadDataAsync()
        );
        Console.WriteLine("Program completed.");
    }
}