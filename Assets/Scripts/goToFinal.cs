using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToFinal : MonoBehaviour {

    public GameObject generatingReport;

    // to go to another scene by its name
    public void ChangeToFinal(string goToScene)
    {

        Test();
        SceneManager.LoadScene(goToScene);
        //Application.LoadLevel(goToScene);
    }

    IEnumerator Test()
    {
        generatingReport.SetActive(true);
        yield return new WaitForSeconds(3);
    }
}
