using BaltaStore.Shared.Entities;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Product : Entity
    {
        public Product(
            string title,
            string description,
            string image,
            decimal price,
            decimal quantityOnHand)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantityOnHand;
        }

        public string Title { get; }
        public string Description { get; }
        public string Image { get; }
        public decimal Price { get; }
        public decimal QuantityOnHand { get; private set; }

        public override string ToString()
        {
            return Title;
        }

        public void DecreaseQuantity(decimal quantity)
        {
            QuantityOnHand -= quantity;
        }
    }
}