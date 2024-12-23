using Restaurant.orders;

namespace Restaurant;

// static class Program
// {
//     /// <summary>
//     ///  The main entry point for the application.
//     /// </summary>
//     [STAThread]
//     static void Main()
//     {
//         // To customize application configuration such as set high DPI settings or default font,
//         // see https://aka.ms/applicationconfiguration.
//         ApplicationConfiguration.Initialize();
//         Application.Run(new Form1());
//     }
// }
public class Program
{
    public static void Main()
    {
        #region ChickenOrder

        ChickenOrder order = new ChickenOrder(5);
        Console.WriteLine($"Chicken order: {order.GetQuantity()}");

        order.CutUp();
        order.Cook();

        #endregion

        #region EggOrder

        EggOrder order1 = new EggOrder(10);
        Console.WriteLine($"Order 1 - Quantity: {order1.GetQuantity()}, Quality: {order1.GetQuality()}");
        EggOrder order2 = new EggOrder(20);
        Console.WriteLine($"Order 2 - Quantity: {order2.GetQuantity()}, Quality: {order2.GetQuality()}");
        EggOrder order3 = new EggOrder(30);
        Console.WriteLine($"Order 3 - Quantity: {order3.GetQuantity()}, Quality: {order3.GetQuality()}");

        #endregion
    }
}