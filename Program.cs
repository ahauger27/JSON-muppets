using System.IO;
using System.Text.Json;
using JSON_muppets;

string muppetJsonData = File.ReadAllText("muppets.json");

var muppets = JsonSerializer.Deserialize<List<Muppet>>(muppetJsonData);

if (muppets != null)
{
    foreach (Muppet muppet in muppets)
    {
        Console.WriteLine($"{Environment.NewLine}Name: {muppet.FirstName} {muppet.LastName}{Environment.NewLine}Species: {muppet.Species}{Environment.NewLine}Performer: {muppet.Performer}");
        
        if (muppet.Appearances != null)
        {
            Console.WriteLine($"Appearances: {string.Join(", ", muppet.Appearances)}");
        }
    }
}


