using UnityEngine;

public class Win : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
           Debug.Log("Game Win!");
                Time.timeScale = 0;
                Object.FindFirstObjectByType<GameManager>().WinGame();
          
        }
    }
}
