using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public float treerange;
    public float left;
    public float right;
    public GameObject tree;
    public GameObject blueGate;
    public GameObject redGate;
    private float x_range;
    private float y_range;
    public GameObject player;
    private bool redflag = true;



    // Start is called before the first frame update
    void Start()
    {
        float initial_x_min = -6;
        float initial_x_max = -3;
        float initial_y_min = -20;
        float initial_y_max = -6f;
        
        for (int i = 0; i< Random.Range(7, 9); i++)
        {
            Instantiate(tree, new Vector3(Random.Range(initial_x_min, initial_x_max), initial_y_max, 0), Quaternion.identity);
            initial_y_max -= Random.Range(1f, 2f);
        }
        Instantiate(tree, new Vector3(Random.Range(initial_x_min + 11, initial_x_max + 11), Random.Range(initial_y_min + 5, -7), 0), Quaternion.identity);
    }
        //Spawn the trees immedietly below the initial screen
        
        

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < player.transform.position.y - 10)
        {
            if (redflag)
            {
                //Instantiate(redGate, new Vector3(Random.range()))
            }
        }
    }
}
