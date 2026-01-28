using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UIElements;

public class BirdJump : MonoBehaviour

{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public logicscript logic;
    public bool birdisalive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdisalive==true)
        {
            myrigidbody.linearVelocity = Vector2.up * flapstrength;
        }
        if(transform.position.y > 4.82 || transform.position.y < -4.52)
        {
            logic.GameOver();
            birdisalive = false;
        }
        
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdisalive = false;
    }
}
