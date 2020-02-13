using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : NodeManager
{
    [SerializeField] private int amountOfAnimals;

    private List<AnimalNode> occupied;
    private List<AnimalNode> vacant;

    // Start is called before the first frame update
    void Start()
    {
        occupied = new List<AnimalNode>();
        vacant = new List<AnimalNode>();

        for (int i = 0; i < worldSize; i++)
        {
            for (int j = 0; j < worldSize; j++)
            {
                vacant.Add((AnimalNode)nodes[i, j]);
            }
        }

        for (int i = 0; i < amountOfAnimals; i++)
        {
            int random = Random.Range(0, vacant.Count);
            AnimalNode animalNode = vacant[random];
            animalNode.animal = true;
            occupied.Add(animalNode);
            vacant.RemoveAt(random);
            animalNode.Spawn();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
