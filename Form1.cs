using Restaurant.orders;

namespace Restaurant;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private object order;
    private Employee _employee = new();

    private void button1_Click(object sender, EventArgs e)
    {
        object orderResult;
        var selectedItem = Chicken.Checked ? Chicken.Text : EggOrder.Text;
        if (Chicken.Checked)
        {
            
            order = _employee.NewRequest(int.Parse(textBox1.Text), "Chicken");
            ResultsList.Items.Add($"New request submitted: {selectedItem} {textBox1.Text}");
        }

        else
        {
            order = _employee.NewRequest(int.Parse(textBox1.Text), "Egg");
            ResultsList.Items.Add($"New request submitted: {selectedItem} {textBox1.Text}");
        }

        // Call Inspect and process the result
        var inspectResult = _employee.Inspect(order);

        // Convert the list of integers to a string for display
        if (inspectResult != null && inspectResult.Any())
        {
            label2.Text = $"Inspection Result: {string.Join(", ", inspectResult)}";
        }
        else
        {
            label2.Text = "No qualities available for inspection.";
        }
    }


    private void CopyRequest_Click(object sender, EventArgs e)
    {
        try
        {
            order = _employee.CopyRequest();
            var inspectResult = _employee.Inspect(order);

            // Convert the list of integers to a string for display
            if (inspectResult != null && inspectResult.Any())
            {
                label2.Text = $"Inspection Result: {string.Join(", ", inspectResult)}";
            }
            else
            {
                label2.Text = "No qualities available for inspection.";
            }

            ResultsList.Items.Add($"Previous request copied: {textBox1.Text}");
        }
        catch (Exception exception)
        {
            ResultsList.Items.Add(exception.Message);
        }
    }

    private void PrepareFood_Click(object sender, EventArgs e)
    {
        try
        {
            List<string> prepareFood = _employee.PrepareFood(order: order);
            foreach (var message in prepareFood)
            {
                ResultsList.Items.Add(message);
            }
            
        }
        catch (Exception exception)
        {
            ResultsList.Items.Add(exception.Message);
        }
    }
}