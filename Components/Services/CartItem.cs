public class CartItem
    {
        public Guid Id { get; set; } = new Guid ();
        public string? ImgUrl { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public CartItem(string itemName, int quantity, double price)
        {
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }
    }