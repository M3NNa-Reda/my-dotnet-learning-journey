namespace Delegate
{
    public static class CustomQueryExtensions
    {
        public static List<T> Filter<T>(this IEnumerable<T> source, Func<T, bool>predicate)
        {
            if (source == null || predicate == null) throw new ArgumentNullException();
            List<T> result = new List<T>();
            foreach (var item in source)
            {
                if(predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<TResult> Transform<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
        {
            if (source == null || selector == null) throw new ArgumentNullException();

            List<TResult> result = new List<TResult>();
            foreach (var item in source)
            {
                result.Add(selector(item));
            }
            return result;
        }
        public static List<T> SortBy<T, TKey>(
            this IEnumerable<T> source,
            Func<T, TKey> keySelector) where TKey : IComparable<TKey>
        {
            if (source == null || keySelector == null) throw new ArgumentNullException();
            List<T> list = source.ToList();
            bool swapped;
            for (int i = 0; i < list.Count; i++)
            {
                swapped = false;
                for (int j = 0; j < list.Count-i-1; j++)
                {
                    var keyA = keySelector(list[j]);
                    var keyB = keySelector(list[j + 1]);
                    var res = keyA.CompareTo(keyB);
                    if (res>0)
                    {
                        var temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                        swapped = true;
                    }
                    
                }
                if (!swapped)
                    break;
            }

            return list;
        }

        public static List<T> ToFreshList<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException();
            List<T> list = source.ToList();
            return list;
        }

        public static bool HasAny<T>(this IEnumerable<T> source)
        {
            if (source == null) return false;
            foreach (var item in source)
            {
                    return true;
            }
            return false;
        }

        public static bool HasAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null) return false;
            foreach (var item in source)
            {
                if (predicate(item))
                    return true;
            }
            return false;
        }
        public static bool MatchAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null || predicate == null) throw new ArgumentNullException();
            foreach (var item in source)
            {
                if(!predicate(item))
                    return false;
            }
            return true;
        }
        public static int CountWhere<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException();
            int count = 0;
            foreach (var item in source)
            {
                count++;
            }
            return count;
        }
        public static int CountWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null || predicate == null) throw new ArgumentNullException();
            int count = 0;
            foreach (var item in source)
            {
                if (predicate(item))
                    count++;
            }
            return count;
        }
        public static T? FindFirst<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (predicate == null) throw new ArgumentNullException();
            foreach (var item in source)
            {
                if(predicate(item))
                    return item;
            }
            return default(T);
        }

        public static List<T> SortByDescending<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector) where TKey : IComparable<TKey>
        {
            List<T> list = source.SortBy(keySelector);
            List<T> result = new List<T>(list.Count);
            for (int i = list.Count - 1; i >= 0; i--) 
            {
                result.Add(list[i]);
            }
            return result;
        }
        public static List<T> TakeFirst<T>(this IEnumerable<T> source, int count)
        {
            if (source == null) throw new ArgumentNullException();
            if(count < 0) throw new ArgumentOutOfRangeException();
            List<T> result = new List<T>();
            if (count == 0) return result;
            int c = 0;
            foreach (var item in source)
            {
                result.Add(item);
                c++;
                if (c == count) break;
            }
            return result;
        }

    }
}
