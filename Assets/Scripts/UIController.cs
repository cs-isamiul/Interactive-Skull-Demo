using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class UIController : MonoBehaviour
{
    [SerializeField]
    private UIDocument uiDocument;

    private Label itemName, itemDescription;
    private SliderInt transparency;
    private SliderInt red;
    private SliderInt green;
    private SliderInt blue;
    private Toggle audio;

    // Start is called before the first frame update
    void Start()
    {
        //import UI elements
        var root = uiDocument.rootVisualElement;

        itemName = root.Q<Label>("ItemName");
        itemDescription = root.Q<Label>("ItemDescription");

        transparency = root.Q<SliderInt>("Transparency");
        red = root.Q<SliderInt>("Red");
        green = root.Q<SliderInt>("Green");
        blue = root.Q<SliderInt>("Blue");

        audio = root.Q<Toggle>("Audio");
    }

    public void ChangeItemName(string name)
    {
        itemName.text = name;
    }

    public void ChangeItemDescription(string description)
    {
        itemDescription.text = description;
    }

    //public int gettransparency()
    //{
    //    return transparency.value;
    //}

    public Color32 GetColorValue()
    {
        return new Color32((byte)red.value, (byte)green.value, (byte)blue.value, (byte)transparency.value);
    }

    public bool GetIsAudioEnabled()
    {
        return audio.value;
    }
}
