using GenericsLab.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab.Stores
{
    // Step 4: Replaces StudentStore and CourseStore with one reusable generic store.
    public class Store<T> where T : IHasId
    {
        private readonly List<T> _items = new();

        // Add: Add an item to the store.
        public void Add(T item)
        {
            _items.Add(item);
        }

        // GetById: Intentionally causes a compile-time error in Step 3.
        public T? GetById(int id)
        {
            foreach (var item in _items)
            {
                if (item.Id == id)
                    return item;
            }

            return default;
        }

        // GetAll: Return all items.
        public List<T> GetAll()
        {
            return _items;
        }

        // Remove: Remove an item by its ID.
        public void Remove(int id)
        {
            var item = GetById(id);

            if (item is not null)
                _items.Remove(item);
        }
    }

}
