using GoogleTimeZoneAPI.API;
using GoogleTimeZoneAPI.Models;
using GoogleTimeZoneAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GoogleTimeZoneAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeZoneController : ControllerBase
    {
        private readonly IGoogleAPI _googleAPI;
        private readonly IGoogleAPIRequestHistoryService _googleAPIRequestHistoryService;

        public TimeZoneController(IGoogleAPI googleAPI, IGoogleAPIRequestHistoryService googleAPIRequestHistoryService)
        {
            _googleAPIRequestHistoryService = googleAPIRequestHistoryService;
            _googleAPI = googleAPI;
        }

        /// <summary>
        /// This end point will return TimeZone and Day light informaiton using Google Time Zone API.
        /// </summary>
        /// <param name="location">Pass Location</param>
        /// <param name="timestamp">Pass Timestamp</param>
        /// <returns>TimeZoneId, TimeZoneName, DstOffset, RawOffset, Status</returns>
        [HttpGet("location={location}&timestamp={timestamp}")]           
        public async Task<IActionResult> Get(string location, string timestamp)
        {
            // Google API
            ResponseModel responseModel = await _googleAPI.GetLocationTimeStamp(location, timestamp);

            if (!string.IsNullOrEmpty(responseModel.errorMessage))
            {
                return BadRequest(responseModel);
            }
            else
            {
                RequestHistoryModel requestHistoryModel = new RequestHistoryModel()
                {
                    RequestLocation = location,
                    RequestTimeStamp = timestamp,
                    ResponseDstOffset = responseModel.dstOffset,
                    ResponseRawOffset = responseModel.rawOffset,
                    ResponseStatus = responseModel.status,
                    ResponseTimeZoneId = responseModel.timeZoneId,
                    ResponseTimeZoneName = responseModel.timeZoneName,
                    CreatedDate = DateTime.Now
                };

                _googleAPIRequestHistoryService.Insert(requestHistoryModel);

                return Ok(responseModel);
            }
        }
    }

   
}
