using UnityEngine;

public class Escuela : MonoBehaviour
{

    public GameObject puerta;
    private void OnEnable()
    {
        GameEvent.Onhit += AbriPuerta;
    }
    private void OnDisable()
    {
        GameEvent.Onhit -= AbriPuerta;
    }

    public void AbriPuerta()
    {
        puerta.SetActive(false);
    }
}
