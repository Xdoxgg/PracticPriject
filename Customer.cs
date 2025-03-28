namespace lab2;


public class Customer
{
    private string _code;
    private string _contactPhone;
    private string _fullName;
    private bool _isPrivileged;
    public bool Privileged => _isPrivileged;

    public Customer(string code, string contactPhone, string fullName, bool isPrivileged)
    {
        _code = code ?? throw new ArgumentNullException(nameof(code));
        _contactPhone = contactPhone ?? throw new ArgumentNullException(nameof(contactPhone));
        _fullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        _isPrivileged = isPrivileged;
    }
}