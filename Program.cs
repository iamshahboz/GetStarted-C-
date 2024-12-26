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
        
        #endregion
        
        #region EggOrder 
        EggOrder egg = new EggOrder(5);
        Console.WriteLine($"Egg order: {egg.GenerateQualities()}");
        #endregion

        
    }
}