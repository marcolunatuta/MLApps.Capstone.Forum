namespace MLApps.Capstone.Forum.Application.Dto
{
    public class ResponseApplication<T> : ResponseApplication
    {
        public T? Data { get; set; }

        public static ResponseApplication<T?> Success(string message, IList<string>? messages = null, T? data = default)
        {
            return new ResponseApplication<T?>
            {
                IsSuccess = true,
                Message = message,
                Messages = messages,
                Data = data
            };
        }

        public static ResponseApplication<T> Fail(string message, IList<string>? messages = null, T? data = default)
        {
            return new ResponseApplication<T>
            {
                Message = message,
                Messages = messages,
                Data = data
            };
        }
    }

    public class ResponseApplication
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }

        public IList<string>? Messages { get; set; }

        public static ResponseApplication Success(string message, IList<string>? messages = null)
        {
            return new ResponseApplication
            {
                IsSuccess = true,
                Message = message,
                Messages = messages
            };
        }

        public static ResponseApplication Fail(string message, IList<string>? messages = null)
        {
            return new ResponseApplication
            {
                Message = message,
                Messages = messages
            };
        }
    }
}