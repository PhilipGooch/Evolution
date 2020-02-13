using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : WorldManager
{
    [SerializeField] protected Node nodePrefab;
    protected Node[,] nodes;

    void Awake()
    {
        //int worldSize = getWorldSize();

        nodes = new Node[worldSize, worldSize];

        for (int i = 0; i < worldSize; i++)
        {
            for (int j = 0; j < worldSize; j++)
            {
                Vector3 spawnPosition = new Vector3(i - worldSize / 2, 0, j - worldSize / 2);
                nodes[i, j] = Instantiate(nodePrefab, spawnPosition, Quaternion.identity);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
