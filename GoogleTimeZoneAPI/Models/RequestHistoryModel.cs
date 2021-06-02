using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleTimeZoneAPI.Models
{
    public class RequestHistoryModel
    {
        public int Id { get; set; }
        public string RequestLocation { get; set; }
        public string RequestTimeStamp { get; set; }
        public int ResponseDstOffset { get; set; }
        public int ResponseRawOffset { get; set; }
        public string ResponseStatus { get; set; }
        public string ResponseTimeZoneId { get; set; }
        public string ResponseTimeZoneName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
