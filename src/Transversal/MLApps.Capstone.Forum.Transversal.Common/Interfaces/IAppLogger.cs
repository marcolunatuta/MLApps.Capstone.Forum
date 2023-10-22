namespace MLApps.Capstone.Forum.Transversal.Common.Interfaces
{
    public interface IAppLogger<TClass>
    {
        void LogInformation(string message);

        void LogError(Exception ex, string message);

        void LogWarning(string message);

        void LogDebug(string message);

        void LogTrace(string message);
    }
}