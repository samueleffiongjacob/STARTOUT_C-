namespace AdvanceConcept.AsyncProgramming
{
    public static class AsyncExamples
    {
        public static async Task RunExamplesAsync()
        {
            Console.WriteLine("⏳ Asynchronous Programming Examples...\n");

            // Sequential execution
            Console.WriteLine("Sequential Execution:");
            var start1 = DateTime.Now;
            await DownloadFileAsync("File1");
            await DownloadFileAsync("File2");
            await DownloadFileAsync("File3");
            var elapsed1 = (DateTime.Now - start1).TotalSeconds;
            Console.WriteLine($"Total time: {elapsed1:F2} seconds\n");

            // Parallel execution
            Console.WriteLine("Parallel Execution:");
            var start2 = DateTime.Now;
            var task1 = DownloadFileAsync("FileA");
            var task2 = DownloadFileAsync("FileB");
            var task3 = DownloadFileAsync("FileC");
            await Task.WhenAll(task1, task2, task3);
            var elapsed2 = (DateTime.Now - start2).TotalSeconds;
            Console.WriteLine($"Total time: {elapsed2:F2} seconds\n");

            Console.WriteLine("✨ Notice how parallel execution is faster!");
        }

        private static async Task DownloadFileAsync(string fileName)
        {
            Console.WriteLine($"📥 Downloading {fileName}...");
            await Task.Delay(1000); // Simulate download
            Console.WriteLine($"✅ {fileName} downloaded!");
        }
    }
}