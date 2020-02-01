using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private Resource[] resources;
    private Resource[] resources_polluted;
    
    public Player(Resource[] r, Resource[] rp)
    {
        resources = r;
        resources_polluted = rp;
    }
}
