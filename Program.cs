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

        try
        {
            List<Ordere> list = new List<Ordere>()
            {
                new Ordere(1, new DateTime(2007, 5, 29), "adress", true, new Customer("123456", "phone", "fullname", true),
                    new List<OrderLine>() { new OrderLine(2, new Item("123456", "name", 12.22)) })
            };

            DataProcessing.WriteToFile<Ordere>(list);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}