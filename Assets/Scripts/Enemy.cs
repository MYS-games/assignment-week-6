using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Box")
        {
            if(other.contacts[0].normal.y < -0.5)
            {
                Destroy(gameObject);
            }
        }
    }
}
