var lines = File.ReadAllLines("../files/input.txt");

var previousValue = 0;
var increasedCount = 0;
for (int i = 0; i < lines.Length; i++)
{
  var line = lines[i];
  if (int.TryParse(line.Trim(), out var value))
  {
    var increased = previousValue < value;
    if (i > 0 && increased)
    {
      increasedCount++;
    }

    var text = (i == 0) ? "N/A - no previous measurement" : (increased ? "increased" : "decreased");
    Console.WriteLine($"{value} ({text})");
    previousValue = value;
  }
}

Console.WriteLine($"There are {increasedCount} measurements that are larger than the previous measurement.");
Console.ReadLine();