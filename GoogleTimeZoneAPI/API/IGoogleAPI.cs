using GoogleTimeZoneAPI.Models;
using System.Threading.Tasks;

namespace GoogleTimeZoneAPI.API
{
    public interface IGoogleAPI
    {
        Task<ResponseModel> GetLocationTimeStamp(string location, string timestamp);
    }
}