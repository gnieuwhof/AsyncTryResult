namespace AsyncTryResult
{
    public class TryGetResult<T>
    {
        public bool Success { get; }

        public T Result { get; set; }


        private TryGetResult(bool success)
        {
            this.Success = success;
        }


        public static TryGetResult<T> Succeeded(T result)
        {
            var tryGetResult = new TryGetResult<T>(true)
            {
                Result = result
            };

            return tryGetResult;
        }

        public static TryGetResult<T> Failed()
        {
            var tryGetResult = new TryGetResult<T>(false);

            return tryGetResult;
        }
    }
}
