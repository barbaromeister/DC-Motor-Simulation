using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== DC Motor Speed Simulator ===");

        Console.Write("Motor sabiti K (ör. 0.1): ");
        double K = double.Parse(Console.ReadLine());

        Console.Write("Atalet momenti J (ör. 0.01): ");
        double J = double.Parse(Console.ReadLine());

        Console.Write("Sürtünme katsayısı B (ör. 0.001): ");
        double B = double.Parse(Console.ReadLine());

        Console.Write("Uygulanan voltaj V (ör. 12): ");
        double V = double.Parse(Console.ReadLine());

        Console.Write("Simülasyon süresi (saniye): ");
        double simTime = double.Parse(Console.ReadLine());

        Console.Write("Zaman adımı (dt, ör: 0.1): ");
        double dt = double.Parse(Console.ReadLine());

        var motor = new DCMotor(K, J, B);

        List<double> speedHistory = new List<double>();

        for (double t = 0; t <= simTime; t += dt)
        {
            motor.Step(V, dt);
            speedHistory.Add(motor.Omega);
            Console.WriteLine($"t={t:F2} s | Omega (rad/s): {motor.Omega:F3}");
        }

        // Basit ASCII grafik
        Console.WriteLine("\n=== Hızın Zamana Göre ASCII Grafiği ===");
        foreach (var speed in speedHistory)
        {
            int n = (int)Math.Round(speed * 2); // Görsellik için çarpan
            n = Math.Max(n, 0);
            Console.WriteLine(new string('*', n));
        }
    }
}