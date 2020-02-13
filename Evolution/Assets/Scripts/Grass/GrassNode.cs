using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassNode : Node
{
    [SerializeField] private Grass grassPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGrowing()
    {
        Instantiate(grassPrefab, transform.position, Quaternion.identity);
    }
}
