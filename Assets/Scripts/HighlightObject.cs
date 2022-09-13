using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.UI;

[Serializable]
public class ItemNameChange : UnityEvent<string> { }
[Serializable]
public class ItemDescriptionChange : UnityEvent<string> { }

public class HighlightObject : MonoBehaviour
{
    [SerializeField]
    private bool debug = false;

    [SerializeField]
    private ItemNameChange itemNameChangeEvent;

    [SerializeField]
    private ItemDescriptionChange itemDescriptionChangeEvent;

    private GameObject selectedObject;
    private GameObject highlightedLast;
    private bool objectSelected;
    
    //[Range(0, 255)]
    //private int redCol;

    //[Range(0, 255)]
    //private int greenCol;

    //[Range(0, 255)]
    //private int blueCol;

    //[Range(0, 255)]
    //private int transparencyValue = 255;

    [SerializeField]
    private List<string> bannedHighlights;

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
        selectedObject = GameObject.Find(objectName);

        //If the object hit has a different name from the object we are highlighting, then stop highlighting it.
        if (objectSelected && objectName != highlightedLast.name)
        {
            OnObjectExit();
            objectSelected = false;
        }
        //if we hit a valid object, highlight it
        else if(selectedObject && !bannedHighlights.Contains(objectName))
        {
            objectSelected = true;
            highlightedLast = selectedObject;

            //get transparency value
            //transparencyValue = GetComponent<UIController>().GetTransparency();

            enableRenderer(highlightedLast);
            highlightedLast.GetComponent<Renderer>().material.color = GetComponent<UIController>().GetColorValue();

            //change ui name and description
            itemNameChangeEvent.Invoke(objectName);
            itemDescriptionChangeEvent.Invoke(highlightedLast.GetComponent<TextContainer>().textField);
            //highlightedInformation.text = highlightedLast.GetComponent<TextContainer>().textField;
        }

        if (debug)
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

            //change item name and description
            itemNameChangeEvent.Invoke("Early demo");
            itemDescriptionChangeEvent.Invoke("Point the mouse cursor at a part.\nHold right click and move the mouse to rotate the skull, or click the arrows.\nChange highlight settings to the right.");
            //highlightedInformation.text = " ";
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
