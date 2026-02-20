using UnityEngine;
using System.Collections;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 3.5f;
    public int Life = 3;
    public int gold = 20;

    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI goldText;

    void Start()
    {


    }

    void Update()
    {
        StartCoroutine(DelayStart());
    }
    public void Move(){transform.position += transform.forward* speed * Time.deltaTime;}
    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(1f);
        Move();
    }
    public void LifeValue() => lifeText.text = $"{Life}";
    public void GoldValue() => goldText.text = $"{gold}";
}
