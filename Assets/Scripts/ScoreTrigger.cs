using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public GameLogic gameLogic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {             
            gameLogic.IncrementPlayerScore();
        }
    }
}
