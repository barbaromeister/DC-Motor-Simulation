# DC Motor Speed Simulator

A simple C# console application to simulate the speed response of a DC motor to a step voltage input.

## Features
- User enters motor parameters (K, J, B), applied voltage, simulation duration, and time step.
- Simulates angular speed (`omega`) over time.
- Prints speed at each step and shows a basic ASCII graph.

## Usage

1. Open a terminal in the project folder.
2. Build and run:
   ```
   dotnet run
   ```
3. Enter the requested parameters.

## Example Output

```
=== DC Motor Speed Simulator ===
Motor sabiti K (ör. 0.1): 0.1
Atalet momenti J (ör. 0.01): 0.01
Sürtünme katsayısı B (ör. 0.001): 0.001
Uygulanan voltaj V (ör. 12): 12
Simülasyon süresi (saniye): 5
Zaman adımı (dt, ör: 0.1): 0.1
t=0.00 s | Omega (rad/s): 12.000
t=0.10 s | Omega (rad/s): 23.880
...
=== Hızın Zamana Göre ASCII Grafiği ===
************
***********************
*******************************
...
```