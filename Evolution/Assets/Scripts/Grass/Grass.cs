using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    [SerializeField] private float startHeight;
    [SerializeField] private float maxHeight;
    [SerializeField] private float growthSpeed;
    private float height;
    private bool fullyGrown;

    // Start is called before the first frame update
    void Start()
    {
        height = startHeight;
        fullyGrown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!fullyGrown)
        {
            Grow(maxHeight);
        }
    }

    void Grow(float maxHeight)
    {
        float delta = growthSpeed * Time.deltaTime;
        height += delta;
        if(height > maxHeight)
        {
            fullyGrown = true;
            return;
        }
        transform.localScale += new Vector3(0, delta, 0);
        transform.position += new Vector3(0, delta / 2, 0);
    }
}
