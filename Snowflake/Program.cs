// See https://aka.ms/new-console-template for more information

using Snowflake;

Console.WriteLine("Hello, World!");

var renderer = new Renderer();
await renderer.Run();
Console.WriteLine("Goodbye, World!");