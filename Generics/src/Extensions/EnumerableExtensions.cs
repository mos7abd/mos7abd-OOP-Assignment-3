using GenericsLab.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab.Extensions
{

    public static class EnumerableExtensions
    {
        // R1: Return only the items belonging to the requested page.
        public static IEnumerable<T> Page<T>(
            this IEnumerable<T> source,
            int pageNumber,
            int pageSize)
        {
            if (pageNumber <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(pageNumber), "Page number must be greater than zero.");

            if (pageSize <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(pageSize), "Page size must be greater than zero.");

            var startIndex = (pageNumber - 1) * pageSize;
            var currentIndex = 0;
            var returnedItems = 0;

            foreach (var item in source)
            {
                if (currentIndex >= startIndex && returnedItems < pageSize)
                {
                    yield return item;
                    returnedItems++;
                }

                if (returnedItems == pageSize)
                    yield break;

                currentIndex++;
            }
        }

        public static T? FindById<T>(this IEnumerable<T> source, int id)
            where T : IHasId
        {
            foreach (var item in source)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return default;
        }


        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
            this IEnumerable<T> source)
            where T : IHasId
        {
            var dictionary = new Dictionary<int, T>();

            foreach (var item in source)
            {
                if (dictionary.ContainsKey(item.Id))
                {
                    throw new InvalidOperationException(
                        $"An item with ID {item.Id} already exists.");
                }

                dictionary.Add(item.Id, item);
            }

            return dictionary;
        }

    }

}
