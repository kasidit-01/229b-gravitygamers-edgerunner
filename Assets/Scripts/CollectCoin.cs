using UnityEngine;

public class CollectCoin : MonoBehaviour
{
   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            Debug.Log("Collected Coin ");
            Object.FindFirstObjectByType<GameManager>().AddCoin();
            Destroy(this.gameObject);

        }
    }
}
