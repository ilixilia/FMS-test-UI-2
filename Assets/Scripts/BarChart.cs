using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class BarChart : MonoBehaviour {

    public Bar barPrefab;
    public int[] inputValues;
    public RawImage BarBackground;

    List<Bar> bars = new List<Bar>();
    
    float chartHeight;

    // Use this for initialization
    void Start () {
        chartHeight = Screen.height - GetComponent<RectTransform>().sizeDelta.y;
        //- GetComponent<RectTransform>().sizeDelta.y;

        //Display graph
        //float[] values = {0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f};

        DisplayGraph(inputValues);
	}
	
    void DisplayGraph(int[] vals)
    {
        int maxValue = vals.Max();

        for (int i = 0; i < vals.Length; i++)
        {
            Bar newBar = Instantiate(barPrefab) as Bar;
            newBar.transform.SetParent(transform);
            RectTransform rt = newBar.bar.GetComponent<RectTransform>();

            if (i == 0 || i == 1)
            {
                float normalizedValue = (float)vals[i] / (float)maxValue * 0.043f;
                rt.sizeDelta = new Vector2(rt.sizeDelta.x, chartHeight * normalizedValue);
            } else if (i == 2)
            {
                float normalizedValue = (float)vals[i] / (float)maxValue * 0.049f;
                rt.sizeDelta = new Vector2(rt.sizeDelta.x, chartHeight * normalizedValue);
            } else if (i == 3 || i == 4 || i == 5)
            {
                float normalizedValue = (float)vals[i] / (float)maxValue * 0.028f;
                rt.sizeDelta = new Vector2(rt.sizeDelta.x, chartHeight * normalizedValue);
            } else if (i == 6)
            {
                float normalizedValue = (float)vals[i] / (float)maxValue * 0.019f;
                rt.sizeDelta = new Vector2(rt.sizeDelta.x, chartHeight * normalizedValue);
            }

            //rt.sizeDelta = new Vector2(rt.sizeDelta.x, chartHeight * normalizedValue);
        }
    }

}
