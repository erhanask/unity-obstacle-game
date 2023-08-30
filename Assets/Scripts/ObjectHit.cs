using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Make color red when colliding with wall
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
