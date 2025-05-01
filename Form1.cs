using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismAgency
{
    public partial class Form1 : Form
    {
        private static LinkedList<TourOrder> orders = new LinkedList<TourOrder>();
        private static TourOrder currentOrder;
        private static int currentIndex;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            FirstButton_Click(null, null);
        }

        private void LoadData()
        {
            if (!File.Exists("Tours.txt")) File.WriteAllText("Tours.txt", "");
            using (StreamReader sr = new StreamReader("Tours.txt", Encoding.UTF8))
            {
                string[] lines = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    if (bool.Parse(data[9]))
                        orders.AddLast(new HotTour(data));
                    else
                        orders.AddLast(new RegularTour(data));
                }
            }
            UpdateListBox();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            int orderCode = (int)OrderCodeNumericUpDown.Value;
            if (orders.Any(o => o.OrderCode == orderCode))
            {
                MessageBox.Show("Замовлення з таким кодом уже існує!");
                return;
            }

            string customerName = CustomerNameTextBox.Text;
            DateTime orderDate = OrderDatePicker.Value;
            string tourName = TourNameTextBox.Text;
            string country = CountryTextBox.Text;
            DateTime departureDate = DepartureDatePicker.Value;
            DateTime returnDate = ReturnDatePicker.Value;
            int ticketsCount = (int)TicketsCountNumericUpDown.Value;
            int ticketPrice = (int)TicketPriceNumericUpDown.Value;
            bool isHotTour = HotTourRadioButton.Checked;
            int discount = isHotTour ? (int)DiscountNumericUpDown.Value : 0;

            TourOrder order = isHotTour
                ? new HotTour { OrderCode = orderCode, CustomerName = customerName, OrderDate = orderDate, TourName = tourName, Country = country, DepartureDate = departureDate, ReturnDate = returnDate, TicketsCount = ticketsCount, TicketPrice = ticketPrice, IsHotTour = true, Discount = discount }
                : new RegularTour { OrderCode = orderCode, CustomerName = customerName, OrderDate = orderDate, TourName = tourName, Country = country, DepartureDate = departureDate, ReturnDate = returnDate, TicketsCount = ticketsCount, TicketPrice = ticketPrice, IsHotTour = false };

            orders.AddLast(order);
            using (StreamWriter sw = new StreamWriter("Tours.txt", true, Encoding.UTF8))
            {
                sw.WriteLine(order.ToFile());
            }

            currentOrder = order;
            currentIndex = orders.Count - 1;
            UpdateListBox();
            ShowCurrentOrder();
            MessageBox.Show("Замовлення додано!");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (currentOrder == null) return;
            if (!ValidateInput()) return;

            int orderCode = (int)OrderCodeNumericUpDown.Value;
            if (orderCode != currentOrder.OrderCode && orders.Any(o => o.OrderCode == orderCode))
            {
                MessageBox.Show("Замовлення з таким кодом уже існує!");
                return;
            }

            currentOrder.OrderCode = orderCode;
            currentOrder.CustomerName = CustomerNameTextBox.Text;
            currentOrder.OrderDate = OrderDatePicker.Value;
            currentOrder.TourName = TourNameTextBox.Text;
            currentOrder.Country = CountryTextBox.Text;
            currentOrder.DepartureDate = DepartureDatePicker.Value;
            currentOrder.ReturnDate = ReturnDatePicker.Value;
            currentOrder.TicketsCount = (int)TicketsCountNumericUpDown.Value;
            currentOrder.TicketPrice = (int)TicketPriceNumericUpDown.Value;

            if (HotTourRadioButton.Checked && currentOrder is HotTour hotTour)
            {
                hotTour.Discount = (int)DiscountNumericUpDown.Value;
            }
            else if (RegularTourRadioButton.Checked && currentOrder is HotTour)
            {
                var newOrder = new RegularTour
                {
                    OrderCode = currentOrder.OrderCode,
                    CustomerName = currentOrder.CustomerName,
                    OrderDate = currentOrder.OrderDate,
                    TourName = currentOrder.TourName,
                    Country = currentOrder.Country,
                    DepartureDate = currentOrder.DepartureDate,
                    ReturnDate = currentOrder.ReturnDate,
                    TicketsCount = currentOrder.TicketsCount,
                    TicketPrice = currentOrder.TicketPrice,
                    IsHotTour = false
                };
                var node = orders.Find(currentOrder);
                orders.AddAfter(node, newOrder);
                orders.Remove(node);
                currentOrder = newOrder;
            }
            else if (HotTourRadioButton.Checked && currentOrder is RegularTour)
            {
                var newOrder = new HotTour
                {
                    OrderCode = currentOrder.OrderCode,
                    CustomerName = currentOrder.CustomerName,
                    OrderDate = currentOrder.OrderDate,
                    TourName = currentOrder.TourName,
                    Country = currentOrder.Country,
                    DepartureDate = currentOrder.DepartureDate,
                    ReturnDate = currentOrder.ReturnDate,
                    TicketsCount = currentOrder.TicketsCount,
                    TicketPrice = currentOrder.TicketPrice,
                    IsHotTour = true,
                    Discount = (int)DiscountNumericUpDown.Value
                };
                var node = orders.Find(currentOrder);
                orders.AddAfter(node, newOrder);
                orders.Remove(node);
                currentOrder = newOrder;
            }

            UpdateFile();
            UpdateListBox();
            ShowCurrentOrder();
            MessageBox.Show("Замовлення відредаговано!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (currentOrder == null) return;

            orders.Remove(currentOrder);
            UpdateFile();
            currentIndex = currentIndex <= orders.Count ? orders.Count - 1 : currentIndex;
            currentOrder = orders.ElementAtOrDefault(currentIndex);
            UpdateListBox();
            ShowCurrentOrder();
            MessageBox.Show("Замовлення видалено!");
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (FilterCheck(orders.ElementAt(i)))
                {
                    currentOrder = orders.ElementAt(i);
                    currentIndex = i;
                    break;
                }
            }
            ShowCurrentOrder();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            for (int i = orders.Count - 1; i >= 0; i--)
            {
                if (FilterCheck(orders.ElementAt(i)))
                {
                    currentOrder = orders.ElementAt(i);
                    currentIndex = i;
                    break;
                }
            }
            ShowCurrentOrder();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            for (int i = currentIndex + 1; i < orders.Count; i++)
            {
                if (FilterCheck(orders.ElementAt(i)))
                {
                    currentOrder = orders.ElementAt(i);
                    currentIndex = i;
                    break;
                }
            }
            ShowCurrentOrder();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                if (FilterCheck(orders.ElementAt(i)))
                {
                    currentOrder = orders.ElementAt(i);
                    currentIndex = i;
                    break;
                }
            }
            ShowCurrentOrder();
        }

        private void ShowCurrentOrder()
        {
            if (currentOrder == null)
            {
                ClearForm();
                return;
            }

            OrderCodeNumericUpDown.Value = currentOrder.OrderCode;
            CustomerNameTextBox.Text = currentOrder.CustomerName;
            OrderDatePicker.Value = currentOrder.OrderDate;
            TourNameTextBox.Text = currentOrder.TourName;
            CountryTextBox.Text = currentOrder.Country;
            DepartureDatePicker.Value = currentOrder.DepartureDate;
            ReturnDatePicker.Value = currentOrder.ReturnDate;
            TicketsCountNumericUpDown.Value = currentOrder.TicketsCount;
            TicketPriceNumericUpDown.Value = currentOrder.TicketPrice;
            CostTextBox.Text = currentOrder.CalculateCost().ToString();

            if (currentOrder is HotTour hotTour)
            {
                HotTourRadioButton.Checked = true;
                DiscountNumericUpDown.Value = hotTour.Discount;
                DiscountLabel.Visible = true;
                DiscountNumericUpDown.Visible = true;
            }
            else
            {
                RegularTourRadioButton.Checked = true;
                DiscountLabel.Visible = false;
                DiscountNumericUpDown.Visible = false;
            }

            OrdersListBox.SelectedIndex = orders.ToList().IndexOf(currentOrder);
        }

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersListBox.SelectedIndex == -1) return;
            var selectedOrder = orders.FirstOrDefault(o => o.ToListBox() == OrdersListBox.SelectedItem.ToString());
            if (selectedOrder != null)
            {
                currentOrder = selectedOrder;
                currentIndex = orders.ToList().IndexOf(selectedOrder);
                ShowCurrentOrder();
            }
        }

        private void HotTourFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            OrdersListBox.Items.Clear();
            foreach (var order in orders)
            {
                if (HotTourFilterCheckBox.Checked && !order.IsHotTour) continue;
                OrdersListBox.Items.Add(order.ToListBox());
            }
            if (!FilterCheck(currentOrder)) FirstButton_Click(null, null);
            ShowCurrentOrder();
        }

        private bool FilterCheck(TourOrder order)
        {
            if (order == null) return false;
            return !HotTourFilterCheckBox.Checked || order.IsHotTour;
        }

        private void UpdateFile()
        {
            using (StreamWriter sw = new StreamWriter("Tours.txt", false, Encoding.UTF8))
            {
                foreach (var order in orders)
                {
                    sw.WriteLine(order.ToFile());
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(CustomerNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(TourNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(CountryTextBox.Text))
            {
                MessageBox.Show("Заповніть усі обов’язкові поля!");
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            OrderCodeNumericUpDown.Value = 0;
            CustomerNameTextBox.Text = "";
            TourNameTextBox.Text = "";
            CountryTextBox.Text = "";
            TicketsCountNumericUpDown.Value = 1;
            TicketPriceNumericUpDown.Value = 0;
            DiscountNumericUpDown.Value = 0;
            CostTextBox.Text = "";
            RegularTourRadioButton.Checked = true;
        }
    }
}
