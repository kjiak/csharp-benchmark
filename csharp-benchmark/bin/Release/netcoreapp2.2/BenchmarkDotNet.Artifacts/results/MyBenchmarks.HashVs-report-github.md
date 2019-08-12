``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
Frequency=1945312 Hz, Resolution=514.0564 ns, Timer=TSC
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
| Method |     Mean |     Error |    StdDev |
|------- |---------:|----------:|----------:|
|    Md5 | 40.71 us | 0.0481 us | 0.0450 us |
|   Sha1 | 37.08 us | 0.0262 us | 0.0204 us |
| Sha256 | 88.88 us | 0.1130 us | 0.1057 us |
| Sha384 | 53.47 us | 0.0793 us | 0.0703 us |
| Sha512 | 53.40 us | 0.0678 us | 0.0566 us |
