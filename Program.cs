

string horn = "./files/horn.txt";
string data = "./files/data.txt";
string mData = "moredata.txt";
void P(string input)
{
    Console.WriteLine(input);
}
// string fileContent = File.ReadAllText("./files/data.txt");
// Console.WriteLine(fileContent);

// string[] lines = File.ReadAllLines("./files/data.txt");
// foreach (string line in lines)
// {
//     Console.WriteLine(line);
// }
// using System.Text;

// using System.Reflection.Metadata;

// string[] lines = File.ReadAllLines("./files/data.txt");
// foreach (string line in lines)
// {
//     Console.WriteLine(line[3]);
// }

// using (StreamReader reader = new StreamReader("./files/data.txt"))
// {
//     string line;
//     while ((line = reader.ReadLine()!) != null)
//     {
//         Console.WriteLine(line);
//     }
//     //usign stänger automatiskt stringreader när blocket är färdigt

// // }
// string text = " hello me i am";
// File.WriteAllText("./files/horn.txt", text);
// File.WriteAllLines("./files/horn.txt",new [] {text});
// text = "fort si me";
// string more = "\nhehe";
// File.WriteAllText("./files/horn.txt", text);
// File.AppendAllText("./files/horn.txt", more);
// File.AppendAllText("./files/horn.txt", more);
// using (StreamReader nreader = new StreamReader("./files/horn.txt"))
// {
//     string line;
//     while ((line = nreader.ReadLine()!) != null)
//     {
//         Console.WriteLine(line);
//     }
//     //usign stänger automatiskt stringreader när blocket är färdigt



// // }


// void AddText()
// {
//     string input = Console.ReadLine();
//     File.AppendAllLines("./files/horn.txt", new[] { input });


// }
// File.WriteAllLines(horn, new[] { "start" });
// AddText();
// AddText();
// AddText();

// string alltext = File.ReadAllText("./files/horn.txt");
// Console.WriteLine(alltext);

// File.AppendAllText(mData, " ");
// using (StreamWriter writer = new StreamWriter(mData))
// {
//     writer.WriteLine("first");
//     writer.WriteLine("second");
//     writer.WriteLine("third");
// }
// string text = File.ReadAllText(mData);
// P(text);

// StreamReader reader = new StreamReader(mData);
// string content = reader.ReadToEnd();
// P(content);
// reader.Close();

string folder = "./files/";
string fullPathHorn = Path.Combine(folder, mData);
StreamReader reader = new StreamReader(fullPathHorn);
// string text = File.ReadAllText(fullPathHorn);
// P(text);
// string texts = File.ReadAllText(data);
// P(texts);



string folde = Path.GetDirectoryName(fullPathHorn);

if (Directory.Exists(folde))
{
    P($"folder does not exist.. creating {folde}");
    Directory.CreateDirectory(folde);
}
else
{
    P($"folder alradey exists");

}
File.WriteAllText(fullPathHorn, "yay existense");
