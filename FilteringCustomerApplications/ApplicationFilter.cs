namespace FilteringCustomerApplications;

public class ApplicationFilter
{
    private readonly int _minimumAge = 21;
    private readonly int _maximumAge = 80;
    private readonly List<string> _invalidCreditBanding = new() { "A", "B" };
    
    public bool IsValidAge(CarFinanceApplication application)
    {
        if (application.Age < _minimumAge || application.Age > _maximumAge)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool IsValidCreditBanding(CarFinanceApplication application)
    {
        if (_invalidCreditBanding.Contains(application.CreditBanding.ToString()))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool IsValidOccupation(CarFinanceApplication application)
    {
            if (application.Occupation.Contains("Driver"))
            {
                return false;
            }
            else
            {
                return true;
            }
    }
    
}
