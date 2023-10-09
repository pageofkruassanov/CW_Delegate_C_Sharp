using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Delegate_C_Sharp
{
    delegate void ShowMessage(string mess);
    internal class Program
    {
        static void Main(string[] args)
        {
            Message message1 = new Message("Hello");
            Message messgae2 = new Message(", world!");

            ShowMessage getMessage = new ShowMessage(Message.DisplayMessage);
            getMessage.Invoke(message1.ToString()); 
            getMessage.Invoke(messgae2.ToString());
            Console.ReadLine();
        }
    }
}
