using System;
using System.Collections.Generic;

class Veiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
}

class Estacionamento
{
    private List<Veiculo> veiculosEstacionados = new List<Veiculo>();

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculosEstacionados.Add(veiculo);
        Console.WriteLine($"Veículo {veiculo.Placa} estacionado com sucesso.");
    }

    public void RemoverVeiculo(string placa)
    {
        Veiculo veiculoRemover = veiculosEstacionados.Find(v => v.Placa == placa);
        if (veiculoRemover != null)
        {
            veiculosEstacionados.Remove(veiculoRemover);
            Console.WriteLine($"Veículo {veiculoRemover.Placa} removido do estacionamento.");
            // Aqui você pode calcular e exibir o valor cobrado durante o período
        }
        else
        {
            Console.WriteLine($"Veículo com placa {placa} não encontrado no estacionamento.");
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Veículos estacionados:");
        foreach (Veiculo veiculo in veiculosEstacionados)
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Marca: {veiculo.Marca}, Modelo: {veiculo.Modelo}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Exemplo de uso:

        // Criando instâncias de Veiculo e Estacionamento
        Veiculo veiculo1 = new Veiculo { Placa = "ABC1234", Marca = "Marca1", Modelo = "Modelo1" };
        Veiculo veiculo2 = new Veiculo { Placa = "XYZ5678", Marca = "Marca2", Modelo = "Modelo2" };
        Estacionamento estacionamento = new Estacionamento();

        // Adicionando veículos ao estacionamento
        estacionamento.AdicionarVeiculo(veiculo1);
        estacionamento.AdicionarVeiculo(veiculo2);

        // Listando veículos estacionados
        estacionamento.ListarVeiculos();

        // Removendo um veículo do estacionamento
        estacionamento.RemoverVeiculo("ABC1234");

        // Listando veículos novamente após a remoção
        estacionamento.ListarVeiculos();
    }
}
