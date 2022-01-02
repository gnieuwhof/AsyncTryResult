namespace AsyncTryResult
{
    public sealed class TryGetResult<T>
    {
        public bool Success { get; }

        public T Result { get; }


        private TryGetResult()
        {
            this.Success = false;
        }

        private TryGetResult(T result)
        {
            this.Success = true;
            this.Result = result;
        }


        public static TryGetResult<T> Succeeded(T result)
        {
            var tryGetResult = new TryGetResult<T>(result);

            return tryGetResult;
        }

        public static TryGetResult<T> Failed()
        {
            var tryGetResult = new TryGetResult<T>();

            return tryGetResult;
        }
    }
}
