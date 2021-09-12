using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject Pipe;
    private float time;


    private void FixedUpdate()
    {
        time += Time.deltaTime;

        if(time > 4)
        {
            Instantiate(Pipe, new Vector3(-1.2f, Random.RandomRange(-2.8f, 3.8f), 0), Quaternion.identity);
            time = 0;
        }
    }
}
