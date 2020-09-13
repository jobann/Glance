using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorSelect : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void W1ColorSelect()
    { 
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if(buttonName == "black button")
        {
            // Set Band color to Black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        }
        else if (buttonName == "blue button")
        {
            // Set Band color to Blue
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#103B90", out myColor);
            band1.color = myColor;
        }
    }
    public void W2ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "black button")
        {
            // Set Band color to Black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;
        }
        else if (buttonName == "red button")
        {
            // Set Band color to Red
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            band2.color = myColor;
        }
    }
    public void W3ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "black button")
        {
            // Set Band color to Black
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#464646", out myColor);
            band3.color = myColor;
        }
        else if (buttonName == "silver button")
        {
            // Set Band color to Silver
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#A1A1A1", out myColor);
            band3.color = myColor;
        }
    }
}
