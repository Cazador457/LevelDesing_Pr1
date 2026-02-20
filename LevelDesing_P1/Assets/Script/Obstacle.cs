using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameManager manager;
    public Player player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.Life--;
            player.gold += -5;
            manager.Return();
            Debug.Log(player.Life);
            Debug.Log(player.gold);
        }
    }
}
