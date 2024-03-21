using Atividade3.Classes;

#region Exercicio 1
Console.WriteLine($"Exercicio 1");

List<double> lista = new List<double> { 3, 7, 2, 4, 6 };
List<double> novaLista = lista.ConvertAll(x => x / 2);
novaLista.ForEach(x => Console.WriteLine(x));

#endregion

#region Exercicio 2
Console.WriteLine($"\nExercicio 2");

List<ItemMercado> itensMercado = new List<ItemMercado>
{
    new ItemMercado { Nome = "Arroz", Tipo = Tipo.Comida, Preco = 3.90 },
    new ItemMercado { Nome = "Azeite", Tipo = Tipo.Comida, Preco = 2.50 },
    new ItemMercado { Nome = "Macarrão", Tipo = Tipo.Comida, Preco = 3.90 },
    new ItemMercado { Nome = "Cerveja", Tipo = Tipo.Bebida, Preco = 22.90 },
    new ItemMercado { Nome = "Refrigerante", Tipo = Tipo.Bebida, Preco = 5.50 },
    new ItemMercado { Nome = "Shampoo", Tipo = Tipo.Higiene, Preco = 7.00 },
    new ItemMercado { Nome = "Sabonete", Tipo = Tipo.Higiene, Preco = 2.40 },
    new ItemMercado { Nome = "Cotonete", Tipo = Tipo.Higiene, Preco = 5.70 },
    new ItemMercado { Nome = "Sabão em pó", Tipo = Tipo.Limpeza, Preco = 8.20 },
    new ItemMercado { Nome = "Detergente", Tipo = Tipo.Limpeza, Preco = 2.60 },
    new ItemMercado { Nome = "Amaciante", Tipo = Tipo.Limpeza, Preco = 6.40 }
};

var higieneOrdenadaPorPrecoDecrescente = itensMercado
    .Where(item => item.Tipo == Tipo.Higiene)
    .OrderByDescending(item => item.Preco)
    .ToList();

var itensPrecoMaiorOuIgualA5 = itensMercado
    .Where(item => item.Preco >= 5.00)
    .OrderBy(item => item.Preco)
    .ToList();

var comidaBebidaOrdenadaPorNome = itensMercado
    .Where(item => item.Tipo == Tipo.Comida || item.Tipo == Tipo.Bebida)
    .OrderBy(item => item.Nome)
    .ToList();

var quantidadePorTipo = itensMercado
    .GroupBy(item => item.Tipo)
    .Select(g => new { Tipo = g.Key, Quantidade = g.Count() })
    .ToList();

var estatisticasPorTipo = itensMercado
    .GroupBy(item => item.Tipo)
    .Select(g => new
    {
        Tipo = g.Key,
        PrecoMaximo = g.Max(item => item.Preco),
        PrecoMinimo = g.Min(item => item.Preco),
        PrecoMedio = g.Average(item => item.Preco)
    })
    .ToList();

Console.WriteLine("Itens de Higiene ordenados por preço decrescente:");
foreach (var item in higieneOrdenadaPorPrecoDecrescente)
{
    Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
}

Console.WriteLine("\nItens com preço maior ou igual a R$ 5,00 ordenados por preço crescente:");
foreach (var item in itensPrecoMaiorOuIgualA5)
{
    Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
}

Console.WriteLine("\nItens de Comida ou Bebida ordenados por nome:");
foreach (var item in comidaBebidaOrdenadaPorNome)
{
    Console.WriteLine($"{item.Nome} - {item.Tipo}");
}

Console.WriteLine("\nQuantidade de itens por tipo:");
foreach (var item in quantidadePorTipo)
{
    Console.WriteLine($"{item.Tipo}: {item.Quantidade}");
}

Console.WriteLine("\nEstatísticas de preço por tipo:");
foreach (var item in estatisticasPorTipo)
{
    Console.WriteLine($"Tipo: {item.Tipo}");
    Console.WriteLine($"Preço Máximo: R$ {item.PrecoMaximo}");
    Console.WriteLine($"Preço Mínimo: R$ {item.PrecoMinimo}");
    Console.WriteLine($"Preço Médio: R$ {item.PrecoMedio}");
    Console.WriteLine();
}
#endregion

#region Exercicio 3
Console.WriteLine($"\nExercicio 3\n");
Worker worker1 = new Worker();
Worker worker2 = new Worker();

Thread thread1 = new Thread(worker1.Work);
thread1.Name = "1";
Thread thread2 = new Thread(worker2.Work);
thread2.Name = "2";

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

Console.WriteLine("Ambas as threads terminaram. Programa encerrado.");
#endregion

#region Exercicio 4
Console.WriteLine($"\nExercicio 4\n");

static async Task TestAsync()
{
    await Task.WhenAll(DoWorkAsync("Tarefa 1"), DoWorkAsync("Tarefa 2"));

    Console.WriteLine("Ambas as tarefas foram concluídas.");
}

static async Task DoWorkAsync(string taskName)
{
    Console.WriteLine($"{taskName} iniciada.");

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"{taskName}: Trabalho em andamento... {i}/5");
        await Task.Delay(1000); 
    }

    Console.WriteLine($"{taskName} concluída.");
}
await TestAsync();
#endregion