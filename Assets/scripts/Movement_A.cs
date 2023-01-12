using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_A : MonoBehaviour
{
    public GameObject kamera;
    public float y_myszy = 0.5f;
    public float x_myszy = 0f;
    public float rotacja_myszy = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region camera
        rotacja_myszy = kamera.transform.rotation.eulerAngles[0];
        x_myszy = Input.GetAxis("Mouse X");
        y_myszy = Input.GetAxis("Mouse Y");
        transform.Rotate(0, x_myszy * 5, 0);
        if (y_myszy <= 0)
        {
            if ((rotacja_myszy < 80) | (rotacja_myszy > 100))
            {
                kamera.transform.Rotate((y_myszy * (-3)), 0, 0);
            }
        }
        else if (y_myszy >= 0)
        {
            if ((rotacja_myszy > 280) | (rotacja_myszy < 260))
            {
                kamera.transform.Rotate((y_myszy * (-3)), 0, 0);
            }
        }
        #endregion
    }
}
