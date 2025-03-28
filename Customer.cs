namespace lab2;

[Serializable]
public class Customer
{
    public Customer()
    {
    }

    private string _code;
    private string _contactPhone;
    private string _fullName;
    private bool _isPrivileged;

    public bool Privileged
    {
        get => _isPrivileged;
        set => _isPrivileged = value;
    }

    public string Code
    {
        get => _code;
        set => _code = value;
    }

    public string ContactPhone
    {
        get => _contactPhone;
        set => _contactPhone = value;
    }

    public string FullName
    {
        get => _fullName;
        set => _fullName = value;
    }

    public Customer(string code, string contactPhone, string fullName, bool isPrivileged)
    {
        _code = code ?? throw new ArgumentNullException(nameof(code));
        _contactPhone = contactPhone ?? throw new ArgumentNullException(nameof(contactPhone));
        _fullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        _isPrivileged = isPrivileged;
    }
}