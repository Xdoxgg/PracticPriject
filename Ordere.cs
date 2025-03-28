namespace lab2;


[Serializable]
public class Ordere
{
    private int _number;
    private DateTime _creationDate;
    private string _adress;
    private bool _isExpressDelivery;
    private Customer _customer;
    private List<OrderLine> _orderLines;

    public Ordere(int number, DateTime creationDate, string adress, bool isExpressDelivery, Customer customer, List<OrderLine> orderLines)
    {
        _number = number;
        _creationDate = creationDate;
        _adress = adress;
        _isExpressDelivery = isExpressDelivery;
        _customer = customer;
        _orderLines = orderLines;
    }

    public Ordere()
    {
    }

    public int Number
    {
        get =>_number;
        set => value = value;
    }

    public DateTime CreationDate
    {
        get => _creationDate;
        set => _creationDate = value; 
    }

    public string Adress
    {
        get => _adress;
        set => _adress = value;
    }

    public bool IsExpressDelivery
    {
        get => _isExpressDelivery;
        set => _isExpressDelivery = value;
    }

    public Customer Customer
    {
        get => _customer;
        set => _customer = value;
    }

    public List<OrderLine> OrderLines
    {
        get => _orderLines;
        set => _orderLines = value; 
    }

    public double TotalCost
    {
        get
        {
            double sum = 0;
            _orderLines.ForEach(x => sum += x.Cost);
            if (_isExpressDelivery)
            {
                sum *= 1.25;
            }

            if (_customer.Privileged && sum >= 1500)
            {
                sum = sum - sum * 0.15;
            }
            return sum;
        }
    }
}