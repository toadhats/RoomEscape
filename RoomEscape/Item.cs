using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape
{
    internal class Item
    {
        private int id;
        private string name;
        private string shortDesc;
        private string longDesc;
        private float weight;
        private List<Item> contents; // Items can contain other items

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string ShortDesc
        {
            get
            {
                return shortDesc;
            }

            set
            {
                shortDesc = value;
            }
        }

        public string LongDesc
        {
            get
            {
                return longDesc;
            }

            set
            {
                longDesc = value;
            }
        }

        public float Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        internal List<Item> Contents
        {
            get
            {
                return contents;
            }

            set
            {
                contents = value;
            }
        }

        public Item(int id, string name, string shortDesc, string longDesc, float weight, List<Item> contents)
        {
            this.Id = id;
            this.Name = name;
            this.ShortDesc = shortDesc;
            this.LongDesc = longDesc;
            this.Weight = weight;
            this.Contents = contents;
        }

        public void AddItem(Item item)
        {
            contents.Add(item);
        }

        public void RemoveItem(Item item)
        {
            contents.Remove(item);
        }

        public void RemoveItemByName(string itemName)
        {
            contents.Remove(contents.Find(x => x.Name.Equals(itemName)));
        }
    }
}
