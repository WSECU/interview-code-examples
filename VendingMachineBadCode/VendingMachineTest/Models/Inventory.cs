namespace VendingMachineTest.Models
{
    public class Inventory
    {
        public Inventory()
        {
            Soda = new Item("Soda", 10, 0.95m);
            CandyBars = new Item("CandyBar", 20, 0.60m);
            Chips = new Item("Chips", 15, 0.99m);
        }

        public Inventory(Item soda, Item candyBars, Item chips)
        {
            Soda = soda;
            CandyBars = candyBars;
            Chips = chips;
        }

        public Item Soda { get; set; }
        public Item CandyBars { get; set; }
        public Item Chips { get; set; }

        public Item BuySoda()
        {
            Soda.Quantity -= 1;
            return new Item(Soda.Name, 1, Soda.Price);
        }

        public Item BuyCandyBar()
        {
            CandyBars.Quantity -= 1;
            return new Item(CandyBars.Name, 1, CandyBars.Price);
        }

        public Item BuyChips()
        {
            Chips.Quantity -= 1;
            return new Item(Chips.Name, 1, Chips.Price);
        }
    }

    public class Item
    {
        public Item(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
