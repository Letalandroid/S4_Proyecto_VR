using UnityEngine;

public class Cubes : MonoBehaviour
{

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnMouseDown()
    {
        rb.AddForce(transform.forward * 500f);
        rb.useGravity = true;
    }
}
