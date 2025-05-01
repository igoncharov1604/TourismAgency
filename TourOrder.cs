using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TourismAgency
{
    abstract class TourOrder
    {
        public int OrderCode { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string TourName { get; set; }
        public string Country { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int TicketsCount { get; set; }
        public int TicketPrice { get; set; }
        public bool IsHotTour { get; set; }

        public TourOrder()
        {
            OrderCode = -1;
            CustomerName = "none";
            TourName = "none";
            Country = "none";
            TicketsCount = 0;
            TicketPrice = 0;
            IsHotTour = false;
        }

        public TourOrder(string[] data)
        {
            OrderCode = int.Parse(data[0]);
            CustomerName = data[1];
            OrderDate = DateTime.Parse(data[2]);
            TourName = data[3];
            Country = data[4];
            DepartureDate = DateTime.Parse(data[5]);
            ReturnDate = DateTime.Parse(data[6]);
            TicketsCount = int.Parse(data[7]);
            TicketPrice = int.Parse(data[8]);
            IsHotTour = bool.Parse(data[9]);
        }

        public virtual int CalculateCost()
        {
            return 0;
        }

        public virtual string ToFile()
        {
            return $"{OrderCode};{CustomerName};{OrderDate:yyyy-MM-dd};{TourName};{Country};{DepartureDate:yyyy-MM-dd};{ReturnDate:yyyy-MM-dd};{TicketsCount};{TicketPrice};{IsHotTour}";
        }

        public override string ToString()
        {
            return $"Код: {OrderCode}\nЗамовник: {CustomerName}\nДата замовлення: {OrderDate:yyyy-MM-dd}\nТур: {TourName}\nКраїна: {Country}\nВід’їзд: {DepartureDate:yyyy-MM-dd}\nПовернення: {ReturnDate:yyyy-MM-dd}\nКількість путівок: {TicketsCount}\nВартість путівки: {TicketPrice}\nТип туру: {(IsHotTour ? "Гарячий" : "Звичайний")}\n";
        }

        public string ToListBox()
        {
            return $"{OrderCode}: {CustomerName} - {TourName}";
        }
    }
}