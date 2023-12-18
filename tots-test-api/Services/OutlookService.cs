using tots_test_api.DTOS;
using tots_test_api.Interfaces;
using tots_tests_app.Entities;

namespace tots_test_api.Services
{
    public class OutlookService : IOutlookService
    {
        Task<Event> IOutlookService.CreateEvent(CreateEventDto eventDto)
        {
            throw new NotImplementedException();
        }

        Task IOutlookService.DeleteEvent(string eventId)
        {
            throw new NotImplementedException();
        }

        Task<List<Event>> IOutlookService.ListEvents()
        {
            throw new NotImplementedException();
        }

        Task<Event> IOutlookService.UpdateEvent(string eventId, UpdateEventDto eventDto)
        {
            throw new NotImplementedException();
        }
    }
}
