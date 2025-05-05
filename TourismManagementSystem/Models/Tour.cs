public class Tour
{
    public int Id { get; set; }  // Unique identifier for the tour
    public string Name { get; set; }  // Name of the tour
    public string Description { get; set; }  // Description of the tour
    public decimal Price { get; set; }  // Price of the tour
    public int DurationInDays { get; set; }  // Duration of the tour in days
    public DateTime StartDate { get; set; }  // Start date of the tour
    public int MaxParticipants { get; set; }  // Maximum number of participants
}
