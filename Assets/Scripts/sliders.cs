using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliders : MonoBehaviour {

    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public Slider slider5;
    public Slider slider6;
    public Slider slider7;
    //public float value1;

    private void Start()
    {
        slider1.minValue = 0;
        slider1.maxValue = 2;
        slider1.wholeNumbers = true;
        slider1.value = 0;

        slider2.minValue = 0;
        slider2.maxValue = 2;
        slider2.wholeNumbers = true;
        slider2.value = 0;

        slider3.minValue = 0;
        slider3.maxValue = 2;
        slider3.wholeNumbers = true;
        slider3.value = 0;

        slider4.minValue = 0;
        slider4.maxValue = 2;
        slider4.wholeNumbers = true;
        slider4.value = 0;

        slider5.minValue = 0;
        slider5.maxValue = 2;
        slider5.wholeNumbers = true;
        slider5.value = 0;

        slider6.minValue = 0;
        slider6.maxValue = 2;
        slider6.wholeNumbers = true;
        slider6.value = 0;

        slider7.minValue = 0;
        slider7.maxValue = 2;
        slider7.wholeNumbers = true;
        slider7.value = 0;
    }

    public void valueChanged1(float value){
        PlayerPrefs.SetFloat("Slider1", value);
        Debug.Log(value);
    }

    public void valueChanged2(float value)
    {
        PlayerPrefs.SetFloat("Slider2", value);
        Debug.Log(value);
    }

    public void valueChanged3(float value)
    {
        PlayerPrefs.SetFloat("Slider3", value);
        Debug.Log(value);
    }

    public void valueChanged4(float value)
    {
        PlayerPrefs.SetFloat("Slider4", value);
        Debug.Log(value);
    }

    public void valueChanged5(float value)
    {
        PlayerPrefs.SetFloat("Slider5", value);
        Debug.Log(value);
    }

    public void valueChanged6(float value)
    {
        PlayerPrefs.SetFloat("Slider6", value);
        Debug.Log(value);
    }

    public void valueChanged7(float value)
    {
        PlayerPrefs.SetFloat("Slider7", value);
        Debug.Log(value);
    }

}
