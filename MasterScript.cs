using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterScript : MonoBehaviour
{
    private Player player;
    private Planet[] planets; 

    const int num_planets = 4;
    private string[] env_names = { "Ocean Reef", "Jungle", "Forest", "Desert" };
    const int planet_resource_factor = 250;
    // Start is called before the first frame update
    void Start()
    {
        planets = new Planet[num_planets];
        for(int i = 0; i < num_planets; i++) // make planets
        {
            planets[i] = new Planet(env_names[i]); // each planet represents an ecosystem
            int[] goldenRatio = planets[i].getEnv().getGoldenRatio(); // get golden ratios of each resource of that environment
            int sum = 0; 
            for(int j = 0; j < num_planets; j++)
            {
                sum += goldenRatio[j]; // add up ratios
            }
            int dividend = (int)(planet_resource_factor / sum);
            for(int k = 0; k < num_planets; k++)
            {
                planets.recieveResource(dividend*goldenRatio[i]);
            }
        }
        int[] r = new int[num_planets];
        int[] rp = new int[num_planets];

        player = new Player(r, rp); // make player
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
