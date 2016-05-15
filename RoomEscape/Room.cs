using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape
{
    internal class Room
    {
        private int id;
        private List<Item> contents;
        private Dictionary<string, Room> exits;
        private string name;
        private string shortDesc;
        private string longDesc;

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

        internal Dictionary<string, Room> Exits
        {
            get
            {
                return exits;
            }

            set
            {
                exits = value;
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

        public Room(int id, List<Item> contents, Dictionary<string, Room> exits, string name, string shortDesc, string longDesc)
        {
            this.Id = id;
            this.Contents = contents;
            this.Exits = exits;
            this.Name = name;
            this.ShortDesc = shortDesc;
            this.LongDesc = longDesc;
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
