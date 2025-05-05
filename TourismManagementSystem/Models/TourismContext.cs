using Microsoft.EntityFrameworkCore;

public class TourismContext : DbContext
{
    public TourismContext(DbContextOptions<TourismContext> options) : base(options) { }

    public DbSet<Tourist> Tourists { get; set; }
    public DbSet<Tour> Tours { get; set; }
    public DbSet<Booking> Bookings { get; set; }
}
