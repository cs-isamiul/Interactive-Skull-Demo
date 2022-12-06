using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 1f;

    [SerializeField]
    private GameObject pivotObject;

    private bool rotateCamera;
    private Vector3 defaultPosition;
    private Quaternion defaultRotation;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rotateCamera = false;
        defaultPosition = transform.position;
        defaultRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //for testing
        //if(rotateCamera)
        //{
        //    transform.RotateAround(pivotObject.transform.position, new Vector2(0,rotationSpeed), rotationSpeed);
        //}
    }

    public void OnRotateInput(float xPan, float yPan)
    {
        //rotate around pivotobject at a certain direction at a certain speed
        if (rotateCamera)
        {
            transform.RotateAround(pivotObject.transform.position, new Vector3(0*yPan, xPan, yPan), rotationSpeed);
        }
    }

    public void updateRightMouseHeldDown(bool currentlyHeld)
    {
        this.rotateCamera = currentlyHeld;
    }

    public void resetRotation()
    {
        transform.position = defaultPosition;
        transform.rotation = defaultRotation;
    }
}
