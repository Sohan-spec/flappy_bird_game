using System.Data;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float movespeed;
    public float deadzone = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * movespeed) * Time.deltaTime;

        if(transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
