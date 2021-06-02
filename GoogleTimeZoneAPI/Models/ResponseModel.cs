using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleTimeZoneAPI.Models
{
    public class ResponseModel
    {
        public int dstOffset { get; set; }
        public int rawOffset { get; set; }
        public string status { get; set; }
        public string timeZoneId { get; set; }
        public string timeZoneName { get; set; }
        public string errorMessage { get; set; }
    }

}
