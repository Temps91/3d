using UnityEngine;
public class Laser : MonoBehaviour
{
    public bool horizontal;
    public bool vertical;
    public float speed = 50f;
    public float maxAngle = 45f;
    public float minAngle = -45f;
    public bool flipped = false; // <-- nuevo, el spawner lo activa en X=-2
    private int direction = 1;
    private float currentAngle = 0f;

    void Start()
    {
        currentAngle = minAngle;
    }

    void Update()
    {
        currentAngle += speed * direction * Time.deltaTime;

        if (currentAngle >= maxAngle)
        {
            currentAngle = maxAngle;
            direction = -1;
        }
        else if (currentAngle <= minAngle)
        {
            currentAngle = minAngle;
            direction = 1;
        }

        float angle = flipped ? -currentAngle : currentAngle;

        if (horizontal && vertical)
        {
            transform.localRotation = Quaternion.Euler(angle, angle, 0);
        }
        else if (horizontal)
        {
            transform.localRotation = Quaternion.Euler(0, angle, 0);
        }
        else if (vertical)
        {
            transform.localRotation = Quaternion.Euler(0, 0, angle);
        }
    }
}