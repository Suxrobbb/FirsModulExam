using firstModulExam.Models;
namespace firstModulExam.Services;

public class PhoneService
{
    private List<Phone> phones;

    public PhoneService()
    {
        phones = new List<Phone>();
    }

    public Guid Id(Phone phone)
    {
        var id = Guid.NewGuid();
        phones.Add(phone);
        return id;
    }

    public Phone AddPhone(Phone phone)
    {
        phones.Add(phone);
        return phone;
    }

    public Guid GetById(Guid id)
    {
        return id;
    }

    public bool DeletePhone(Phone phone)
    {
        return phones.Remove(phone);
    }

    public bool UpdatePhone(Phone phone)
    {
        phones.Remove(phone);
        return true;
    }

    public List<Phone> GetAllPhones(Guid id)
    {
        return phones;
    }
}
