using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency
{
    class RegularTour : TourOrder
    {
        public RegularTour() : base()
        {
            IsHotTour = false;
        }

        public RegularTour(string[] data) : base(data)
        {
            IsHotTour = false;
        }

        public override int CalculateCost()
        {
            return TicketsCount * TicketPrice;
        }

        public override string ToString()
        {
            return base.ToString() + $"Загальна вартість: {CalculateCost()}\n";
        }
    }
}
