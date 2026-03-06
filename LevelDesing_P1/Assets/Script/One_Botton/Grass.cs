using UnityEngine;

public class Grass : MonoBehaviour
{
    public GameManager manager;
    public Player player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.speed += -0.2f;
            Debug.Log(player.speed);
        }
    }
}
