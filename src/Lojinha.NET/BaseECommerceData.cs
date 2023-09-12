using System;
using System.Collections.Generic;

namespace Lojinha.NET
{
    // Represents the e-commerce base class with sample product list
    public class BaseECommerceData
    {
        public static int MaxOrderId { get; private set; } = 0;

        // Initializes the e-commerce with sample data
        public List<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product(1, "🍇", "Grapes box", 3.50m),
                new Product(2, "🍈", "Melon box", 3.50m),
                new Product(3, "🍉", "Watermelon box", 5.50m),
                new Product(4, "🍊", "Tangerine box", 3.50m),
                new Product(5, "🍋", "Lemon box", 3.50m),
                new Product(6, "🍌", "Banana box", 3.50m),
                new Product(7, "🍍", "Pineapple box", 3.50m),
                new Product(8, "🥭", "Mango box", 4.50m),
                new Product(9, "🍎", "Red Apple box", 3.50m),
                new Product(10, "🍏", "Green Apple box", 6.50m),
                new Product(11, "🍐", "Pear box", 3.50m),
                new Product(12, "🍑", "Peach box", 3.50m),
                new Product(13, "🍒", "Cherries box", 3.50m),
                new Product(14, "🍓", "Strawberry box", 3.50m),
                new Product(15, "🥝", "Kiwi Fruit box", 7.50m),
                new Product(16, "🍅", "Tomato box", 2.50m),
                new Product(17, "🥥", "Coconut", 4.50m)
            };
        }
    }
}
