using UnityEngine;
using UnityEngine.UI;

public class CubeControler : MonoBehaviour
{
      [SerializeField] private float jumpPower = 10f;
    [SerializeField] private Text[] cubeInfo;
    public int cubeNumber;

    private Rigidbody rb;

    private void Awake()
    {
        cubeNumber = 2;
        rb = GetComponent<Rigidbody>();
        
       //UpdateInformation();

        
    }
}
