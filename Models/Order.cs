using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Order : INotifyPropertyChanged
    {
        public virtual int Id_Order { get; set; }
        private Client client;
        public virtual Client Client { get { return client; } set { client = value ?? throw new ArgumentException("The field cannot be empty"); OnPropertyChanged("Client"); } }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Device Device { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual DateTime Order_Date { get; set; }
        public virtual DateTime? Reception_Date { get; set; }
        public virtual Status Status { get; set; }
        public virtual IList<Problem> Problems { get; set; }

        public Order()
        {
            Client = new Client();
            Employee = new Employee();
            Device = new Device();
            Problems = new List<Problem>();
            Order_Date = DateTime.Now;
            Status = new Status();
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
