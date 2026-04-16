using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ConsoleAppDemoJson
{
  internal class Program
  {
    static void Main()
    {
      Personne p = new Personne { Nom = "Alice", Age = 25 };

      string json = JsonSerializer.Serialize(p);

      Console.WriteLine(json);

      json = "{\"Nom\":\"Alice\",\"Age\":25}";

      p = JsonSerializer.Deserialize<Personne>(json);

      Console.WriteLine(p.Nom); // Alice

      var e = new Etudiant
      {
        Nom = "Lucas",
        Age = 20,
        Notes = new List<int> { 12, 15, 18 }
      };

      json = JsonSerializer.Serialize(e);
      Console.WriteLine(json);

      var options = new JsonSerializerOptions
      {
        WriteIndented = true
      };

      json = JsonSerializer.Serialize(e, options);
      Console.WriteLine(json);

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
