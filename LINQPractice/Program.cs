using System.ComponentModel;

var myBuildings = new List<Building>{
  new (1000, 10, "Small Buidling"),
  new(10000, 7, "Big Buidling"),
  new(100000, 5, "Bigger Builing")
};

var calculatedTaxes = myBuildings.Select(building => building.TaxPerSize * building.Size);

foreach (var tax in calculatedTaxes)
{
  Console.WriteLine(tax);
}

record Building(int Size, int TaxPerSize, string Name);