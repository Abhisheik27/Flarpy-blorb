using UnityEngine;
using UnityEngine.InputSystem;

public class Bird_script : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public CircleCollider2D myCollider;
    public Logic_manager logic;
    public bool birdAlive=true;

    public float flapstrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_manager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Prevent flap if bird is above screen height
        if (transform.position.y > 16 && birdAlive)
        {
            // Bonk on top: set velocity to zero, no downward force
            myRigidBody.linearVelocity = Vector2.zero;
        }
        else if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame && birdAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapstrength;
        }

        if (transform.position.y < -16 && birdAlive)
        {
            logic.GameOver();
            birdAlive = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdAlive=false;
    }
}
