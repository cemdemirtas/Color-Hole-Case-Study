using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleClamper : MonoBehaviour
{
    private void Update()
    {
        //Restriction x and z
        float xClamp = Mathf.Clamp(transform.position.x, -2.18f, 2.15f);
        float zxClamp = Mathf.Clamp(transform.position.z, -3f, 28.8f);

        transform.position = new Vector3(xClamp, transform.position.y, zxClamp);
    }
}
