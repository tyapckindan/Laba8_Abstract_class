class TowTruck : SpecialTransport
{
    public TowTruck(string name, string model, string number) : base(name, model, number) { }

    public override void Move()
    {
        Console.WriteLine("Эвакуатор везёт ваш автомобиль на свалку!");
    }
}