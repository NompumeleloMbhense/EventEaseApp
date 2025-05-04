namespace EventEaseApp.Services
{
    public class UserSessionState
    {
        public string UserName{ get; set;}
        public string Email{get; set;}

        public int RegisteredEventId{get; set;}

        public void ClearSessions()
        {
            UserName = null;
            Email = null;
            RegisteredEventId = 0;
        }
    }
}