using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class UIController : MonoBehaviour
{
    [SerializeField]
    private UIDocument uiDocument;

    private Label itemName, itemDescription;
    private SliderInt red, green, blue, transparency, rotateStep;
    private Toggle audio;
    private Button up, down, left, right, reset;
    GameObject RotationInvoker;

    // Start is called before the first frame update
    void Start()
    {
        RotationInvoker = GameObject.Find("New Camera");

        //import UI elements
        var root = uiDocument.rootVisualElement;

        //get ui label fields
        itemName = root.Q<Label>("ItemName");
        itemDescription = root.Q<Label>("ItemDescription");

        //get ui accesibility highlight fields
        transparency = root.Q<SliderInt>("Transparency");
        red = root.Q<SliderInt>("Red");
        green = root.Q<SliderInt>("Green");
        blue = root.Q<SliderInt>("Blue");
        audio = root.Q<Toggle>("Audio");

        //get ui alternate movement fields
        up = root.Q<Button>("Up");
        down = root.Q<Button>("Down");
        left = root.Q<Button>("Left");
        right = root.Q<Button>("Right");
        reset = root.Q<Button>("Reset");
        rotateStep = root.Q<SliderInt>("RotateStep");

        up.clicked += UpButtonPressed;
        down.clicked += DownButtonPressed;
        left.clicked += LeftButtonPressed;
        right.clicked += RightButtonPressed;
        reset.clicked += ResetButtonPressed;
    }

    public void ChangeItemName(string name)
    {
        itemName.text = name;
    }

    public void ChangeItemDescription(string description)
    {
        itemDescription.text = description;
    }

    // Invoke rotation command around the skull in the specified directions
    private void CameraRotationMethod(float x, float y)
    {
        RotationInvoker.GetComponent<RotateAroundPoint>().updateRightMouseHeldDown(true);
        for (int i = 0; i < rotateStep.value; i++)
        {
            RotationInvoker.GetComponent<RotateAroundPoint>().OnRotateInput(x, y);
        }
        RotationInvoker.GetComponent<RotateAroundPoint>().updateRightMouseHeldDown(false);
    }

    public void UpButtonPressed()
    {
        CameraRotationMethod(0, 1);
    }

    public void DownButtonPressed()
    {
        CameraRotationMethod(0, -1);
    }

    public void LeftButtonPressed()
    {
        CameraRotationMethod(-1, 0);
    }

    public void RightButtonPressed()
    {
        CameraRotationMethod(1, 0);
    }

    private void ResetButtonPressed()
    {
        RotationInvoker.GetComponent<RotateAroundPoint>().resetRotation();
    }

    //TODO add a reset button, and add a "speed" slider

    // These are accessed from outside
    public Color32 GetColorValue()
    {
        return new Color32((byte)red.value, (byte)green.value, (byte)blue.value, (byte)transparency.value);
    }

    public bool GetIsAudioEnabled()
    {
        return audio.value;
    }
}
