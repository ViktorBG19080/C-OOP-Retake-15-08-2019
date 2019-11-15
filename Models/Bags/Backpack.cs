﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Bags
{
    class Backpack : IBag
    {
        private List<string> items;
        public Backpack()
        {
            this.items = new List<string>();
        }
        public ICollection<string> Items { get=> items;}
    }
}
