public class Employee
{
    int _id;
    string _firstName;
    string _lastName;
    int _salary;
    public Employee(int id, string firstName, string lastName, int salary)
    {
        this._id=id;
        this._firstName=firstName;
        this._lastName=lastName;
        this._salary=salary;
    }
    public int GetId()
    {
        return this._id;
    }
    public string GetFirstName()
    {
        return this._firstName;
    }
    public string GetLastName()
    {
        return this._lastName;
    }
    public string GetName()
    {
        return $"{_firstName} {_lastName}";
    }
    public int GetSalary()
    {
        return _salary;
    }
    public void SetSalary(int salary)
    {
        this._salary=salary;
    }
    public int GetAnnualSalary()
    {
        return _salary*12;
    }
    public int RaiseSalary(int percent)
    {
        _salary=_salary*(1+percent/100);
        return _salary;
    }
    public override string ToString()
    {
        return $"Employee[id={_id}, name={_firstName}, lastName={_lastName}, salary={_salary}]";
    }
}
