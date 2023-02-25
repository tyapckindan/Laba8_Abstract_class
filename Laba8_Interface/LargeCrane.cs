class LargeCrane : SpecialTransport
{
    public LargeCrane(string name, string model, string number) : base(name, model, number) { }

    public override void Move()
    {
        Console.WriteLine("Подъёмный кран едет. Едет поднимать.");
    }
}