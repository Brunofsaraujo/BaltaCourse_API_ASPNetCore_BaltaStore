using System;
using BaltaStore.Domain.StoreContext.Enums;
using BaltaStore.Shared.Entities;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery : Entity
    {
        public Delivery(DateTime estimetedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimetedDeliveryDate = estimetedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; }
        public DateTime EstimetedDeliveryDate { get; }
        public EDeliveryStatus Status { get; private set; }

        public void Ship()
        {
            //Se a data estimada de entrega for no passado, nao entregar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            //Se o status o status ja estiver entregue, não pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}