using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;

namespace Shouldly 
{
    [DebuggerStepThrough]
    [ShouldlyMethods]
    public static class ShouldBeDictionaryTestExtensions 
    {
#if NET40
        public static void ShouldContainKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
#else
        public static void ShouldContainKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
#endif
        {
            ShouldContainKey(dictionary, key, () => null);
        }

#if NET40
        public static void ShouldContainKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, string customMessage)
#else
        public static void ShouldContainKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, string customMessage)
#endif
        {
            ShouldContainKey(dictionary, key, () => customMessage);
        }

#if NET40
        public static void ShouldContainKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, [InstantHandle] Func<string> customMessage)
#else
        public static void ShouldContainKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, [InstantHandle] Func<string> customMessage)
#endif
        {
            if (!dictionary.ContainsKey(key))
                throw new ShouldAssertException(new ExpectedActualShouldlyMessage(key, dictionary, customMessage).ToString());
        }

#if NET40
        public static void ShouldNotContainKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
#else
        public static void ShouldNotContainKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
#endif
        {
            ShouldNotContainKey(dictionary, key, () => null);
        }

#if NET40
        public static void ShouldNotContainKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, string customMessage)
#else
        public static void ShouldNotContainKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, string customMessage)
#endif
        {
            ShouldNotContainKey(dictionary, key, () => customMessage);
        }

#if NET40
        public static void ShouldNotContainKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, [InstantHandle] Func<string> customMessage)
#else
        public static void ShouldNotContainKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, [InstantHandle] Func<string> customMessage)
#endif
        {
            if (dictionary.ContainsKey(key))
                throw new ShouldAssertException(new ExpectedActualShouldlyMessage(key, dictionary, customMessage).ToString());
        }

#if NET40
        public static void ShouldContainKeyAndValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val) 
#else
        public static void ShouldContainKeyAndValue<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue val) 
#endif
        {
            ShouldContainKeyAndValue(dictionary, key, val, () => null);
        }

#if NET40
        public static void ShouldContainKeyAndValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val, string customMessage)
#else
        public static void ShouldContainKeyAndValue<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue val, string customMessage)
#endif
        {
            ShouldContainKeyAndValue(dictionary, key, val, () => customMessage);
        }

#if NET40
        public static void ShouldContainKeyAndValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val, [InstantHandle] Func<string> customMessage)
#else
        public static void ShouldContainKeyAndValue<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue val, [InstantHandle] Func<string> customMessage)
#endif
        {
            if (!dictionary.ContainsKey(key) || !Equals(dictionary[key], val))
                throw new ShouldAssertException(new ExpectedActualKeyShouldlyMessage(val, dictionary, key, customMessage).ToString());
        }

#if NET40
        public static void ShouldNotContainValueForKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val)
#else
        public static void ShouldNotContainValueForKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue val)
#endif
        {
            ShouldNotContainValueForKey(dictionary, key, val, () => null);
        }

#if NET40
        public static void ShouldNotContainValueForKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val, string customMessage)
#else
        public static void ShouldNotContainValueForKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue val, string customMessage)
#endif
        {
            ShouldNotContainValueForKey(dictionary, key, val, () => customMessage);
        }

#if NET40
        public static void ShouldNotContainValueForKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val, [InstantHandle] Func<string> customMessage)
#else
        public static void ShouldNotContainValueForKey<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue val, [InstantHandle] Func<string> customMessage)
#endif
        {
            if (!dictionary.ContainsKey(key) || Equals(dictionary[key], val))
                throw new ShouldAssertException(new ExpectedActualKeyShouldlyMessage(val, dictionary, key, customMessage).ToString());
        }
    }
}
