
namespace lab2;
public partial class TestForm : Form
{
    public TestForm()
    {
        InitializeComponent();
       
        List<OrderLine> orderLines = new List<OrderLine>() { new OrderLine(2,new Item(1,"1",1)), new OrderLine(3, new Item(2,"2",2))};
        List<Ordere> orderes = new List<Ordere>() { new Ordere(1,new DateTime(2025,5,20), "adress",false, new Customer("1","+375...","full name", false),orderLines),new Ordere(1,new DateTime(2025,5,20), "adress",false, new Customer("1","+375...","full name", false),orderLines)};
        DataProcessing.WriteToFile(orderes);
        MessageBox.Show(orderes.GetType().ToString());
        var result1 = DataProcessing.ReadJsonFromFile<Ordere>();

        
    } 
}