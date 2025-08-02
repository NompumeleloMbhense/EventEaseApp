using System;
using System.Collections;
using System.Linq;
using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private List<EventModel> _events = new()
        {
            new EventModel { Id = 1, Name = "Tech Conference", Date = new(2025, 6, 15), Location = "Cape Town", Description = "Join top minds in tech for talks and networking", Tags = new() { "Tech", "Conference", "Innovation" }, Category = "Technology" },
            new EventModel { Id = 2, Name = "Art Festival", Date = new(2025, 7, 20), Location = "Johannesburg", Description = "Experience creativity in bloom and connect with visionary artists", Tags = new() { "Art", "Showcase", "Exhibition"}, Category = "Art" },
            new EventModel { Id = 3, Name = "Swan Lake", Date = new(2025, 8, 9), Location = "Durban", Description = "Experience the magic of Swan Lake. Witness breathtaking ballet, enchanting music and a timeless tale of love", Tags = new() { "Ballet", "Dance", "Play"}, Category = "Theatre" },
            new EventModel { Id = 4, Name = "Design Expo", Date = DateTime.Now.AddDays(20), Location = "Pretoria" },
            new EventModel { Id = 5, Name = "Startup Grind", Date = DateTime.Now.AddDays(30), Location = "Cape Town" },
            new EventModel { Id = 6, Name = "Food & Wine Fest", Date = DateTime.Now.AddDays(40), Location = "Stellenbosch" }
        };
        

        
        public List<EventModel> GetAllEvents() => _events;

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