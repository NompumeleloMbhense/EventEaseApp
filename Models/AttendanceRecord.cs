namespace EventEaseApp.Models
{
    public class AttendanceRecord
    {
        public int EventId {get; set;}
        public string UserName {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
    }
}