namespace Ex_04_03.Modules;

static class Employee
{

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }

    public Employee(int id, string name, string address)
    {
        this.Id = id;
        this.Name = name;
        this.Address = address;
    }
    public override string ToString()
    {
        return $"Employee[Id={Id}, Name={Name}, Adress={Adress}";
    }

}
