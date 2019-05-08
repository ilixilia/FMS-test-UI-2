using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Share : MonoBehaviour {

    [SerializeField]
    public GameObject shareWindow;

    /*void Start()
    {
        shareWindow.SetActive(false);
    }*/

    public void ShowShareWindow()
    {
        shareWindow.SetActive(true);
    }

}
