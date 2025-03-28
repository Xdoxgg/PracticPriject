namespace lab2;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.


        List<Ordere> list = new List<Ordere>()
        {
            new Ordere(2, new DateTime(2025, 12, 12), "adress", true, new Customer("11", "phone", "name", true),
                new List<OrderLine>() { new OrderLine(2, new Item("123456", "item", 12.22)) })
        };
        DataProcessing.WriteToFile<Ordere>(list);
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}