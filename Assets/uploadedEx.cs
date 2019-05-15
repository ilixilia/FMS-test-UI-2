using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uploadedEx : MonoBehaviour {

    public GameObject uploaded1;
    public GameObject uploaded2;
    public GameObject uploaded3;
    public GameObject uploaded4;
    public GameObject uploaded5;
    public GameObject uploaded6;
    public GameObject uploaded7;
    private Coroutine countValidated;

    public void uploadExercise1(float time)
    {
        countValidated = StartCoroutine(CountDownUpload1(time));
    }

    public void uploadExercise2(float time)
    {
        countValidated = StartCoroutine(CountDownUpload2(time));
    }

    public void uploadExercise3(float time)
    {
        countValidated = StartCoroutine(CountDownUpload3(time));
    }

    public void uploadExercise4(float time)
    {
        countValidated = StartCoroutine(CountDownUpload4(time));
    }

    public void uploadExercise5(float time)
    {
        countValidated = StartCoroutine(CountDownUpload5(time));
    }

    public void uploadExercise6(float time)
    {
        countValidated = StartCoroutine(CountDownUpload6(time));
    }

    public void uploadExercise7(float time)
    {
        countValidated = StartCoroutine(CountDownUpload7(time));
    }

    private IEnumerator CountDownUpload1(float time)
    {
        float timeLeftMuve = time;
               
        while (timeLeftMuve > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeftMuve--;
        }
        uploaded1.SetActive(true);
    }

    private IEnumerator CountDownUpload2(float time)
    {
        float timeLeftMuve = time;

        while (timeLeftMuve > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeftMuve--;
        }
        uploaded2.SetActive(true);
    }

    private IEnumerator CountDownUpload3(float time)
    {
        float timeLeftMuve = time;

        while (timeLeftMuve > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeftMuve--;
        }
        uploaded3.SetActive(true);
    }

    private IEnumerator CountDownUpload4(float time)
    {
        float timeLeftMuve = time;

        while (timeLeftMuve > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeftMuve--;
        }
        uploaded4.SetActive(true);
    }

    private IEnumerator CountDownUpload5(float time)
    {
        float timeLeftMuve = time;

        while (timeLeftMuve > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeftMuve--;
        }
        uploaded5.SetActive(true);
    }

    private IEnumerator CountDownUpload6(float time)
    {
        float timeLeftMuve = time;

        while (timeLeftMuve > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeftMuve--;
        }
        uploaded6.SetActive(true);
    }

    private IEnumerator CountDownUpload7(float time)
    {
        float timeLeftMuve = time;

        while (timeLeftMuve > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeftMuve--;
        }
        uploaded7.SetActive(true);
    }
}
