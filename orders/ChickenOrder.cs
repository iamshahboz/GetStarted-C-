namespace Restaurant

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

        public void CutUp()
        {
            for (int i = 0; i < _quantity; i++)
            {
                Console.WriteLine($"Cutting up chicken {i+1}");
            }
        }

        public void Cook()
        {
            Console.WriteLine("Cooking the chichens...");
        }

    }
}


