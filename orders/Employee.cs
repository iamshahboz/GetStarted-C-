using System.Text;

namespace Restaurant.orders;

public class Employee
{
    private object _previousOrder;
    private object _lastPreparedOrder = null;
    public object  NewRequest(int quantity, string menuItem)
    {
        if (menuItem == "Chicken")
        {
            _previousOrder = new ChickenOrder(quantity);
            
        }
        else
        {   
            _previousOrder = new EggOrder(quantity);
            
        }

        return _previousOrder;
    }

    public object CopyRequest()
    {
        if (_previousOrder == null)
        {
            throw new InvalidOperationException("No previous request exists. Please create a new request first.");
        }
        else
        {
            return _previousOrder;
        }
    }

    public List<int> Inspect(object order)
    {
        
        if (order is ChickenOrder)
        {
            throw new InvalidOperationException("No inspection required");
        }
        else
        {
            var qualities = ((EggOrder)order).GetQualities();
            // Filter out null values or replace them with a default
            return qualities.Where(q => q.HasValue).Select(q => q.Value).ToList();
        }
    }

    public List<string> PrepareFood(object order)
    {
        var messages = new List<string>();
        
        if (_lastPreparedOrder == order)
        {
            throw new InvalidOperationException("Food has already been prepared");
        }

        if (order is ChickenOrder chickenOrder)
        {
            messages.AddRange(chickenOrder.CutUp());
            messages.AddRange(chickenOrder.Cook());
            messages.Add("Chicken preparation completed");
            
        }
        else if (order is EggOrder eggOrder)
        {
            messages.Add($"Egg order contains {eggOrder.GetQuantity()} eggs");
        }
        _lastPreparedOrder = order;
        return messages;

    }
}