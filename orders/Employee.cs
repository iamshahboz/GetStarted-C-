namespace Restaurant.orders;

public class Employee
{
    private object _previousOrder;
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
        return _previousOrder;
    }

    public string Inspect(object order)
    {
        if (order is ChickenOrder)
        {
            return  "No inspection required";
        }
        else
        {
            return ((EggOrder)order).GetQuality().ToString();
        }
    }

    public string PrepareFood(object order)
    {
        if (order is ChickenOrder)
        {
            ((ChickenOrder)order).CutUp();
            
            ((ChickenOrder)order).Cook();

            return "Chicken preparation completed";
        }
        else
        {
            ((EggOrder)order).GetQuantity();
            
            ((EggOrder)order).DiscardShell();

            ((EggOrder)order).Cook();
            
            return "Egg preparation completed. Your egg is rotten";
        }
        
    }
}