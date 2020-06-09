using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public int rows;
    public int cols;
    public float spacing;
    public GameObject brickPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < cols; x++) {
            for (int y = 0; y < rows; y++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(
                    x * spacing, y * spacing
                    );
                GameObject brick = Instantiate(brickPrefab, spawnPos, Quaternion.identity);
                brick.transform.parent = transform;
            }
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
