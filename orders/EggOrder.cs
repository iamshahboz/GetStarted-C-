namespace Restaurant.orders
{
    public class EggOrder
    {
        private int _quantity;
        private int _quality;
        private static int _instanceCount = 0;

        // Constructor accepting quantity
        public EggOrder(int quantity)
        {
            _quantity = quantity;
            _instanceCount++;
            // Calculate quality only once when the instance is created
            _quality = new Random().Next(1, 101); // Random value between 1 and 100
        }

        // Method to get the quantity
        public int GetQuantity()
        {
            return _quantity;
        }

        // Method to get the quality, returns nullable int
        public int? GetQuality()
        {
            // Simulate the employee forgetting the quality 1/2 of the time
            if (_instanceCount % 3 == 0) // 2nd, 4th, 6th... instance
            {
                return null; // Employee forgets the quality
            }
            else
            {
                return _quality; // Return calculated quality
            }
        }

        public void Crack()
        {
            
        }

        public void Cook()
        {
            
        }

        public void DiscardShell()
        {
            
        }
    }
}