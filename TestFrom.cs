
namespace lab2;
public partial class TestForm : Form
{
    public TestForm()
    {
        InitializeComponent();
        List<Item> list = new List<Item>() { new Item(1,"1",1), new Item(1,"1",1), new Item(1,"1",1), new Item(1,"1",1)};
        DataProcessing.WriteToFile(list);
        var result = DataProcessing.ReadJsonFromFile<Item>();
        string res = "";
        foreach (var VARIABLE in result)
        {
            res += VARIABLE + "\n";
        }
        MessageBox.Show(res);
    }
}