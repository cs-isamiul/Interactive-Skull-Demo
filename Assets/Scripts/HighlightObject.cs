using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.UI;


public class HighlightObject : MonoBehaviour
{
    [SerializeField]
    private bool debug = false;

    [SerializeField]
    private Text highlightedInformation;

    private GameObject selectedObject;
    private GameObject highlightedLast;
    private bool objectSelected;
    

    //TODO maybe make these private? Will check later.
    public int redCol;
    public int greenCol;
    public int blueCol;

    private void Start()
    {
        //set some initial values
        selectedObject = new GameObject();
        highlightedLast = selectedObject;
        objectSelected = false;
    }

    //Once the raycast "hits" anything, it will send out an event with what it hit.
    public void OnObjectHit(string objectName)
    {
        //If the object hit has a different name from the object we are highlighting, then stop highlighting it.
        if (objectSelected && objectName != highlightedLast.name)
        {
            OnObjectExit();
            objectSelected = false;
        }
        //if we hit a valid object, highlight it
        else if(objectName != "null")
        {
            objectSelected = true;
            selectedObject = GameObject.Find(objectName);
            highlightedLast = selectedObject;

            enableRenderer(highlightedLast);
            highlightedLast.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 255);

            highlightedInformation.text = highlightedLast.GetComponent<TextContainer>().textField;
        }

        if(debug)
        {
            Debug.Log($">>Last highlighted object was {highlightedLast.name}. Event was called for {objectName}.");
            Debug.Log($"Text says : {highlightedLast.GetComponent<TextContainer>().textField}");
        }
    }

    private void OnObjectExit()
    {
        if(objectSelected)
        {
            disableRenderer(highlightedLast);
            highlightedInformation.text = " ";
            //highlightedLast.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 0);
        }
    }

    private void enableRenderer(GameObject selected)
    {
        selected.GetComponent<MeshRenderer>().enabled = true;
    }
    private void disableRenderer(GameObject selected)
    {
        selected.GetComponent<MeshRenderer>().enabled = false;
    }
}