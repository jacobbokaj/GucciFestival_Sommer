namespace GucciFestival.Client.Services
{
    public interface ICoordinatorService
    {
        Task<Booking[]?> GetAllBookings();
        Task<int> AddBooking(Booking booking);
    }

}
