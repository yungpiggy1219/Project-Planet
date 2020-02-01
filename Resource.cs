using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource
{
    private SpriteRenderer sprite;
    private string resource_type;
    private int count;

    public Resource(string resource_type)
    {
        this.resource_type = resource_type;
        count = 0;
    }
    public int getCount()
    {
        return count;
    }
    public void allocate(int num)
    {
        count += num;
    }
    public void remove(int num)
    {
        count -= num;
    }
    public bool atLeast(int num)
    {
        return num <= count;
    }
}
