using System;
using BaltaStore.Domain.StoreContext.Enums;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimetedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimetedDeliveryDate = estimetedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimetedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }
    }
}