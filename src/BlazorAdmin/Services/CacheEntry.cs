using System;

namespace BlazorAdmin.Services;

public class CacheEntry<T>
{
    public CacheEntry(T item)
    {
        Value = item;
    }

    public CacheEntry()
    {
    }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public T Value { get; set; }
}
