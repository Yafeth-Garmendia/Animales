using System;

public abstract class Avioticos: Metazos
{
    public int Patas { get; set; }
    public string ColorPlumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Vuela, libre paloma vuelaaa..");
    }
}