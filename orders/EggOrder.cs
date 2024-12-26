namespace Restaurant.orders
{
    public class EggOrder
    {
        private int _quantity;
        private static int _instanceCount = 0;
        private List<int?> _qualities;

        // Constructor accepting quantity
        public EggOrder(int quantity)
        {
            _qualities = new List<int?>();
            _quantity = quantity;
            _instanceCount++;
            
            
            // Calculate quality only once when the instance is created
            //_quality = new Random().Next(1, 101); // Random value between 1 and 100
        }

        // Method to get the quantity
        public int GetQuantity()
        {
            return _quantity;
        }

        // Method to get the quality, returns nullable int
        public List<int?> GenerateQualities()
        {
            var random = new Random();

            for (int i = 0; i < _quantity; i++)
            {
                // Simulate the employee forgetting the quality every 3rd instance
                // if (_instanceCount % 3 == 0)
                // {
                //     _qualities.Add(null);
                // }
                //else
                //{
                _qualities.Add(random.Next(1, 101)); // Random value between 1 and 100
                //}
            }
            return _qualities;
        }
        
        

        
        public List<int?> GetQualities()
        {
            return _qualities;
        }
        

        // public void Crack()
        // {
        //     for (int i = 0; i < _quantity; i++)
        //     {
        //         // var quality = getQuality();
        //         // if (quality < 25 || quality is not null)
        //         // {
        //         //     // rotten egg
        //         // }
        //     }
        // }

        public void Cook()
        {
            
        }

        public void DiscardShell()
        {
            
        }
    }
}