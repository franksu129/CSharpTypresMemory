// See https://aka.ms/new-console-template for more information
using CSharpTypresMemory;

Console.WriteLine("Hello, World!");

Console.WriteLine($"--- Stack memory view ---");
ValueTypeTest.MemoryAddressView();
ValueTypeTest.Duplicate();
Console.WriteLine($"--- Over ---");



Console.WriteLine($"--- Heap memory view ---");
ReferenceTypeTest.MemoryAddressView();
ReferenceTypeTest.Duplicate();
Console.WriteLine($"--- Over ---");
