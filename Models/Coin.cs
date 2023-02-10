using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace Test_Task_WPF.Models
{
    public class Coin 
    {
        private Item _item;

        public Item Item { get => _item; set => _item = value; }

        public Coin(Item item)
        {
            _item = item;

        }
    }
}
