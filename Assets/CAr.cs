using UnityEngine;

public class CAr : MonoBehaviour
{
    public float speed;
    public float distance;
    public Rigidbody rb;


    public void Update()
    {
        Vector3 dir = new Vector3(0,0, distance);
        rb.MovePosition(dir);
    }
}
