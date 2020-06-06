using System.Collections.Generic;

namespace CSharp_DesignPatterns.Command
{
    public interface IShoppingCartReceiver
    {
        void AddItem(string item);
        bool ExistsItem(string item);
        void RemoveItem(string item);

        void Checkout();
        void CheckoutUndo(List<string> items);
        List<string> ListItems();
        List<string> ListCheckoutItems();
    }
}