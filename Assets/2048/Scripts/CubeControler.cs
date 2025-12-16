using Unity.VisualScripting;
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

    public void UpdateInformation()
    {
        for (int i = 0; i < cubeInfo.Length; i++)
        {
            cubeInfo[i].text = $"{cubeNumber}";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //проверяем что это тоже кубик
        if (collision.gameObject.GetComponent<CubeControler>())
        {
            //сравниваем значени на кубиках
            if (collision.gameObject.GetComponent<CubeControler>().cubeNumber == cubeNumber)
            {

                //расчитываем центральную точку между кубами
                Vector3 thisCubePos = transform.position;
                Vector3 CollisionCubePos = collision.gameObject.transform.position;
                Vector3 center = (thisCubePos + CollisionCubePos) / 2f;

                Destroy(collision.gameObject);

                transform.position = center;

                rb.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);

                cubeNumber += cubeNumber;

                UpdateInformation();
            }
        }

    }
}
