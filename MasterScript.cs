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
    public GameObject ptOceanReef, ptJungle, ptForest, ptDesert;
    // Start is called before the first frame update
    void Start()
    {
        planets = new Planet[num_planets];
        int[] goldenRatio = new int[num_planets];
        for (int i = 0; i < num_planets; i++) // make planets
        {
            planets[i] = new Planet(new Environment(num_planets, env_names[i])); // each planet represents an ecosystem
            goldenRatio = planets[i].getEnv().getGoldenRatio().getRatio(); // get golden ratios of each resource of that environment
        }
        int sum = 0;
        for (int j = 0; j < num_planets; j++)
        {
            sum += goldenRatio[j]; // add up ratios
        }
        int dividend = (int)(planet_resource_factor / sum);
        for (int k = 0; k < num_planets; k++){
            if (planets[k] != null)
            {
                planets[k].receiveResources(k, dividend * goldenRatio[k]);
            }
        }
        for(int i = 0; i < num_planets; i++)
        {
            print(planets[i].getEnv().getName());
        }
        Resource[] r = new Resource[num_planets];
        Resource[] rp = new Resource[num_planets];

        player = new Player(r, rp); // make player
        float z = 8f;
        GameObject oceanReef = Instantiate(ptOceanReef, new Vector3((z * 0), 0, 0), Quaternion.identity);
        GameObject jungle = Instantiate(ptJungle, new Vector3((z * 1), 0, 0), Quaternion.identity);
        GameObject forest = Instantiate(ptForest, new Vector3((z * 2), 0, 0), Quaternion.identity);
        GameObject desert = Instantiate(ptDesert, new Vector3((z * 3), 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
