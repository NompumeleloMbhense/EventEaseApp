namespace EventEaseApp.Services
{
    public class AdminState
    {
        public bool IsLoggedIn { get; set; } = false;

        public void Login(string password)
        {
            // Hard coded password
            if (password == "admin123")
            {
                IsLoggedIn = true;
            }

        }

        public void Logout()
        {
            IsLoggedIn = false;
        }
    }
}