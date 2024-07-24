namespace YagniSimple;

public class Reservation
{
    public string CustomerName { get; set; }
    public DateTime ReservationDate { get; set; }
    public int NumberOfPeople { get; set; }

    public Reservation(string customerName, DateTime reservationDate, int numberOfPeople)
    {
        CustomerName = customerName;
        ReservationDate = reservationDate;
        NumberOfPeople = numberOfPeople;
    }
}
