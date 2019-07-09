using System;
using System.Text;

namespace CURSO_CSHARP_NELIO_ALVES
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if(checkOut <= checkIn)
                throw new DomainException("Error in reservation: Check-out date must be after Check-in date");
            
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
                throw new DomainException("Reservation dates for update must be future dates");
            if (checkOut <= checkIn)
                throw new DomainException("Check-out date must be after check-in date");

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Room ");
            sb.Append(RoomNumber);
            sb.Append(", Check-In: ");
            sb.Append(CheckIn.ToString("dd/MM/yyyy"));
            sb.Append(", Check-Out: ");
            sb.Append(CheckOut.ToString("dd/MM/yyyy"));
            sb.Append(", ");
            sb.Append(Duration());
            sb.Append(" nights");
            return sb.ToString();
        }
    }
}