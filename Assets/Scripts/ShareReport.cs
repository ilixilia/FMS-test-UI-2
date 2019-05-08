using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShareReport : MonoBehaviour {

    public InputField email1;
    public InputField email2;
    public InputField email3;

    public string mail2;
    public string mail3;

    void Start()
    {
        email1.text = PlayerPrefs.GetString("Mail");
        Share();
    }

    public void Share()
    {
        mail2 = email2.text;
        mail3 = email3.text;

        PlayerPrefs.SetString("Mail2", mail2);
        PlayerPrefs.SetString("Mail3", mail3);
    }
}
