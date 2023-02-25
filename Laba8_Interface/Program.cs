internal class Program
{
    private static void Main(string[] args)
    {
        SpecialTransport ambulance = new Ambulance("Cкорая помощь", "Уаз-452", "ИП-320");
        SpecialTransport towtruck = new TowTruck("Эвакуатор", "Газ-44", "А-770");
        SpecialTransport largecrane = new LargeCrane("Автокран", "КАМАЗ", "КС 45717К-1");

        ambulance.Move();

        ambulance.GetInfo();

        towtruck.Move();

        towtruck.GetInfo();

        largecrane.GetInfo();

        largecrane.Move();

    }
}