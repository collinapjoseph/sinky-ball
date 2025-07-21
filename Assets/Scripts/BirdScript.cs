using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D birdRigidBody2D;
    public float flapStrength;
    public GameLogic gameLogic;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameLogic.gameIsActive && Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidBody2D.linearVelocity = Vector2.up * flapStrength;
        }
    }

    void OnJump()
    {
        // rigidBody2D.linearVelocity = Vector2.up * flapStrength;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameLogic.GameOver();
    }
}
