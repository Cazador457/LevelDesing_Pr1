using Unity.VisualScripting;
using System.Collections;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public GameObject player;
    public GameManager manager;

    private Coroutine timerCoroutine;

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
            }
            else
            {
                // Si se activa = cancelar timer
                if (timerCoroutine != null)
                {
                    StopCoroutine(timerCoroutine);
                    timerCoroutine = null;
                }
            }
        }
    }
    IEnumerator Dispear()
    {
        yield return new WaitForSeconds(2f);
        if (manager != null)
        {
            manager.Return();
        }
        else
        {
            Debug.LogError("GameManager no está asignado en Boton");
        }
        player.SetActive(true);
    }
}
