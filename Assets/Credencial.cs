using UnityEngine;

public class Credencial : MonoBehaviour
{
    public GameObject mesh;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mesh.SetActive(false);
            GameEvent.Onhit?.Invoke();
        }
        
    }
}
