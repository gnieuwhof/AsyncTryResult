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


    public sealed class TryGetResult<TSuccess, TFailed>
    {
        private TryGetResult()
        {
            this.Success = false;
        }

        private TryGetResult(TSuccess result)
        {
            this.Success = true;
            this.Result = result;
        }


        public bool Success { get; }

        public TSuccess Result { get; }
         
        public TFailed Error { get; private set; }


        public static TryGetResult<TSuccess, TFailed>
            Succeeded(TSuccess result)
        {
            var tryGetResult = new TryGetResult<TSuccess, TFailed>(result);

            return tryGetResult;
        }

        public static TryGetResult<TSuccess, TFailed> Failed(TFailed error)
        {
            var tryGetResult = new TryGetResult<TSuccess, TFailed>()
            {
                Error = error
            };

            return tryGetResult;
        }
    }
}
