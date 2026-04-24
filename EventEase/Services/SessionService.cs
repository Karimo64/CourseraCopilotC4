using System;

namespace EventEase.Services
{
    // Simple session tracker to store user info
    public class SessionService
    {
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public DateTime SessionStart { get; private set; } = DateTime.Now;

        public bool IsLoggedIn => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(UserEmail);

        public void StartSession(string name, string email)
        {
            UserName = name;
            UserEmail = email;
            SessionStart = DateTime.Now;
        }

        public void EndSession()
        {
            UserName = null;
            UserEmail = null;
        }
    }
}