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
        if (Chicken.Checked)
            order = _employee.NewRequest(quantity: int.Parse(textBox1.Text), "Chicken");


        else
        {
            order = _employee.NewRequest(quantity: int.Parse(textBox1.Text), "Egg");
        }

        var inspectResult = _employee.Inspect(order);
        label2.Text = inspectResult;
    }


    private void CopyRequest_Click(object sender, EventArgs e)
    {
        try
        {
            order = _employee.CopyRequest();
            var inspectResult = _employee.Inspect(order);
            label2.Text = inspectResult;

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
            object prepareFood = _employee.PrepareFood(order: order);
            ResultsList.Items.Add(prepareFood);
        }
        catch (Exception exception)
        {
            ResultsList.Items.Add(exception.Message);
        }
    }
}