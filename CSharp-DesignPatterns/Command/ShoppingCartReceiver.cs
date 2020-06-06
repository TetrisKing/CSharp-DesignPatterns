using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_DesignPatterns.Command
{
    //Receiver allows Commands to perform their specific actions 
    public class ShoppingCartReceiver : IShoppingCartReceiver
    {
        private List<string> shoppingCartItems = new List<string>();
        private List<string> checkoutItems = new List<string>();

        public void AddItem(string item)
        {
            shoppingCartItems.Add(item);
        }
        public void RemoveItem(string item)
        {
            shoppingCartItems.Remove(item);
        }
        public bool ExistsItem(string item)
        {
            return shoppingCartItems.Any(s => s == item);
        }

        public void Checkout() {
            checkoutItems.AddRange(shoppingCartItems);
            shoppingCartItems.Clear();
        }
        public void CheckoutUndo(List<string> items)
        {
            shoppingCartItems.AddRange(items);
            checkoutItems.RemoveAll(i => items.Contains(i));
        }

        public List<string> ListItems() {
            return shoppingCartItems;
        }
        public List<string> ListCheckoutItems()
        {
            return checkoutItems;
        }
    }
}
