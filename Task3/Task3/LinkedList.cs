namespace Task3;

public class LinkedList
{
    private LinkedListNode _first;
    private LinkedListNode _last;
    public void Add(KeyValuePair pair)
    {
        var node = new LinkedListNode(pair);
        if (_first==null)
        {
            _first = node;
            _last = node;
        }
        else
        {
            _last.Next = node;
            _last = node;
        }
        
    }

    public void RemoveByKey(string key)
    {
        var curNode = _first;
        LinkedListNode previous = null;
        while (curNode!=null)
        {
            if (curNode.Pair.Key==key)
            {
                if (previous==null)
                {
                    _first = curNode.Next;
                }
                else
                {
                    previous.Next = curNode.Next;
                }
                //del
                return;
            }

            previous = curNode;
            curNode = curNode.Next;
        }
    }

    public KeyValuePair GetItemWithKey(string key)
    {
        var curNode = _first;
        LinkedListNode previous = null;
        // get pair with provided key, return null if not found
        while (curNode!=null)
        {
            if (curNode.Pair.Key==key)
            {
                if (previous==null)
                {
                    _first = curNode.Next;
                }
                else
                {
                    previous.Next = curNode.Next;
                }
                //del
                return curNode.Pair;
            }

            //previous = curNode;
            curNode = curNode.Next;
        }
        return null;
    }
}