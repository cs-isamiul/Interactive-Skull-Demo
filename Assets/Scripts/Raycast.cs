using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private Color debugRayColor = Color.red;
    [SerializeField]
    private bool debug = true;
    [SerializeField]
    private float rayLength = 100f;
    [SerializeField]
    private Text boneText;

    // Start is called before the first frame update
    void Start()
    {
        //set frame limit to 60
        Application.targetFrameRate = 60;
        Debug.Log("Starting script");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void raycast(float horizontal, float vertical)
    {
        //Send a ray from the camera out towards where the pointer is
        Ray ray = camera.ScreenPointToRay(new Vector3(horizontal, vertical, 0));

        //If ray hits anything that is rayLength away, then save that data in raycasthit
        if (Physics.Raycast(ray, out RaycastHit raycasthit, rayLength))
        {
            //Get the name of the object that was hit
            string objectName = raycasthit.transform.gameObject.name;
            //Change ui element to show name
            boneText.text = objectName;
        }

        //show ray being cast
        if (debug)
        {
            Debug.DrawRay(ray.origin, ray.direction * rayLength, debugRayColor);
        }
    }
}