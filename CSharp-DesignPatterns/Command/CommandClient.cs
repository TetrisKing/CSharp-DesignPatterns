using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Command
{
    public class CommandClient
    {
        //Select a Command and pass it to the Invoker
        private ShoppingCartReceiver shoppingCartReceiver;
        private CommandInvoker commandInvoker;

        public CommandClient()
        {
            shoppingCartReceiver = new ShoppingCartReceiver();
            commandInvoker = new CommandInvoker();
        }

        public void StartClient() {
            while (true)
            {
                Console.WriteLine("1-Add Item, 2-Checkout, 3-Undo Last, 4-Undo All, 9-Exit");
                var input = Console.ReadKey();
                switch (input.KeyChar)
                {
                    case '1':
                        AddToCartCommand();
                        break;
                    case '2':
                        CheckoutCommand();
                        break;
                    case '3':
                        commandInvoker.UndoLast();
                        break;
                    case '4':
                        commandInvoker.UndoAll();
                        break;
                    case '9':
                        return;
                }
                ListShoppingCartStatus();
            }
        }

        private void AddToCartCommand()
        {
            AddToCartCommand command = new AddToCartCommand(shoppingCartReceiver, Guid.NewGuid().ToString());
            commandInvoker.Invoke(command);
        }
        private void CheckoutCommand()
        {
            CheckoutCommand command = new CheckoutCommand(shoppingCartReceiver);
            commandInvoker.Invoke(command);
        }

        private void ListShoppingCartStatus() {
            Console.WriteLine("\n----Items----");
            foreach (var item in shoppingCartReceiver.ListItems())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            Console.WriteLine("\n----Checkout----");
            foreach (var item in shoppingCartReceiver.ListCheckoutItems())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            Console.WriteLine("\n");
        }
    }
}
