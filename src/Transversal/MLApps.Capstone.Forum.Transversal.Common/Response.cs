namespace MLApps.Capstone.Forum.Transversal.Common
{
    public class Response<T> : Response
    {
        public T? Data { get; set; }

        public static Response<T?> Success(string message, IList<string>? messages = null, T? data = default)
        {
            return new Response<T?>
            {
                IsSuccess = true,
                Message = message,
                Messages = messages,
                Data = data
            };
        }

        public static Response<T> Fail(string message, IList<string>? messages = null, T? data = default)
        {
            return new Response<T>
            {
                Message = message,
                Messages = messages,
                Data = data
            };
        }
    }

    public class Response
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }

        public IList<string>? Messages { get; set; }

        public static Response Success(string message, IList<string>? messages = null)
        {
            return new Response
            {
                IsSuccess = true,
                Message = message,
                Messages = messages
            };
        }

        public static Response Fail(string message, IList<string>? messages = null)
        {
            return new Response
            {
                Message = message,
                Messages = messages
            };
        }
    }
}