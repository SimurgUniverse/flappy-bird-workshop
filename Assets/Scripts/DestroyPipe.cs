using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPipe : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "PipeOut")
        {
            Destroy(collision.gameObject);
        }
    }
}
