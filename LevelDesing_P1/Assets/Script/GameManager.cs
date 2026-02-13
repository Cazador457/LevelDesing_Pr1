using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player Play;

    public Transform StLev;
    public GameObject Player;
    public GameObject W;
    public GameObject L;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Win()
    {
        W.SetActive(!W.activeSelf);
    }
    public void Lose()
    {
        L.SetActive(!L.activeSelf);
    }
    public void Retry()
    {
        Play.Life = 3;
        W.SetActive(false);
        L.SetActive(false);
    }
    public void Return()
    {
        if (Play.Life >= 0)
        {
            Player.transform.position = StLev.transform.position;
        }
        if(Play.Life <= 0)
        {
            Win();
            Play.speed = 0;
        }
    }
}
