using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class HighlightObject : MonoBehaviour
{
    [SerializeField]
    private bool debug = false;

    [SerializeField]
    private UIDocument uiDocument;

    private GameObject selectedObject;
    private GameObject highlightedLast;
    private bool objectSelected;
    private Label itemName;
    private Label itemDescription;
    
    [SerializeField]
    [Range(0, 255)]
    private int redCol;

    [SerializeField]
    [Range(0, 255)]
    private int greenCol;

    [SerializeField]
    [Range(0, 255)]
    private int blueCol;

    [SerializeField]
    [Range(0, 255)]
    private int transparencyValue = 255;

    [SerializeField]
    private List<string> bannedHighlights;

    private void Start()
    {
        //set some initial values
        selectedObject = new GameObject();
        highlightedLast = selectedObject;
        objectSelected = false;

        //import UI text fields
        var root = uiDocument.rootVisualElement;

        itemName = root.Q<Label>("ItemName");
        itemDescription = root.Q<Label>("ItemDescription");
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
        else if(!bannedHighlights.Contains(objectName))
        {
            objectSelected = true;
            selectedObject = GameObject.Find(objectName);
            highlightedLast = selectedObject;

            enableRenderer(highlightedLast);
            highlightedLast.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, (byte)transparencyValue);

            //change ui name and description
            itemName.text = objectName;
            itemDescription.text = highlightedLast.GetComponent<TextContainer>().textField;
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
            itemName.text = " ";
            itemDescription.text = " ";
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
