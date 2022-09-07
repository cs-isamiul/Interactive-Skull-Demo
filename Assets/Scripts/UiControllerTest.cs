using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UiControllerTest : MonoBehaviour
{
    public Button testButton;
    public Button normalButton;
    public Label messageText;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        testButton = root.Q<Button>("TestButton");
        normalButton = root.Q<Button>("NormalButton");
        messageText = root.Q<Label>("Menu");

        testButton.clicked += testButtonPressed;
        normalButton.clicked += normalButtonPressed;
    }

    void testButtonPressed()
    {
        Debug.Log("Test button was pressed!");
    }

    void normalButtonPressed()
    {
        messageText.text = "Random : " + Random.Range(0,100);
    }
}
