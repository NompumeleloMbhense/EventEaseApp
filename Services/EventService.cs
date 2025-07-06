using System;
using System.Collections;
using System.Linq;
using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<EventModel> _events = new();
        private int _nextId = 1;

        public EventService()
        {
            _events.Add(new EventModel { Id = _nextId++, Name = "Tech Conference", Date = new DateTime(2025, 6, 15), Location = "Cape Town" });
            _events.Add(new EventModel { Id = _nextId++, Name = "Art Festival", Date = new DateTime(2025, 7, 20), Location = "Johannesburg" });
        }

        public List<EventModel> GetEvents() => _events;

        public EventModel? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);

        public void AddEvent(EventModel newEvent)
        {
            newEvent.Id = _events.Max(e => e.Id) + 1;
            _events.Add(newEvent);
        }

        public void UpdateEvent(EventModel updatedEvent)
        {
            var existing = _events.FirstOrDefault(e => e.Id == updatedEvent.Id);
            if (existing != null)
            {
                existing.Name = updatedEvent.Name;
                existing.Date = updatedEvent.Date;
                existing.Location = updatedEvent.Location;
            }
        }

        public void DeleteEvent(int id)
        {
            var toDelete = _events.FirstOrDefault(e => e.Id == id);

            if (toDelete != null)
            {
                _events.Remove(toDelete);
            }
        }
    }
}