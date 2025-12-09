using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private Transform dice;
    [SerializeField] private Transform place1;
    [SerializeField] private Transform place2;
    [SerializeField] private Transform place3;
    [SerializeField] private Transform place4;
    [SerializeField] private float force = 10f;
    private Rigidbody cubeRb;

    public void Movement()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            dice.position = place1.position;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            dice.position = place2.position;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            dice.position = place3.position;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            dice.position = place4.position;
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            cubeRb.AddForce(Vector3.forward * force);
        }
    }

    private void Update()
    {
        Movement();
        cubeRb = GetComponent<Rigidbody>();
    }

    

}
 