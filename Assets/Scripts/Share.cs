using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Share : MonoBehaviour {

    [SerializeField]
    public GameObject shareWindow;
    public GameObject sentWindow;

    private Coroutine sentTimeCoroutine;

    public void ShowShareWindow()
    {
        shareWindow.SetActive(true);
    }

    public void ShowSentWindow(float sentTime)
    {
        sentWindow.SetActive(true);
        sentTimeCoroutine = StartCoroutine(CountSentTime(sentTime));
    }

    private IEnumerator CountSentTime(float sentTime)
    {
        float sentTimeLeft = sentTime;

        while(sentTimeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            sentTimeLeft--;
        }

        shareWindow.SetActive(false);
        sentWindow.SetActive(false);
        SceneManager.LoadScene("Report");
    }

}
