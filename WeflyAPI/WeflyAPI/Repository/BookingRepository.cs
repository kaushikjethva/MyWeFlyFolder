using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeflyAPI.Models;
using Microsoft.EntityFrameworkCore;
using WeflyAPI.Infrastructure;

namespace WeflyAPI.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private clsWeflyDbContext dbContext;

        public BookingRepository(clsWeflyDbContext _db)
        {
            this.dbContext = _db;
        }

        public clsBookingDetails saveBookingDetails(clsBookingDetails clsBookingDetails)
        {
            clsBookingDetails.Id = "CUSTMR-" + RandomNumber(1,1000000);
            dbContext.tblBookingDetails.Add(clsBookingDetails);
            dbContext.SaveChanges();
            return clsBookingDetails;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
