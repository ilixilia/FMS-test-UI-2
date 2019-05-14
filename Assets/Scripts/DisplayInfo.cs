using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour {

    //public string Name;
    // public string Sex;
    //public string Age;
    //public string Height;
    //public string Weight;

    public Text nametxtBox;
    public Text sextxtBox;
    public Text agetxtBox;
    public Text heighttxtBox;
    public Text weighttxtBox;

    public Text conditionText;
    public Text scoreText;

    public float slider1;
    public float slider2;
    public float slider3;
    public float slider4;
    public float slider5;
    public float slider6;
    public float slider7;

    public GameObject area1;
    public GameObject area11;
    public GameObject area2;
    public GameObject area21;
    public GameObject area3;
    public GameObject area31;
    public GameObject area4;
    public GameObject area41;
    public GameObject area5;
    public GameObject area51;
    public GameObject area6;
    public GameObject area61;
    public GameObject area7;
    public GameObject area71;
    public GameObject area8;
    public GameObject area81;
    public GameObject area9;
    public GameObject area91;


    public InputInfo Script;
    public sliders Script1;

    void Start()
    {
        /*
        Name = Script.yourNam;
        Age = Script.userAge;
        Height = Script.userHeight;
        Weight = Script.userWeight;
        //Script.userName = Name;
        //Script.userAge = Age;
        //Script.userHeight = Height;
        //Script.userWeight = Weight;
        */

        nametxtBox.text = PlayerPrefs.GetString("Name");
        sextxtBox.text = PlayerPrefs.GetString("Sex");
        agetxtBox.text = PlayerPrefs.GetString("Age");
        heighttxtBox.text = PlayerPrefs.GetString("Height");
        weighttxtBox.text = PlayerPrefs.GetString("Weight");
        conditionText.text = "FAIR";
        scoreText.text = "51";

        showAreas();

        //display info in console
        //Debug.Log(Name + Age + Height + Weight);
    }

    public void showAreas()
    {
        area1.SetActive(false);
        area11.SetActive(false);
        area2.SetActive(false);
        area21.SetActive(false);
        area3.SetActive(false);
        area31.SetActive(false);
        area4.SetActive(false);
        area41.SetActive(false);
        area5.SetActive(false);
        area51.SetActive(false);
        area6.SetActive(false);
        area61.SetActive(false);
        area7.SetActive(false);
        area71.SetActive(false);
        area8.SetActive(false);
        area81.SetActive(false);
        area9.SetActive(false);
        area91.SetActive(false);

        slider1 = PlayerPrefs.GetFloat("Slider1");
        slider2 = PlayerPrefs.GetFloat("Slider2");
        slider3 = PlayerPrefs.GetFloat("Slider3");
        slider4 = PlayerPrefs.GetFloat("Slider4");
        slider5 = PlayerPrefs.GetFloat("Slider5");
        slider6 = PlayerPrefs.GetFloat("Slider6");
        slider7 = PlayerPrefs.GetFloat("Slider7");


        /*if (slider1 == 0)
        {
            area1.SetActive(false);
            area11.SetActive(false);
        } else*/

        if (slider1 == 1)
        {
            area1.SetActive(true);
            area11.SetActive(false);
            area2.SetActive(true);
            area21.SetActive(false);
            area3.SetActive(true);
            area31.SetActive(false);
            area4.SetActive(true);
            area41.SetActive(false);
            area5.SetActive(true);
            area51.SetActive(false);
            area6.SetActive(true);
            area61.SetActive(false);
        } else if(slider1 == 2)
        {
            area1.SetActive(false);
            area11.SetActive(true);
            area2.SetActive(false);
            area21.SetActive(true);
            area3.SetActive(false);
            area31.SetActive(true);
            area4.SetActive(false);
            area41.SetActive(true);
            area5.SetActive(false);
            area51.SetActive(true);
            area6.SetActive(false);
            area61.SetActive(true);
        }

        if (slider2 == 1)
        {
            area1.SetActive(true);
            area11.SetActive(false);
            area2.SetActive(true);
            area21.SetActive(false);
            area5.SetActive(true);
            area51.SetActive(false);
            area6.SetActive(true);
            area61.SetActive(false);
        }
        else if (slider2 == 2)
        {
            area1.SetActive(false);
            area11.SetActive(true);
            area2.SetActive(false);
            area21.SetActive(true);
            area5.SetActive(false);
            area51.SetActive(true);
            area6.SetActive(false);
            area61.SetActive(true);
        }

        if (slider3 == 1)
        {
            area1.SetActive(true);
            area11.SetActive(false);
            area2.SetActive(true);
            area21.SetActive(false);
        }
        else if (slider3 == 2)
        {
            area1.SetActive(false);
            area11.SetActive(true);
            area2.SetActive(false);
            area21.SetActive(true);
        }

        if (slider4 == 1)
        {
            area5.SetActive(true);
            area51.SetActive(false);
            area6.SetActive(true);
            area61.SetActive(false);
            area7.SetActive(true);
            area71.SetActive(false);
        }
        else if (slider4 == 2)
        {
            area5.SetActive(false);
            area51.SetActive(true);
            area6.SetActive(false);
            area61.SetActive(true);
            area7.SetActive(false);
            area71.SetActive(true);
        }

        if (slider5 == 1)
        {
            area7.SetActive(true);
            area71.SetActive(false);
            area8.SetActive(true);
            area81.SetActive(false);
            area9.SetActive(true);
            area91.SetActive(false);
        }
        else if (slider5 == 2)
        {
            area7.SetActive(false);
            area71.SetActive(true);
            area8.SetActive(false);
            area81.SetActive(true);
            area9.SetActive(false);
            area91.SetActive(true);
        }

        if (slider6 == 1)
        {
            area7.SetActive(true);
            area71.SetActive(false);
        }
        else if (slider6 == 2)
        {
            area7.SetActive(false);
            area71.SetActive(true);
        }

        if (slider7 == 1)
        {
            area8.SetActive(true);
            area81.SetActive(false);
            area9.SetActive(true);
            area91.SetActive(false);
        }
        else if (slider7 == 2)
        {
            area8.SetActive(false);
            area81.SetActive(true);
            area9.SetActive(false);
            area91.SetActive(true);
        }

    }

}
