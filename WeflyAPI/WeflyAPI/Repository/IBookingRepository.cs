using WeflyAPI.Models;

namespace WeflyAPI.Repository
{
    public interface IBookingRepository
    {
        clsBookingDetails saveBookingDetails(clsBookingDetails clsBookingDetails);
    }
}
