using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Environment
{
    public Ratio ratio;
    public string name;
    public int tolerance;
    public Environment(int num_resource_types, string environmentName)
    {
        name = environmentName;
        int[] ret;
        switch (environmentName)
        {
            case "Ocean Reef":
                tolerance = 1;
                ret = new int[] { 7, 4, 2, 6 };
                ratio = new Ratio(num_resource_types, ret);
                break;
            case "Rainforest":
                tolerance = 2;
                 ret = new int[] { 6, 7, 5, 6};
                ratio = new Ratio(num_resource_types, ret);
                break;
            case "Forest":
                tolerance = 3;
                ret = new int[] { 5, 5, 5, 5};
                ratio = new Ratio(num_resource_types, ret);
                break;
            case "Desert":
                tolerance = 4;
                ret = new int[] { 1, 1, 1, 1 };
                ratio = new Ratio(num_resource_types, ret);
                break;
            default:
                tolerance = 0;
                ret = new int[] {0};
                ratio = new Ratio(0, ret);
                break;
        }
    }
}
