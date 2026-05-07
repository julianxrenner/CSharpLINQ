using System.ComponentModel;
using System.Xml.Linq;

var myBuildings = new List<Building>{
  new (1000, 10, "Small Buidling"),
  new(10000, 7, "Big Buidling"),
  new(100000, 5, "Bigger Builing"),
  new(100000, 5, "Bigger Builing 2"),
  new(100000, 5, "Bigger Builing 3")
};

var calculatedTaxes = myBuildings.Select(building => building.TaxPerSize * building.Size);
var querySyntaxCalculatedTaxes = from building in myBuildings select building.TaxPerSize * building.Size;
foreach (var tax in calculatedTaxes)
{
  Console.WriteLine(tax);
}

Console.WriteLine("");

foreach (var tax in querySyntaxCalculatedTaxes)
{
  Console.WriteLine(tax);
}

Console.WriteLine("");

var totalTaxes = myBuildings.Select(building=>building.Size * building.TaxPerSize).Sum();
var querySyntaxTotalTaxes = (from building in myBuildings select building.Size * building.TaxPerSize).Sum();
Console.WriteLine(totalTaxes);

Console.WriteLine("");

var bigBuildings = myBuildings.Select(building=>building.Size).Where(size=>size>1000);
foreach (var building in bigBuildings)
{
  Console.WriteLine(building);
}

Console.WriteLine("");

var buildingsAscending = myBuildings.OrderBy(building => building.Size);
var buildingsDescending = myBuildings.OrderByDescending(building => building.Size);

foreach (var building in buildingsAscending)
{
  Console.WriteLine(building);
}

Console.WriteLine("");

foreach (var building in buildingsDescending)
{
  Console.WriteLine(building);
}

Console.WriteLine("");

var groupBySize = myBuildings.GroupBy(building=>building.Size);
foreach (var group in groupBySize)
{
  Console.WriteLine($"Size Group: {group.Key}");
  foreach (var building in group)
  {
    Console.WriteLine($"Building Name: {building.Name}");
  }
}

record Building(int Size, int TaxPerSize, string Name);