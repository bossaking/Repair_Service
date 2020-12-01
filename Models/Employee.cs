using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Employee : INotifyPropertyChanged
    {
        public virtual int Id_Employee { get; set; }
        private string name;
        public virtual string Name { get { return name; } set { name = value; OnPropertyChanged("Name"); } }
        public virtual string Surname { get; set; }
        public virtual Salon Employee_Salon { get; set; }
        public virtual Role Employee_Role { get; set; }
        public virtual string Login { get; set; }
        public virtual string Passwd { get; set; }
        public virtual IList<Order> Orders { get; set; }

        public virtual event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
