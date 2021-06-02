using GoogleTimeZoneAPI.Models;

namespace GoogleTimeZoneAPI.Services
{
    public interface IGoogleAPIRequestHistoryService
    {
        void Insert(RequestHistoryModel requestHistoryModel);
    }
}