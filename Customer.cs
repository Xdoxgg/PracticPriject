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
        set => _code = value?? throw new ArgumentException("Невалидное значение Code");
    }

    public string ContactPhone
    {
        get => _contactPhone;
        set => _contactPhone = value?? throw new ArgumentException("Невалидное значение ContactPhone");
    }

    public string FullName
    {
        get => _fullName;
        set => _fullName = value ?? throw new ArgumentException("Невалидное значение FullName");
    }

    public Customer(string code, string contactPhone, string fullName, bool isPrivileged)
    {
        Code = code ?? throw new ArgumentNullException(nameof(code));
        ContactPhone = contactPhone ?? throw new ArgumentNullException(nameof(contactPhone));
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        Privileged = isPrivileged;
    }

    public override string ToString()
    {
        return $"Код: {_code}; номер телефона: {_contactPhone}; ФИО: {_fullName}; привилегированный: {_isPrivileged}";
    }
}