using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformsManager : MonoBehaviour
{
    public GameObject myCube;
    public GameObject Rotado;
    public GameObject Escalado;
    public GameObject RotadoyEscalado;

    public Vector3 originalRotation;
    public Vector3 originalScale;

    public bool isRotated;
    public bool isScaled;

    // Start is called before the first frame update
    void Start()
    {
        isRotated = false;
        isScaled = false;
        originalRotation = myCube.transform.eulerAngles;
        originalScale = myCube.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = originalRotation;
                isRotated = false;

            }
            else
            {
                myCube.transform.eulerAngles = Rotado.transform.eulerAngles;
                isRotated = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (isScaled)
            {
                myCube.transform.localScale = originalScale;
                isScaled = false;
            }
            else
            {
                myCube.transform.localScale = Escalado.transform.localScale;
                isScaled = true;
            }
        }
    }
}
