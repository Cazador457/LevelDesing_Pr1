using Unity.VisualScripting;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Click();
    }
    public void Click()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(!player.activeSelf);
        }
    }
}
