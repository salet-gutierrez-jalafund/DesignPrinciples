namespace YagniComplex;

public class Reservation
{
    public string CustomerName { get; set; }

    public DateTime ReservationDate { get; set; }

    public int NumberOfPeople { get; set; }

    public string TableNumberPreference { get; set; } // Unnecessary functionality at this time
    
    public string SeatingPreference { get; set; } // Unnecessary functionality at this time

    public Reservation(string customerName, DateTime reservationDate, int numberOfPeople)
    {
        CustomerName = customerName;
        ReservationDate = reservationDate;
        NumberOfPeople = numberOfPeople;
        TableNumberPreference = "";
        SeatingPreference = "";
    }

    public void SetTableNumber(string tableNumber)
    {
        TableNumberPreference = tableNumber;
    }

    public void SetSeatingPreference(string preference)
    {
        SeatingPreference = preference;
    }
}
