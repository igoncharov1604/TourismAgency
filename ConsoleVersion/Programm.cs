using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency
{
    class Programm
    {
        static List<TourOrder> orders = new List<TourOrder>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            LoadData();
            while (true)
            {
                Console.WriteLine("1) Додати замовлення\n2) Редагувати замовлення\n3) Видалити замовлення\n4) Показати всі замовлення\n5) Показати гарячі тури\n6) Сортувати за вартістю\n7) Вихід");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1: AddOrder(); break;
                    case 2: EditOrder(); break;
                    case 3: DeleteOrder(); break;
                    case 4: ShowAllOrders(); break;
                    case 5: ShowHotTours(); break;
                    case 6: SortByCost(); break;
                    case 7: return;
                }
            }
        }

        static void LoadData()
        {
            if (!File.Exists("Tours.txt")) File.WriteAllText("Tours.txt", "");
            using (StreamReader sr = new StreamReader("Tours.txt", Encoding.UTF8))
            {
                string[] lines = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    if (bool.Parse(data[9]))
                        orders.Add(new HotTour(data));
                    else
                        orders.Add(new RegularTour(data));
                }
            }
        }

        static void AddOrder()
        {
            Console.WriteLine("Введіть код замовлення:");
            int orderCode = int.Parse(Console.ReadLine());
            if (orders.Any(o => o.OrderCode == orderCode))
            {
                Console.WriteLine("Замовлення з таким кодом уже існує!");
                ReturnToMenu();
                return;
            }
            Console.WriteLine("Введіть ПІБ замовника:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Введіть дату замовлення (рррр-мм-дд):");
            DateTime orderDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введіть назву туру:");
            string tourName = Console.ReadLine();
            Console.WriteLine("Введіть країну:");
            string country = Console.ReadLine();
            Console.WriteLine("Введіть дату від’їзду (рррр-мм-дд):");
            DateTime departureDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введіть дату повернення (рррр-мм-дд):");
            DateTime returnDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість путівок:");
            int ticketsCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть вартість однієї путівки:");
            int ticketPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Це гарячий тур? (1 - Так, 2 - Ні):");
            bool isHotTour = Console.ReadLine() == "1";
            int discount = 0;
            if (isHotTour)
            {
                Console.WriteLine("Введіть знижку (%):");
                discount = int.Parse(Console.ReadLine());
            }

            TourOrder order = isHotTour
                ? new HotTour { OrderCode = orderCode, CustomerName = customerName, OrderDate = orderDate, TourName = tourName, Country = country, DepartureDate = departureDate, ReturnDate = returnDate, TicketsCount = ticketsCount, TicketPrice = ticketPrice, IsHotTour = true, Discount = discount }
                : new RegularTour { OrderCode = orderCode, CustomerName = customerName, OrderDate = orderDate, TourName = tourName, Country = country, DepartureDate = departureDate, ReturnDate = returnDate, TicketsCount = ticketsCount, TicketPrice = ticketPrice, IsHotTour = false };

            orders.Add(order);
            using (StreamWriter sw = new StreamWriter("Tours.txt", true, Encoding.UTF8))
            {
                sw.WriteLine(order.ToFile());
            }
            Console.WriteLine("Замовлення додано!");
            ReturnToMenu();
        }

        static void EditOrder()
        {
            Console.WriteLine("Введіть код замовлення для редагування:");
            int code = int.Parse(Console.ReadLine());
            var order = orders.FirstOrDefault(o => o.OrderCode == code);
            if (order == null)
            {
                Console.WriteLine("Замовлення не знайдено!");
                ReturnToMenu();
                return;
            }

            Console.WriteLine("Введіть нові дані (залиште порожнім, щоб не змінювати):");
            Console.WriteLine("ПІБ замовника:");
            string customerName = Console.ReadLine();
            if (!string.IsNullOrEmpty(customerName)) order.CustomerName = customerName;

            Console.WriteLine("Дата замовлення (рррр-мм-дд):");
            string orderDateStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(orderDateStr)) order.OrderDate = DateTime.Parse(orderDateStr);

            Console.WriteLine("Назва туру:");
            string tourName = Console.ReadLine();
            if (!string.IsNullOrEmpty(tourName)) order.TourName = tourName;

            Console.WriteLine("Країна:");
            string country = Console.ReadLine();
            if (!string.IsNullOrEmpty(country)) order.Country = country;

            Console.WriteLine("Дата від’їзду (рррр-мм-дд):");
            string departureDateStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(departureDateStr)) order.DepartureDate = DateTime.Parse(departureDateStr);

            Console.WriteLine("Дата повернення (рррр-мм-дд):");
            string returnDateStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(returnDateStr)) order.ReturnDate = DateTime.Parse(returnDateStr);

            Console.WriteLine("Кількість путівок:");
            string ticketsCountStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(ticketsCountStr)) order.TicketsCount = int.Parse(ticketsCountStr);

            Console.WriteLine("Вартість однієї путівки:");
            string ticketPriceStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(ticketPriceStr)) order.TicketPrice = int.Parse(ticketPriceStr);

            if (order is HotTour hotTour)
            {
                Console.WriteLine("Знижка (%):");
                string discountStr = Console.ReadLine();
                if (!string.IsNullOrEmpty(discountStr)) hotTour.Discount = int.Parse(discountStr);
            }

            UpdateFile();
            Console.WriteLine("Замовлення відредаговано!");
            ReturnToMenu();
        }

        static void DeleteOrder()
        {
            Console.WriteLine("Введіть код замовлення для видалення:");
            int code = int.Parse(Console.ReadLine());
            var order = orders.FirstOrDefault(o => o.OrderCode == code);
            if (order == null)
            {
                Console.WriteLine("Замовлення не знайдено!");
                ReturnToMenu();
                return;
            }

            orders.Remove(order);
            UpdateFile();
            Console.WriteLine("Замовлення видалено!");
            ReturnToMenu();
        }

        static void ShowAllOrders()
        {
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
            ReturnToMenu();
        }

        static void ShowHotTours()
        {
            var hotTours = orders.Where(o => o.IsHotTour);
            foreach (var tour in hotTours)
            {
                Console.WriteLine(tour);
            }
            ReturnToMenu();
        }

        static void SortByCost()
        {
            var sortedOrders = orders.OrderByDescending(o => o.CalculateCost());
            foreach (var order in sortedOrders)
            {
                Console.WriteLine(order);
            }
            ReturnToMenu();
        }

        static void UpdateFile()
        {
            using (StreamWriter sw = new StreamWriter("Tours.txt", false, Encoding.UTF8))
            {
                foreach (var order in orders)
                {
                    sw.WriteLine(order.ToFile());
                }
            }
        }

        static void ReturnToMenu()
        {
            Console.WriteLine("Натисніть будь-яку клавішу, щоб повернутися до меню...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
