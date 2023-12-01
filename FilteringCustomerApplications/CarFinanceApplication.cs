namespace FilteringCustomerApplications;
public class CarFinanceApplication
{
    public string Name { get; set;  }
    public int Age { get; set; }
    public ResidentialStatus ResidentialStatus { get; set; } 
    public string Occupation { get; set; }
    public EmploymentStatus EmploymentStatus { get; set; }
    public string PostCode { get; set; }
    public CreditBanding CreditBanding { get; set; }

    public CarFinanceApplication()
    {
        
    }
    
    public CarFinanceApplication(string name, int age, ResidentialStatus residentialStatus, string occupation, 
        EmploymentStatus employmentStatus, string postCode, CreditBanding creditBanding)
    {
        Name = name;
        Age = age;
        ResidentialStatus = residentialStatus;
        Occupation = occupation;
        EmploymentStatus = employmentStatus;
        PostCode = postCode;
        CreditBanding = creditBanding;
    }
    
}