using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet
{
    public GameObject planet;
    private Environment env;
    private Resource[] resources_polluted;
    private Resource[] resources;
    private Sprite sprite;
    const int num_planets = 4;

    public Planet(Environment env)
    {
        this.env = env;
        resources = new Resource[num_planets];
        resources_polluted = new Resource[num_planets];
        sprite = sprite = Resources.Load<Sprite>("desert");
    }
    public void receiveResources(int resource_type, int amount)
    {
        resources[resource_type].allocate(amount);
    }
    private Resource[] getResources()
    {
        return resources;
    }

    private Resource[] getResourcesPolluted()
    {
        return resources_polluted;
    }

    private int pollute(int resource_type, int amount) // function that removes resourses at index and adds them to resources_polluted
    {
        if (resources[resource_type].getCount() >= amount){ // if there are more resources than deduction amount
            resources[resource_type].remove(amount);
            resources_polluted[resource_type].allocate(amount);
            return 0; // all can be deducted here, return 0
        }
        else { // otherwise if there isn't enough to deduct from this planet
            int dum = resources[resource_type].getCount(); 
            resources[resource_type].remove(resources[resource_type].getCount());
            resources_polluted[resource_type].allocate(dum);
            return amount - dum; // return non-zero integer which represents deductions to be made
        }
    }

    private void abate(int resource_type, int amount)
    {
        resources_polluted[resource_type].remove(amount);
        resources[resource_type].allocate(amount);
    }
    public Environment getEnv()
    {
        return env;
    }
}
