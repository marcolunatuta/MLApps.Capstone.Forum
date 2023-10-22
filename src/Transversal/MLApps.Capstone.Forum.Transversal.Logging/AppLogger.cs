using MLApps.Capstone.Forum.Transversal.Common.Interfaces;

namespace MLApps.Capstone.Forum.Transversal.Logging
{
    public class AppLogger<TClass> : IAppLogger<TClass>
    {
        public AppLogger()
        {
        }

        public void LogDebug(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception ex, string message)
        {
            throw new NotImplementedException();
        }

        public void LogInformation(string message)
        {
            throw new NotImplementedException();
        }

        public void LogTrace(string message)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}