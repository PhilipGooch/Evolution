using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassManager : NodeManager
{
    [SerializeField] private int amountOfGrass;
    private List<GrassNode> occupied;
    private List<GrassNode> vacant;
    //[SerializeField] private float spawnInterval;
    //private float lastSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        //lastSpawnTime = Time.time;

        occupied = new List<GrassNode>();
        vacant = new List<GrassNode>();

        for (int i = 0; i < worldSize; i++)
        {
            for (int j = 0; j < worldSize; j++)
            {
                vacant.Add((GrassNode)nodes[i, j]);
            }
        }

        for (int i = 0; i < amountOfGrass; i++)
        {
            int random = Random.Range(0, vacant.Count);
            GrassNode grassNode = vacant[random];
            grassNode.grass = true;
            occupied.Add(grassNode);
            vacant.RemoveAt(random);
            grassNode.StartGrowing();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
