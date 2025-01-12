using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float ascendSpeed = 2f;
    public Transform balloon;

    private float fixedX;

    private void Start()
    {
        fixedX = transform.position.x;
    }

    void Update()
    {

        transform.position = new Vector3(fixedX, transform.position.y, transform.position.z);
    }
}
