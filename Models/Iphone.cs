namespace trilha_net_poo_desafio.Models;

public class Iphone(string model, string imei, int memory, string number) : Smartphone(model, imei, memory, number)
{
    public override void InstallApp(string name)
    {
        Console.WriteLine($"Instalando o APP {name} no smartphone Iphone.");
    }
}