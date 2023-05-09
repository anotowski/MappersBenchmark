``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


```
|                Method |     N |      Mean |     Error |    StdDev | Ratio | RatioSD | Rank |   Gen0 |   Gen1 | Allocated | Alloc Ratio |
|---------------------- |------ |----------:|----------:|----------:|------:|--------:|-----:|-------:|-------:|----------:|------------:|
|    Mapster_SingleItem | 10000 |  1.936 μs | 0.0386 μs | 0.0445 μs |  1.00 |    0.00 |    1 | 2.1553 | 0.0992 |  13.21 KB |        1.00 |
|   Mapperly_SingleItem | 10000 |  2.246 μs | 0.0447 μs | 0.0497 μs |  1.16 |    0.04 |    2 | 2.2392 | 0.1030 |  13.73 KB |        1.04 |
| Automapper_SingleItem | 10000 | 15.617 μs | 0.3088 μs | 0.3171 μs |  8.10 |    0.25 |    3 | 2.9907 | 0.1221 |  18.45 KB |        1.40 |
