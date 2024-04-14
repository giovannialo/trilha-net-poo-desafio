namespace trilha_net_poo_desafio.Models;

public abstract class Smartphone(string model, string imei, int memory, string number)
{
    private string _model = model;
    private string _imei = imei;
    private int _memory = memory;

    public string Number { get; } = number;

    public void Call()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceiveCall()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstallApp(string name);
}