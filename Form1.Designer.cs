using System;

namespace TourismAgency
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.OrderCodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TourNameTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TicketsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TicketPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DiscountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.RegularTourRadioButton = new System.Windows.Forms.RadioButton();
            this.HotTourRadioButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.HotTourFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderCodeLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.TourNameLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.DepartureDateLabel = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.TicketsCountLabel = new System.Windows.Forms.Label();
            this.TicketPriceLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderCodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderCodeNumericUpDown
            // 
            this.OrderCodeNumericUpDown.Location = new System.Drawing.Point(150, 20);
            this.OrderCodeNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.OrderCodeNumericUpDown.Name = "OrderCodeNumericUpDown";
            this.OrderCodeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.OrderCodeNumericUpDown.TabIndex = 0;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(150, 50);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.CustomerNameTextBox.TabIndex = 1;
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.Location = new System.Drawing.Point(150, 80);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(200, 20);
            this.OrderDatePicker.TabIndex = 2;
            // 
            // TourNameTextBox
            // 
            this.TourNameTextBox.Location = new System.Drawing.Point(150, 110);
            this.TourNameTextBox.Name = "TourNameTextBox";
            this.TourNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.TourNameTextBox.TabIndex = 3;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(150, 140);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(200, 20);
            this.CountryTextBox.TabIndex = 4;
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.Location = new System.Drawing.Point(150, 170);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.Size = new System.Drawing.Size(200, 20);
            this.DepartureDatePicker.TabIndex = 5;
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.Location = new System.Drawing.Point(150, 200);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ReturnDatePicker.TabIndex = 6;
            // 
            // TicketsCountNumericUpDown
            // 
            this.TicketsCountNumericUpDown.Location = new System.Drawing.Point(150, 230);
            this.TicketsCountNumericUpDown.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.TicketsCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.TicketsCountNumericUpDown.Name = "TicketsCountNumericUpDown";
            this.TicketsCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.TicketsCountNumericUpDown.TabIndex = 7;
            this.TicketsCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TicketPriceNumericUpDown
            // 
            this.TicketPriceNumericUpDown.Location = new System.Drawing.Point(150, 260);
            this.TicketPriceNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.TicketPriceNumericUpDown.Name = "TicketPriceNumericUpDown";
            this.TicketPriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.TicketPriceNumericUpDown.TabIndex = 8;
            // 
            // DiscountNumericUpDown
            // 
            this.DiscountNumericUpDown.Location = new System.Drawing.Point(150, 290);
            this.DiscountNumericUpDown.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.DiscountNumericUpDown.Name = "DiscountNumericUpDown";
            this.DiscountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DiscountNumericUpDown.TabIndex = 9;
            this.DiscountNumericUpDown.Visible = false;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(150, 320);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(120, 20);
            this.CostTextBox.TabIndex = 10;
            // 
            // RegularTourRadioButton
            // 
            this.RegularTourRadioButton.AutoSize = true;
            this.RegularTourRadioButton.Checked = true;
            this.RegularTourRadioButton.Location = new System.Drawing.Point(150, 350);
            this.RegularTourRadioButton.Name = "RegularTourRadioButton";
            this.RegularTourRadioButton.Size = new System.Drawing.Size(85, 17);
            this.RegularTourRadioButton.TabIndex = 11;
            this.RegularTourRadioButton.TabStop = true;
            this.RegularTourRadioButton.Text = "Звичайний тур";
            this.RegularTourRadioButton.CheckedChanged += new System.EventHandler(this.RegularTourRadioButton_CheckedChanged);
            // 
            // HotTourRadioButton
            // 
            this.HotTourRadioButton.AutoSize = true;
            this.HotTourRadioButton.Location = new System.Drawing.Point(250, 350);
            this.HotTourRadioButton.Name = "HotTourRadioButton";
            this.HotTourRadioButton.Size = new System.Drawing.Size(85, 17);
            this.HotTourRadioButton.TabIndex = 12;
            this.HotTourRadioButton.Text = "Гарячий тур";
            this.HotTourRadioButton.CheckedChanged += new System.EventHandler(this.HotTourRadioButton_CheckedChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(20, 380);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(110, 380);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Редагувати";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(200, 380);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(20, 410);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 16;
            this.FirstButton.Text = "Перший";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(110, 410);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(75, 23);
            this.LastButton.TabIndex = 17;
            this.LastButton.Text = "Останній";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(200, 410);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 18;
            this.NextButton.Text = "Наступний";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(290, 410);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 19;
            this.PrevButton.Text = "Попередній";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.Location = new System.Drawing.Point(400, 20);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(300, 316);
            this.OrdersListBox.TabIndex = 20;
            this.OrdersListBox.SelectedIndexChanged += new System.EventHandler(this.OrdersListBox_SelectedIndexChanged);
            // 
            // HotTourFilterCheckBox
            // 
            this.HotTourFilterCheckBox.AutoSize = true;
            this.HotTourFilterCheckBox.Location = new System.Drawing.Point(400, 350);
            this.HotTourFilterCheckBox.Name = "HotTourFilterCheckBox";
            this.HotTourFilterCheckBox.Size = new System.Drawing.Size(120, 17);
            this.HotTourFilterCheckBox.TabIndex = 21;
            this.HotTourFilterCheckBox.Text = "Показати гарячі тури";
            this.HotTourFilterCheckBox.UseVisualStyleBackColor = true;
            this.HotTourFilterCheckBox.CheckedChanged += new System.EventHandler(this.HotTourFilterCheckBox_CheckedChanged);
            // 
            // OrderCodeLabel
            // 
            this.OrderCodeLabel.AutoSize = true;
            this.OrderCodeLabel.Location = new System.Drawing.Point(20, 20);
            this.OrderCodeLabel.Name = "OrderCodeLabel";
            this.OrderCodeLabel.Size = new System.Drawing.Size(80, 13);
            this.OrderCodeLabel.TabIndex = 22;
            this.OrderCodeLabel.Text = "Код замовлення:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(20, 50);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(80, 13);
            this.CustomerNameLabel.TabIndex = 23;
            this.CustomerNameLabel.Text = "ПІБ замовника:";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(20, 80);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(80, 13);
            this.OrderDateLabel.TabIndex = 24;
            this.OrderDateLabel.Text = "Дата замовлення:";
            // 
            // TourNameLabel
            // 
            this.TourNameLabel.AutoSize = true;
            this.TourNameLabel.Location = new System.Drawing.Point(20, 110);
            this.TourNameLabel.Name = "TourNameLabel";
            this.TourNameLabel.Size = new System.Drawing.Size(80, 13);
            this.TourNameLabel.TabIndex = 25;
            this.TourNameLabel.Text = "Назва туру:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(20, 140);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(80, 13);
            this.CountryLabel.TabIndex = 26;
            this.CountryLabel.Text = "Країна:";
            // 
            // DepartureDateLabel
            // 
            this.DepartureDateLabel.AutoSize = true;
            this.DepartureDateLabel.Location = new System.Drawing.Point(20, 170);
            this.DepartureDateLabel.Name = "DepartureDateLabel";
            this.DepartureDateLabel.Size = new System.Drawing.Size(80, 13);
            this.DepartureDateLabel.TabIndex = 27;
            this.DepartureDateLabel.Text = "Дата від’їзду:";
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Location = new System.Drawing.Point(20, 200);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(80, 13);
            this.ReturnDateLabel.TabIndex = 28;
            this.ReturnDateLabel.Text = "Дата повернення:";
            // 
            // TicketsCountLabel
            // 
            this.TicketsCountLabel.AutoSize = true;
            this.TicketsCountLabel.Location = new System.Drawing.Point(20, 230);
            this.TicketsCountLabel.Name = "TicketsCountLabel";
            this.TicketsCountLabel.Size = new System.Drawing.Size(80, 13);
            this.TicketsCountLabel.TabIndex = 29;
            this.TicketsCountLabel.Text = "Кількість путівок:";
            // 
            // TicketPriceLabel
            // 
            this.TicketPriceLabel.AutoSize = true;
            this.TicketPriceLabel.Location = new System.Drawing.Point(20, 260);
            this.TicketPriceLabel.Name = "TicketPriceLabel";
            this.TicketPriceLabel.Size = new System.Drawing.Size(80, 13);
            this.TicketPriceLabel.TabIndex = 30;
            this.TicketPriceLabel.Text = "Вартість путівки:";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(20, 290);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(80, 13);
            this.DiscountLabel.TabIndex = 31;
            this.DiscountLabel.Text = "Знижка (%):";
            this.DiscountLabel.Visible = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(20, 320);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(80, 13);
            this.CostLabel.TabIndex = 32;
            this.CostLabel.Text = "Загальна вартість:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.TicketPriceLabel);
            this.Controls.Add(this.TicketsCountLabel);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.DepartureDateLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.TourNameLabel);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.OrderCodeLabel);
            this.Controls.Add(this.HotTourFilterCheckBox);
            this.Controls.Add(this.OrdersListBox);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HotTourRadioButton);
            this.Controls.Add(this.RegularTourRadioButton);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.DiscountNumericUpDown);
            this.Controls.Add(this.TicketPriceNumericUpDown);
            this.Controls.Add(this.TicketsCountNumericUpDown);
            this.Controls.Add(this.ReturnDatePicker);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.TourNameTextBox);
            this.Controls.Add(this.OrderDatePicker);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.OrderCodeNumericUpDown);
            this.Name = "Form1";
            this.Text = "Туристична агенція";
            ((System.ComponentModel.ISupportInitialize)(this.OrderCodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown OrderCodeNumericUpDown;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.DateTimePicker OrderDatePicker;
        private System.Windows.Forms.TextBox TourNameTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.DateTimePicker DepartureDatePicker;
        private System.Windows.Forms.DateTimePicker ReturnDatePicker;
        private System.Windows.Forms.NumericUpDown TicketsCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown TicketPriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown DiscountNumericUpDown;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.RadioButton RegularTourRadioButton;
        private System.Windows.Forms.RadioButton HotTourRadioButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.CheckBox HotTourFilterCheckBox;
        private System.Windows.Forms.Label OrderCodeLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label TourNameLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label DepartureDateLabel;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Label TicketsCountLabel;
        private System.Windows.Forms.Label TicketPriceLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label CostLabel;

        private void RegularTourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DiscountLabel.Visible = false;
            DiscountNumericUpDown.Visible = false;
        }

        private void HotTourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DiscountLabel.Visible = true;
            DiscountNumericUpDown.Visible = true;
        }
    }
}