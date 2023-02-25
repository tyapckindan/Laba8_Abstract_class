abstract class SpecialTransport
{
    public string Name { get; }

    public string Model { get; }

    public string Number { get; }

    public SpecialTransport(string name, string model, string number)
    {
        Name = name;
        Model = model;
        Number = number;
    }
    public virtual void Move() => Console.WriteLine($"{Name} движется");
    public void GetInfo() => Console.WriteLine($"Специальный транспорт:\n {Name} {Model} {Number}");
}