namespace Task3;

public class StringsDictionary
{
    private const int InitialSize = 10;

    private LinkedList[] _buckets = new LinkedList[InitialSize];
        
    public void Add(string key, string value)
    {
        KeyValuePair Pair = new KeyValuePair(key, value);
       
        var Bucket = CalculateHash(key) % _buckets.Length;
        if (_buckets[Bucket]==null)
        {
            _buckets[Bucket] = new LinkedList();
        }
        _buckets[Bucket].Add(Pair);


    }

    public void Remove(string key)
    {
        var Bucket = CalculateHash(key) % _buckets.Length;    
        if (_buckets[Bucket]==null)
        {
            Console.WriteLine("not exists");
        }
        else
        {
            _buckets[Bucket].RemoveByKey(key);
        }
    }

    public string Get(string key)
    {
        
        var Bucket = CalculateHash(key) % _buckets.Length;
       
        if (_buckets[Bucket]==null)
        {
            Console.WriteLine("not exists");
        }
        else
        {
            var check = _buckets[Bucket].GetItemWithKey(key);
            if (check==null)
            {
                return null;
            }

            return   check.Value;
        }

        return null;
    }


    private long CalculateHash(string key)
    {
        long finalHash = 0;
        for (int i = 0; i < key.Length; i++)
        {
            finalHash += Convert.ToInt64(key[i]) * Convert.ToInt64(Math.Pow(2, i + 1));
            
        }
        //Console.WriteLine("dsd");
        return finalHash;
        
        // function to convert string value to number 
    }

    public void CalculateLoadFactor()
    {
        int empty = 0;
        int filles = 0;
        int loadFactor = 0;
        
        for (int i = 0; i < _buckets.Length; i++)
        {
            if (_buckets[i]==null)
            {
                empty += 1;
            }
            else
            {
                filles += 1;
            }
        }

        loadFactor = empty / filles;
        
        
    }
    
    
}