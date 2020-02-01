using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet:MonoBehaviour
{
    private Environment env;
    private Resource[] resources_polluted;
    private Resource[] resources;
    private SpriteRenderer sprite;

    public Planet(string env_type)
    {
        env = new Environment(num_planets , env_type);
        resources_polluted = new Resource[num_planets];
        resources = new Resource[num_planets];
    }
    private void receiveResource(string resource_name, int count)
    {
       switch (resourceName){
            case "water":
                resources[0].allocate(count);
                break;
            case "sunlight":
                resources[1].allocate(count);
                break;
            case "ozone":
                resources[2].allocate(count);
                break;
            case "nutrients":
                resources[3].allocate(count);
                break;
    }
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

    private Environment getEnv()
    {
        return env;
    }
}
