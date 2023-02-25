using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelMaker
{
    class Mebel
    {
        private string name;
        private string length;
        private string width;
        private string height;
        private string corpus;
        private string filling;
        private string colour;
        private string manufacturer;
        private string price;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public string Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public string Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public string Corpus
        {
            get { return this.corpus; }
            set { this.corpus = value; }
        }
        public string Filling
        {
            get { return this.filling; }
            set { this.filling = value; }
        }
        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public string Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Mebel()
        {
            this.Name = string.Empty;
            this.Length = string.Empty;
            this.Width = string.Empty;
            this.Height = string.Empty;
            this.Corpus = string.Empty;
            this.Filling = string.Empty;
            this.Colour = string.Empty;
            this.Manufacturer = string.Empty;
            this.Price = string.Empty;

            ////////////////////////////////////////---POOP PAUSE---////////////////////////////////////////
        }

    }
}
