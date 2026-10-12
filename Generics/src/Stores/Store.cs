using GenericsLab.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab.Stores
{

    public class Store<T> where T : IHasId
    {
        private readonly Dictionary<int, T> _items = new();

        // Add: Add an item and prevent duplicate IDs.
        public void Add(T item)
        {
            if (_items.ContainsKey(item.Id))
            {
                throw new InvalidOperationException(
                    $"An item with ID {item.Id} already exists.");
            }

            _items.Add(item.Id, item);
        }

        // GetById: Find an item directly using its ID.
        public T? GetById(int id)
        {
            if (_items.TryGetValue(id, out var item))
            {
                return item;
            }

            return default;
        }

        // GetAll: Return a read-only snapshot of all items.
        public IReadOnlyCollection<T> GetAll()
        {
            var snapshot = new List<T>();

            foreach (var item in _items.Values)
            {
                snapshot.Add(item);
            }

            return snapshot.AsReadOnly();
        }

        // Remove: Remove an item using its ID.
        public void Remove(int id)
        {
            _items.Remove(id);
        }
    }


}
