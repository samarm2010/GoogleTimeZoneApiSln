using EFDataAccessLibrary.DataAccess;
using GoogleTimeZoneAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleTimeZoneAPI.Services
{
    public class GoogleAPIRequestHistoryService : IGoogleAPIRequestHistoryService
    {
        private readonly DatabaseContext _dbContext;

        public GoogleAPIRequestHistoryService(DatabaseContext context)
        {
            _dbContext = context;
        }

        public void Insert(RequestHistoryModel requestHistoryModel)
        {
            _dbContext.Set<RequestHistoryModel>().Add(requestHistoryModel);

            _dbContext.SaveChanges();
        }
    }
}
