using Microsoft.Extensions.Logging;
using tots_test_api.DTOS;
using tots_tests_app.Entities;

namespace tots_test_api.Interfaces
{
    public interface IOutlookService
    {
        Task<Event> CreateEvent(CreateEventDto eventDto);
        Task<Event> UpdateEvent(string eventId, UpdateEventDto eventDto);
        Task<List<Event>> ListEvents();
        Task DeleteEvent(string eventId);
    }

}
