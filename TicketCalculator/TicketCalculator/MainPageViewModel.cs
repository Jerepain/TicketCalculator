using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace TicketCalculator
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            this.ComputeCommand = new Command(this.Compute);
        }
        private decimal ticketValue;

        public decimal TicketValue
        {
            get
            {
                return ticketValue;
            }
            set
            {
                if (this.ticketValue != value)
                {
                    this.ticketValue = value;
                    this.NotifyPropertyChanged("TicketValue");
                }
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    this.NotifyPropertyChanged("Price");
                }
            }
        }

        private decimal ticketsNumber;
        public decimal TicketsNumber
        {
            get { return this.ticketsNumber; }
            set
            {
                if (this.ticketsNumber != value)
                {
                    this.ticketsNumber = value;
                    this.NotifyPropertyChanged("TicketsNumber");
                }
            }
        }


        private decimal reste;

        public decimal Reste
        {
            get
            {
                return this.reste;
            }
            set
            {
                if (this.reste != value)
                {
                    this.reste = value;
                    NotifyPropertyChanged("Reste");
                }
            }
        }
        
        public ICommand ComputeCommand { protected set; get; }

        protected virtual void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        private void Compute()
        {
            if (this.TicketValue == 0) return;
            var number = Math.Truncate(this.Price/this.TicketValue);
            this.TicketsNumber = number;
            this.Reste = this.Price - number * this.TicketValue;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
