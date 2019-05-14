using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowVideo : MonoBehaviour {

    [SerializeField]
    public GameObject videoWindow1;
    public GameObject videoWindow2;
    public GameObject videoWindow3;
    public GameObject videoWindow4;
    public GameObject videoWindow5;
    public GameObject videoWindow6;
    public GameObject videoWindow7;

    public void showVideo(GameObject video)
    {
        video.SetActive(true);
    }

    public void closeVideo(GameObject video)
    {
        video.SetActive(false);
    }

}
