﻿using TokoAgel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TokoAgel.Controller
{
    class MenuController
    {
        private List<Item> menuItem;

        public MenuController()
        {
            menuItem = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.menuItem.Add(item);
        }

        public List<Item> getItems()
        {
            return this.menuItem;
        }
    }
}