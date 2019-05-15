using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validateMuve : MonoBehaviour {

    public GameObject validated;
    private Coroutine countValidated;

    public void validateMyMuve(float time)
    {
        countValidated = StartCoroutine(CountDownMuve(time));
    }

    private IEnumerator CountDownMuve(float time)
    {
        float timeLeftMuve = time;

        while (timeLeftMuve > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeftMuve--;
        }
        validated.SetActive(true);
    }

}
