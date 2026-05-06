using UnityEngine;

public class Win : MonoBehaviour
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
