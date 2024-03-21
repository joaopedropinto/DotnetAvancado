namespace Atividade3.Classes;
public class Worker
{
    public void Work()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.Name}: Trabalho em andamento... {i}/10");
            Thread.Sleep(1000);
        }
        Console.WriteLine($"Thread {Thread.CurrentThread.Name}: Trabalho concluído.");
    }
}