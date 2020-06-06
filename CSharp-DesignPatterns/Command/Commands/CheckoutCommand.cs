using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_DesignPatterns.Command
{
    public class CheckoutCommand : ICommand
    {
        private readonly IShoppingCartReceiver shoppingCartReceiver;
        private readonly List<string> items;

        public CheckoutCommand(IShoppingCartReceiver shoppingCartReceiver)
        {
            this.shoppingCartReceiver = shoppingCartReceiver;
            this.items = new List<string>();
            this.items.AddRange(this.shoppingCartReceiver.ListItems());
        }

        public bool CanExecute()
        {
            return items.All(i => shoppingCartReceiver.ExistsItem(i));
        }

        public void Execute()
        {
            shoppingCartReceiver.Checkout();
        }

        public void Undo()
        {
            shoppingCartReceiver.CheckoutUndo(items);
        }
    }
}
