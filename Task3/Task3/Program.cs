
using Task3;
using KeyValuePair = Task3.KeyValuePair;


 var Dict = new StringsDictionary();

 var  Words= File.ReadAllLines("C:\\Users\\Давід\\RiderProjects\\Task3\\Task3\\Words.txt");
 
 
 
 List<String> WordList=new List<string>();
 for (int i = 0; i < Words.Length; i++)
 {
  var split=Words[i].Split("; ");
  var Word = split[0];
  var Def = split[1];
  WordList.Add(Word);
  Dict.Add(Word, Def);
  
 
 }

 var wordEnter = Console.ReadLine();
 if (WordList.Contains(wordEnter))
 {
 // Console.WriteLine(Dict.Get("IMITATOR"));
  Console.WriteLine(Dict.Get(wordEnter));
 }
 else
 {
  findClosest(wordEnter,WordList);
  
 }

 void findClosest(string value, List<string> Startlist)
 {
  int SameWordPoints = 0;
  Dictionary<string, int> Word_Points = new Dictionary<string, int>();
  for (int i = 0; i < Startlist.Count; i++)
  {
   //
   if (value.Length==Startlist[i].Length)
   {
    //
    for (int j = 0; j < Startlist[i].Length; j++ )
    {
     //
     if (value[j]==Startlist[i][j])
     {
      SameWordPoints += 1;
      
     }
     //
    }

    if (SameWordPoints>0)
    {
     Word_Points.Add(Startlist[i], SameWordPoints);
     SameWordPoints = 0;
    }
    //
   }
   //
  }

  var Sorted_Word_Points = Word_Points.OrderByDescending(x => x.Value);
Console.WriteLine("Your word is incorrect, maybe you wanted to write:");
var count = 0;
  foreach (var VARIABLE in Sorted_Word_Points)
  {
   count += 1;
   Console.WriteLine(VARIABLE.Key);
   if (count>2)
   {
    break;
   }
  }
  
 }


 
 