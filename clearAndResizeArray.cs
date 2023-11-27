string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

int counter = 0;
for(int i = 0; i < pallets.Length; i++) {
    if (pallets[i] != null) {
        counter += 1;
    }
}

System.Console.WriteLine($"A matriz pallets tem {counter} itens não nulos");
System.Console.WriteLine("");

string[] palletesNonNull = new string[counter];
int j = 0;

for(int i = 0; i < pallets.Length; i++) {
    if (pallets[i] != null && j < palletesNonNull.Length) {
        palletesNonNull[j] = pallets[i];
        j++;
    } 
}

System.Console.WriteLine($"A matriz palletesNonNull tem {palletesNonNull.Length} itens não nulos");

foreach(string item in palletesNonNull) {
    System.Console.WriteLine(item);
}