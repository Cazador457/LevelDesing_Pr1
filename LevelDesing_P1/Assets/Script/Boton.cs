using System.Collections;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public GameManager Manager;
    public Player Player;
    
    public GameObject player;

    private Coroutine timerCoroutine;
    private Coroutine coinCoroutine;

    void Update()
    {
        Click();
    }
    public void Click()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            bool nuevoEstado = !player.activeSelf;
            player.SetActive(nuevoEstado);

            // Si se desactiva = iniciar timer
            if (!nuevoEstado)
            {
                timerCoroutine = StartCoroutine(Dispear());
                coinCoroutine = StartCoroutine(GetCoin());
            }
            else
            {
                // Si se activa = cancelar timer
                if (timerCoroutine != null & coinCoroutine!= null)
                {
                    StopAllCoroutines();
                    timerCoroutine = null;
                    coinCoroutine = null;
                }
            }
        }
    }
    IEnumerator Dispear()
    {
        yield return new WaitForSeconds(2f);
        if (Manager != null)
        {
            Manager.Return();
        }
        else
        {
            Debug.LogError("GameManager no está asignado en Boton");
        }
        player.SetActive(true);
    }
    IEnumerator GetCoin()
    {
        yield return new WaitForSeconds(0.5f);
        Player.gold += 1;
        Debug.Log(Player.gold);
    }
}
