using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Ratio
{
    public int[] ratio;
    public Ratio(int num_resource_types, int[] specific_ratio)
    {
        if (!(num_resource_types < 1))
        {
            ratio = new int[num_resource_types];
            for (int i = 0; i < num_resource_types; i++)
            {
                ratio[i] = specific_ratio[i];
            }
        }
        else
        {
            ratio = specific_ratio;
        }
    }
}
