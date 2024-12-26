namespace Restaurant.orders

{
    public class ChickenOrder
    {
        private int _quantity;

        public ChickenOrder(int quantity)
        {
            _quantity = quantity;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public List<string> CutUp()
        {
            var messages = new List<string>();
            for (int i = 0; i < _quantity; i++)
            {
                messages.Add($"Chicken piece {i} has been cut up.");
            }

            return messages;
        }

        public List<string> Cook()
        {
            var messages = new List<string>();
            for (int i = 0; i < _quantity; i++)
            {
                messages.Add($"Chicken piece {i} has been cooked.");
            }
            return messages;
        }

    }
}


