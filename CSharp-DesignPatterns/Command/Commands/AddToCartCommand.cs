using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Command
{
    public class AddToCartCommand : ICommand
    {
        private readonly IShoppingCartReceiver shoppingCartReceiver;
        private readonly string item;

        public AddToCartCommand(IShoppingCartReceiver shoppingCartReceiver, string item)
        {
            this.shoppingCartReceiver = shoppingCartReceiver;
            this.item = item;
        }

        public bool CanExecute()
        {
            return !shoppingCartReceiver.ExistsItem(item);
        }

        public void Execute()
        {
            if (string.IsNullOrEmpty(item)) return;

            shoppingCartReceiver.AddItem(item);
        }

        public void Undo()
        {
            shoppingCartReceiver.RemoveItem(item);
        }
    }
}
