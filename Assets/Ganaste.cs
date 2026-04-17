using UnityEngine;

public class Ganaste : MonoBehaviour
{
    public GameObject win;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            win.SetActive(true);
        }
    }
}
