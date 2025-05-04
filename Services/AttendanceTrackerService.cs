using EventEaseApp.Models;
using EventEaseApp.Services;

namespace EventEaseApp.Services
{
    public class AttendanceTrackerService
    {
        private readonly List<AttendanceRecord> _attendanceRecords = new();

        public void RegisterAttendance(int eventId, string UserName, string email)
        {
            if(!_attendanceRecords.Any(a => a.EventId == eventId && a.Email == email))
            {
                _attendanceRecords.Add(new AttendanceRecord
                {
                    EventId = eventId,
                    UserName = UserName,
                    Email = email
                });
            }
        }

        public List<AttendanceRecord> GetAttendeesForEvent(int eventId)
        {
            return _attendanceRecords.Where(a => a.EventId == eventId).ToList();
        }
    }
}