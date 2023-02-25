class Ambulance : SpecialTransport
{
    public Ambulance(string name, string model, string number) : base(name, model, number) { }

    public override void Move()
    {
        Console.WriteLine("Скорая помощь уже в пути!");
    }
}