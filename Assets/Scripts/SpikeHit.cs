using UnityEngine;

public class SpikeHit : MonoBehaviour
{
    public int hitCount = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            hitCount++;
            Debug.Log("Hit Count: " + hitCount);
            Object.FindFirstObjectByType<GameManager>().AddLives();
            if (hitCount >= 5)
            {
                Debug.Log("Game Over!");
                Object.FindFirstObjectByType<GameManager>().GameOver();


            }
        }
    }

}
