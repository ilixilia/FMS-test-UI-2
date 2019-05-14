using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipToggle : MonoBehaviour {

    public Toggle skipped1;
    public Toggle uploaded1;
    public Toggle skipped2;
    public Toggle uploaded2;
    public Toggle skipped3;
    public Toggle uploaded3;
    public Toggle skipped4;
    public Toggle uploaded4;
    public Toggle skipped5;
    public Toggle uploaded5;
    public Toggle skipped6;
    public Toggle uploaded6;
    public Toggle skipped7;
    public Toggle uploaded7;
    public Text skipExercise;
    public GameObject NotaBene;
    private Coroutine showNote;

    public void ifSkipped(float time1)
    {
        skipExercise.text = "NB: If you skip the exercise, it will not be counted as done even if you could perfom it";

        if (skipped1.isOn && uploaded1.isOn || skipped2.isOn && uploaded2.isOn || skipped3.isOn && uploaded3.isOn || skipped4.isOn && uploaded4.isOn || skipped5.isOn && uploaded5.isOn || skipped6.isOn && uploaded6.isOn || skipped7.isOn && uploaded7.isOn)
        {
            NotaBene.SetActive(true);
            showNote = StartCoroutine(countNote(time1));
        }

    }
    
    private IEnumerator countNote(float time1)
    {
        float noteTime = time1;

        while(noteTime > 0)
        {
            yield return new WaitForSeconds(1);
            noteTime--;
        }

        NotaBene.SetActive(false);
    }
}
