using System;
using System.ComponentModel;
using System.Windows.Input;
using TicketCalculator.Helpers;
using Xamarin.Forms;

namespace TicketCalculator
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            this.ComputeCommand = new Command(this.Compute);
            this.TicketValue = Settings.TicketValue;
        }

        private double ticketValue;
        public double TicketValue
        {
            get { return this.ticketValue; }
            set
            {
                if (this.ticketValue != value)
                {
                    Settings.TicketValue = this.ticketValue = value;
                    this.NotifyPropertyChanged("TicketValue");
                }
            }
        }

        private double price;
        public double Price
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

        private double ticketsNumber;
        public double TicketsNumber
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


        private double reste;

        public double Reste
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
            if ((int)this.TicketValue <= 0) return;
            this.TicketsNumber = Math.Truncate(this.Price / this.TicketValue);
            var ticketsValue = this.TicketsNumber * this.TicketValue;

            double r = this.Price - ticketsValue;
            this.Reste = Math.Round(r, 2);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
