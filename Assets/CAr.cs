using UnityEngine;

public class CAr : MonoBehaviour
{
    public GameObject lose;
    public float speed = 5f;
    public float distance = 5f;
    public Rigidbody rb;

    private float minZ;
    private float maxZ;
    private int direction = 1;

    void Start()
    {
        float startZ = transform.position.z;
        minZ = startZ - distance;
        maxZ = startZ + distance;
    }

    void FixedUpdate()
    {
        Vector3 movement = Vector3.forward * direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        if (rb.position.z >= maxZ)
        {
            direction = -1;
        }
        else if (rb.position.z <= minZ)
        {
            direction = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lose.SetActive(true);
        }
    }
}
