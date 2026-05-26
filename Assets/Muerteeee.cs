using UnityEngine;

public class Muerteeee : MonoBehaviour
{
    public GameObject Perder;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Perder.SetActive(true);
        }
    }
}
