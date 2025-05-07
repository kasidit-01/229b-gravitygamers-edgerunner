using UnityEngine;

public class GameState : MonoBehaviour
{
    public bool isDead = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isDead = true;
            
                Debug.Log("Game Over!");
                Time.timeScale = 0;
                Object.FindFirstObjectByType<GameManager>().GameOver();


            
        }
    }
}
