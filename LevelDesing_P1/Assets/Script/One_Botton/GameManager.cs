using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Player Play;

    public Transform StLev;
    public GameObject Player;
    public GameObject shadow;
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
        W.SetActive(true);
    }
    public void Lose()
    {
        L.SetActive(true);
    }
    public void Retry()
    {
        Play.Life = 5;
        Play.speed = 4f;
        Play.gold = 30;
        W.SetActive(false);
        L.SetActive(false);
        Player.SetActive(true);
        //shadow.activeSelf(!);
    }
    public void Return()
    {
        if (Play.Life >= 0)
        {
            Player.transform.position = StLev.transform.position;
            Play.speed = 3.5f;
        }
        if(Play.Life <= 0)
        {
            L.SetActive(true);
            Play.speed = 0;
        }
    }

    
}
