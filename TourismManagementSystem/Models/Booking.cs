public class Booking
{
    public int Id { get; set; }  
    public int TouristId { get; set; }  
    public Tourist Tourist { get; set; }  

    public int TourId { get; set; }  
    public Tour Tour { get; set; } 

    public DateTime BookingDate { get; set; } 
    public BookingStatus Status { get; set; }  
}

public enum BookingStatus
{
    Pending,
    Confirmed,
    Cancelled
}
