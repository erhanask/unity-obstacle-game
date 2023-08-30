using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xAxis = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zAxis = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xAxis, 0, zAxis);
    }
}