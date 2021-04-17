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
        #region Camera Link
        //Linking the camera to the main and setting the defaults.
        cameraX = Camera.main;
        camCurZoom = cameraX.transform.localPosition.y;
        camCurRot = -50;
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region Zooming
        //Seeing what way the scroll wheel is turning and moving tthe camera in and out accordingly
        camCurZoom += Input.GetAxis("Mouse ScrollWheel") * -zoomSpeed;
        camCurZoom = Mathf.Clamp(camCurZoom, minZoom, maxZoom);
        //Linking to the camera
        cameraX.transform.localPosition = Vector3.up * camCurZoom;
        #endregion

        #region Rotating the camera
        //Check if the RMB is down.
        if (Input.GetMouseButton(1))
        {
            //Getting the position of the mouse.
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");

            //Setting the roation
            camCurRot += -y * rotapeed;
            camCurRot = Mathf.Clamp(camCurRot, minRotate, MaxRotate);

            //Updating the view with the settings.
            transform.eulerAngles = new Vector3(camCurRot, transform.eulerAngles.y + (x * rotapeed), 0.0f);
        }
        #endregion
    }
}
