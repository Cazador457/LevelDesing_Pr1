using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=3f;
    public int Life = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
