using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Snake
    {
        public class Part
        {
            private Location location;
            private Part next;

            public Location Location
            {
                get { return this.Location; }
                set { this.Location = value; }
            }

            public Part Next
            {
                get { return this.next; }
                set { this.next = value; }
            }

            public Part(Location location)
            {
                this.location = location;
            }

        }

        private Part head;
        public Part Head
        {
            get { return this.head; }
            set { this.head = value; }
        }

        private Part tail;
        public Part Tail
        {
            get { return this.tail; }
            set { this.tail = value; }
        }

        private int count;
        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public Snake(Part head)
        {
            this.Head = head;
        }

        private void Add(Location location)
        {
            Part part = new Part(location);
            if (this.tail != null) this.tail.Next = part;
            this.tail = part;
        }
    }
}
