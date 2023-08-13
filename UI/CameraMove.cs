using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMove : MonoBehaviour
{
    Camera camera;
    private float sensibilite = 0.0003f;
    private float Hauteur = 20.0f;
    private float DeltaH = 0.1f;
    Vector3 CamPos;
    Vector3 MousePos;
    
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    
    void Update()
    {
        MousePos = Input.mousePosition;
        if ((MousePos[0] < Screen.width * 0.15f) && (!EventSystem.current.IsPointerOverGameObject()))
        {
            camera.transform.Translate(- sensibilite * (0.15f * Screen.width - MousePos[0]), 0, 0);
        }
        if (MousePos[0] > Screen.width* 0.85f)
        {
            camera.transform.Translate(sensibilite * (MousePos[0] - 0.85f * Screen.width), 0, 0);
        }
        if (MousePos[1] < Screen.height *0.15f)
        {
            camera.transform.Translate(0, 0, -sensibilite * (0.15f * Screen.height - MousePos[1]));
        }
        if (MousePos[1] > Screen.height * 0.85f)
        {
            camera.transform.Translate(0, 0, sensibilite * (MousePos[1] - 0.85f * Screen.height));
        }
        CamPos = camera.transform.position;
        camera.transform.position = new Vector3(CamPos[0], Hauteur, CamPos[2]);
        if (Input.GetAxis("Mouse ScrollWheel") > 0.0f)
        {
            camera.orthographicSize -= DeltaH;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0.0f)
        {
            camera.orthographicSize += DeltaH;
        }
    }
}
