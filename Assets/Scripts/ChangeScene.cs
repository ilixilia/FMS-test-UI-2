using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    // to go to another scene by its name
    public void ChangeToScene(string goToScene)
    {
        SceneManager.LoadScene(goToScene);
        //Application.LoadLevel(goToScene);
    }
}
