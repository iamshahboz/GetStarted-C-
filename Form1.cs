namespace Restaurant;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show(Chicken.Checked.ToString());
        MessageBox.Show(EggOrder.Checked.ToString());
    }

    private void ChickenOrder(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void EggsOrder(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Results_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void CopyRequest_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}