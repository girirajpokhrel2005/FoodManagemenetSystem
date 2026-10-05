namespace FoodManagementSystem.Models
{
    public abstract class InventoryItem
    {
        public int FoodID { get; private set; }

        public string FoodName { get; protected set; }

        public int Quantity { get; protected set; }

        protected InventoryItem(int foodID, string foodName, int quantity)
        {
            FoodID = foodID;
            FoodName = foodName;
            Quantity = quantity;
        }

        public void UpdateBasicDetails(string foodName, int quantity)
        {
            if (string.IsNullOrWhiteSpace(foodName))
                throw new ArgumentException("Food name cannot be empty.");

            if (quantity < 0)
                throw new ArgumentException("Quantity cannot be negative.");

            FoodName = foodName;
            Quantity = quantity;
        }

        public abstract string GetStockStatus();
    }
}