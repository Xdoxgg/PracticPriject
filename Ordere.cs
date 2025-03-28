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

    public double TotalCost
    {
        get
        {
            double sum = 0;
            _orderLines.ForEach(x => sum += x.Cost);
            if (_isExpressDelivery)
            {
                //TODO: ввод данных 
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