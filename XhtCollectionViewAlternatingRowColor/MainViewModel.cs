using System;
using System.Collections.Generic;

namespace XhtCollectionViewAlternatingRowColor
{
    public class MainViewModel
    {
        public List<string> Items { get; set; }

        public MainViewModel()
        {
            var items = new List<string>();

            for (int i = 0; i < 20; i++)
            {
                items.Add(i.ToString());
            }

            Items = new List<string>(items);
        }
    }
}
