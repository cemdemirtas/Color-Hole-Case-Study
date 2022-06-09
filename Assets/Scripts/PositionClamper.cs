using UnityEngine;

public class PositionClamper : MonoBehaviour
{

    private void Update()
    {
        //Restriction x and z
        float xClamp = Mathf.Clamp(transform.position.x, -1.77f, 1.77f);
        float zxClamp = Mathf.Clamp(transform.position.z, -2.5f, 28.8f);

        transform.position = new Vector3(xClamp, transform.position.y, zxClamp);
    }
}