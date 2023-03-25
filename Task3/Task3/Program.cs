
using Task3;
using KeyValuePair = Task3.KeyValuePair;


 var Dict = new StringsDictionary();

 var  Words= File.ReadAllLines("C:\\Users\\Давід\\RiderProjects\\Task3\\Task3\\Words.txt");
 //List<String> Words=new List<string>();
 for (int i = 0; i < Words.Length; i++)
 {
  var split=Words[i].Split("; ");
  var Word = split[0];
  var Def = split[1];
  Dict.Add(Word, Def);
  
 // if (Dict.CalculateLoadFactor()<10)
 // {
   
 // }
 }
 Console.WriteLine(Dict.Get("IMITATOR"));
 
 