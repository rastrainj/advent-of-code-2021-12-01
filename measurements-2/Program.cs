var lines = File.ReadAllLines("../files/input.txt");

var increasedCount = 0;
var previousSum = 0;
var threeMasurements = new int[3] { 0, 0, 0 };
for (int i = 0; i < lines.Length - 2; i++)
{
  var line1 = lines[i];
  var line2 = lines[i + 1];
  var line3 = lines[i + 2];
  if (int.TryParse(line1.Trim(), out var value1)
    && int.TryParse(line2.Trim(), out var value2)
    && int.TryParse(line3.Trim(), out var value3))
  {
    var sum = value1 + value2 + value3;
    var increased = sum > previousSum;
    if (i > 0 && increased)
    {
      increasedCount++;
    }

    var text = (i == 0) ? "N/A - no previous measurement" : ((sum == previousSum) ? "no change" : (increased ? "increased" : "decreased"));
    Console.WriteLine($"{sum} ({text})");

    previousSum = sum;
  }
}

Console.WriteLine($"There are {increasedCount} measurements that are larger than the previous measurement.");
Console.ReadLine();