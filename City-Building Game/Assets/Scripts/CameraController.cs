using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region Variables
    //The movement speed of the camera and zoom and rotation.
    public float movementSpeed;
    public float zoomSpeed;
    public float rotapeed;

    //Setting the rotation limits.
    public float minRotate;
    public float MaxRotate;


    //Setting the max zoom in and out.
    public float minZoom;
    public float maxZoom;

    //The cameras current rotation and zoom.
    public float camCurRot;
    public float camCurZoom;

    //Conecting the camera.
    private Camera cameraX;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //Linking the camera to the main and setting the defaults.
        cameraX = Camera.main;
        camCurZoom = cameraX.transform.localPosition.y;
        camCurRot = -50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
