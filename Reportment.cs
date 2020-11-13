using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service
{
    public class Reportment : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string ModelTitle { get; set; }
        public string Type { get; set; }
        public string OrderDate { get; set; }
        public string Status { get; set; }

        public Reportment() { }

        public Reportment(int Id, string Name, string PhoneNumber, string ModelTitle, string Type, string OrderDate, string Status)
        {
            this.Id = Id;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.ModelTitle = ModelTitle;
            this.Type = Type;
            this.OrderDate = OrderDate;
            this.Status = Status;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
