using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {//Takes a list of any objects and for each object swaps each object with a random object in the list
        System.Random rng = new System.Random();
                
        int n = list.Count;

        while (n > 1)
        {//Every card gets swapped around
            n--;
            //location k becomes a random integer between the first card and the last card
            int k = rng.Next(n + 1);

            //Stores the object in location K
            T value = list[k];

            //location k now holds the object in location n
            list[k] = list[n];

            //location n now holds the original object from location k
            list[n] = value;
        }
    }
}
