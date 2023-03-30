using System.Collections;

namespace Task3;

public class LinkedList : IEnumerable
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

    public int Count()
    {
        var curNode = _first;
        LinkedListNode previous = null;
        int elnum = 0;
        while (curNode!=null)
        {
            elnum += 1;
            curNode = curNode.Next;
        }

        return elnum;
    }
    public IEnumerator GetEnumerator()
    {
        var curNode = _first;
        while (curNode.Next!=null)
        {
            yield return curNode;
            curNode = curNode.Next;
        }
    }
}