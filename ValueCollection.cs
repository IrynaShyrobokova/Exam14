using System;
using System.Collections.Generic;
using System.Linq;

public class ValueCollection<T> where T : struct
{
    private List<T> items = new List<T>();

    // Method to add items to the private collection
    public void AddItem(T item)
    {
        items.Add(item);
    }

    // Method to return an item at a specific index
    public T GetItem(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        return items[index];
    }

    // Method to return the collection sorted in descending order
    public List<T> GetSortedDescending()
    {
        return items.OrderByDescending(x => x).ToList();
    }
}
