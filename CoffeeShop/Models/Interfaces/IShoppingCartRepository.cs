using CoffeeShop.Data;

namespace CoffeeShop.Models.Interfaces
{
    public interface IShoppingCartRepository
    {

      

        void AddToCart(Products product);

        int RemoveFromCart(Products product);
        List<ShoppingCartItem> GetShoppingCartItems();

        void ClearCart();

        decimal GetShoppingCartTotal();

        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }


    }
}
