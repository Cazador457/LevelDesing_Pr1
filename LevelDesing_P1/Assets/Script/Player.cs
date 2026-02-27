using UnityEngine;
using System.Collections;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 4f;
    public int Life = 5;
    public int gold = 30;

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
