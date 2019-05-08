using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WindowController : MonoBehaviour {

    [SerializeField]
    public GameObject modalWindow;

    private Coroutine countDownCoroutine;
       
	 
    public void Show(float time)
    {
        modalWindow.SetActive(true);
        countDownCoroutine = StartCoroutine(CountDown(time));
    }

    private IEnumerator CountDown(float time)
    {
        float timeLeft = time;
               
        while(timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }

        modalWindow.SetActive(false);
        SceneManager.LoadScene("Report");
    }
}
