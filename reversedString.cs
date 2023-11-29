string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramChar = pangram.Split(" "); 
string[] reversedPangram = new string[pangramChar.Length]; // ["ehT", "kciuq", ...] 
string finalPangram = "";

for(int i = 0; i < pangramChar.Length; i++) {
    char[] valueArray = pangramChar[i].ToCharArray();
    Array.Reverse(valueArray);
    reversedPangram[i] = String.Join("", valueArray);
    // reversedPangram[i] = new string(valueArray);
}

foreach(string s in reversedPangram) {
    finalPangram += s + " ";
}

System.Console.WriteLine(finalPangram);