using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRPGGame.Items.Consumables
{
    public class ConsumableManaPotion : ConsumableItem
    {
        public int Value { get; set; }

        public ConsumableManaPotion(string @name, int @value)
        {
            Name = @name;
            Value = @value;
        }
    }
}
