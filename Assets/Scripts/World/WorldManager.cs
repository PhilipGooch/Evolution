using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    protected int worldSize = 100;
    private World worldPrefab;

    private NodeManager nodeManagerPrefab;
    private GrassManager grassManagerPrefab;
    private AnimalManager animalManagerPrefab;

    //protected int getWorldSize()    // Is there a nicer way to make a variable public to unity but not editable by child classes...? { get; } etc.
    //{
    //    return worldSize;
    //}

    // Start is called before the first frame update
    void Start()
    {
        nodeManagerPrefab = (NodeManager)Resources.Load("Prefabs/Node/Node Manager", typeof(NodeManager));
        grassManagerPrefab = (GrassManager)Resources.Load("Prefabs/Grass/Grass Manager", typeof(GrassManager));
        animalManagerPrefab = (AnimalManager)Resources.Load("Prefabs/Animal/Animal Manager", typeof(AnimalManager));
        worldPrefab = (World)Resources.Load("Prefabs/World/World", typeof(World));

        Instantiate(worldPrefab, transform);            // Do i have to create instances of classes with "Instantiate" and a prefab...?
        Instantiate(nodeManagerPrefab, transform);
        Instantiate(grassManagerPrefab, transform);
        Instantiate(animalManagerPrefab, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
