using UnityEngine;

public class Win : MonoBehaviour
{
    public GameManager manager;
    public Player player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.speed = 0;
            manager.W.SetActive(true);
        }
    }
}
