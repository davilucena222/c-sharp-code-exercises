const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

int indexQuantityOpen = input.IndexOf("<span>");
int indexQuantityClose = input.IndexOf("</span>");
indexQuantityOpen += 6;

int length = indexQuantityClose - indexQuantityOpen;
string quantity = input.Substring(indexQuantityOpen, length);

string changeInput = input.Replace("&trade", "&reg");
// string removingDivOpen = changeInput.Replace("<div>", "");
// string removingDivClose = removingDivOpen.Replace("</div>", "");
int divOpenIndex = changeInput.IndexOf("<div>");
int divCloseIndex = changeInput.IndexOf("</div>");
int divLengthOpen = "<div>".Length;
int divLengthClose = "</div>".Length; 
string temp = changeInput.Remove(divCloseIndex, divLengthClose);
string output = temp.Remove(divOpenIndex, divLengthOpen);

Console.WriteLine(quantity);
Console.WriteLine(output);

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here

// // Extract the quantity
// int quantityStart = input.IndexOf("<span>");
// int quantityEnd = input.IndexOf("</span>");
// quantityStart = quantityStart + "<span>".Length; // Added length of the tag so index moves to end of the tag
// System.Console.WriteLine("Quantity start: " + quantityStart);
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength); //Extracts from end of open tag to beginning of close tag
// quantity = $"Quantity: {quantity}";

// // Set output to input, replacing the trademark symbol with the registered trademark symbol
// output = input.Replace("&trade;", "&reg;");

// // Remove the opening <div> tag
// int divStart = input.IndexOf("<div>");
// int divLength = "<div>".Length;
// output = output.Remove(divStart, divLength);

// // Remove the closing <div> tag
// int divCloseStart = output.IndexOf("</div>");
// int divCloseLength = "</div>".Length;
// output = output.Remove(divCloseStart, divCloseLength);
// output = $"Output: {output}";

// Console.WriteLine(quantity);
// Console.WriteLine(output);