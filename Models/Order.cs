using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{

    public enum Status
    {
        Taken,
        Repairing,
        Ready,
        Returned
    }

    public enum Type
    {
        Phone,
        PC,
        Laptop
    }

    public class Order
    {

        public int Id { get; set; }
        public string MainProblem { get; set; }
        public string PhoneNumber { get; set; }
        public string OwnerName { get; set; }
        public string Description { get; set; }
        public int StartPrice { get; set; }
        public Type Type { get; set; }
        public DateTime TakenDate { get; set; }
        public DateTime ReturnedTime { get; set; }
        public Status Status { get; set; }


        public Order(string mainProblem, string phoneNumber, string ownerName, int startPrice, DateTime takenDate, Type type, Status status)
        {
            this.MainProblem = mainProblem;
            this.PhoneNumber = phoneNumber;
            this.OwnerName = ownerName;
            this.StartPrice = startPrice;
            this.TakenDate = takenDate;
            this.Type = type;
            this.Status = status;
        }

    }
}
