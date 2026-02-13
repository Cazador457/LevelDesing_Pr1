using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameManager manager;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.Return();
        }
    }
}
