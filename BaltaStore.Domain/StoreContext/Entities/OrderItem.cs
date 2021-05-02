using FluentValidator;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class OrderItem : Notifiable
    {
        public OrderItem(
            Product product,
            decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;

            if (product.QuantityOnHand < quantity)
                AddNotification("Quantity", "Produto fora de estoque");

            product.DecreaseQuantity(quantity);
        }

        public Product Product { get; }
        public decimal Quantity { get; }
        public decimal Price { get; }
    }
}