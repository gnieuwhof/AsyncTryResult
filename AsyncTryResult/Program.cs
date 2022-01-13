namespace AsyncTryResult
{
    using System;
    using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            Main().GetAwaiter().GetResult();

            Console.ReadKey();
        }

        //private static async Task Main()
        //{
        //    TryGetResult<string> result = await TryGetString1();

        //    if (result.Success)
        //    {
        //        Console.WriteLine(result.Result);
        //    }
        //    else
        //    {
        //        Console.WriteLine("TryGetString failed!");
        //    }
        //}

        //private static async Task<TryGetResult<string>> TryGetString1()
        //{
        //    // Simulate slow operation...
        //    await Task.Delay(100);

        //    var random = new Random(Guid.NewGuid().GetHashCode());

        //    TryGetResult<string> tryGetResult;

        //    // We only succeed half of the time.
        //    if (random.Next(2) == 1)
        //    {
        //        tryGetResult = TryGetResult<string>.Succeeded("Hello, World!");

        //        return tryGetResult;
        //    }

        //    tryGetResult = TryGetResult<string>.Failed();

        //    return tryGetResult;
        //}

        private static async Task Main()
        {
            TryGetResult<string, string> result = await TryGetString2();

            if (result.Success)
            {
                Console.WriteLine(result.Result);
            }
            else
            {
                Console.WriteLine(result.Error);
            }
        }

        private static async Task<TryGetResult<string, string>> TryGetString2()
        {
            // Simulate slow operation...
            await Task.Delay(100);

            var random = new Random(Guid.NewGuid().GetHashCode());

            TryGetResult<string, string> tryGetResult;

            // We only succeed half of the time.
            if (random.Next(2) == 1)
            {
                tryGetResult = TryGetResult<string, string>
                    .Succeeded("Hello, World!");

                return tryGetResult;
            }

            tryGetResult = TryGetResult<string, string>
                .Failed("TryGetString failed!");

            return tryGetResult;
        }
    }
}
