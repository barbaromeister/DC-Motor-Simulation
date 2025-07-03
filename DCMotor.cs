using System;

public class DCMotor
{
    public double K { get; set; }   // Motor sabiti (V/(rad/s))
    public double J { get; set; }   // Atalet momenti (kg*m^2)
    public double B { get; set; }   // Sürtünme katsayısı (N*m*s)
    public double V { get; set; }   // Uygulanan voltaj (V)

    public double Omega { get; private set; } // Açısal hız (rad/s)

    public DCMotor(double k, double j, double b)
    {
        K = k;
        J = j;
        B = b;
        Omega = 0.0;
    }

    // Bir zaman adımı için hız güncelle
    public void Step(double voltage, double dt)
    {
        // Basit model: J*dω/dt + B*ω = K*V => dω/dt = (K*V - B*ω)/J
        double domega = (K * voltage - B * Omega) / J;
        Omega += domega * dt;
    }
}