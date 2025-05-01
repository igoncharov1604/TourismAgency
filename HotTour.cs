using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency
{
    class HotTour : TourOrder
    {
        public int Discount { get; set; }

        public HotTour() : base()
        {
            IsHotTour = true;
            Discount = 0;
        }

        public HotTour(string[] data) : base(data)
        {
            IsHotTour = true;
            Discount = int.Parse(data[10]);
        }

        public override int CalculateCost()
        {
            int baseCost = TicketsCount * TicketPrice;
            return baseCost - (baseCost * Discount / 100);
        }

        public override string ToFile()
        {
            return base.ToFile() + $";{Discount}";
        }

        public override string ToString()
        {
            return base.ToString() + $"Знижка: {Discount}%\nЗагальна вартість: {CalculateCost()}\n";
        }
    }
}
