using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputInfo : MonoBehaviour {

    public Toggle isMale;
    public Toggle isFemale;
 
    //Age input field
    public InputField ageField;
    
    //Name input field
    public InputField userNameField;
 
    //Height input field
    public InputField heightField;
 
    //E-mail input field
    public InputField mailField;
  
    //Weight input field
    public InputField weightField;
  
    public string userAge;
    public string yourNam;
    public string userHeight;
    public string userMail;
    public string userWeight;
    public string userSex;

    //Check active toggle
    public void ActiveToggle()
    {
        userSex = "Male";

        if (isMale.isOn)
        {
            userSex = "Male";
        }
        else if (isFemale.isOn)
        {
            userSex = "Female";
        }
    }

    public void SaveInfo()
    {
        ActiveToggle();
        //set user info to text in input fields
        userAge = ageField.text;
        yourNam = userNameField.text;
        userHeight = heightField.text;
        userMail = mailField.text;
        userWeight = weightField.text;


        PlayerPrefs.SetString("Age", userAge);
        PlayerPrefs.SetString("Name", yourNam);
        PlayerPrefs.SetString("Height", userHeight);
        PlayerPrefs.SetString("Mail", userMail);
        PlayerPrefs.SetString("Weight", userWeight);
        PlayerPrefs.SetString("Sex", userSex);

        //display info in console
        Debug.Log(userAge + yourNam + userHeight + userMail + userWeight);
    }


    /*
    public void PassThroughScene()
    {
        DontDestroyOnLoad(ageField);
        DontDestroyOnLoad(userNameField);
        DontDestroyOnLoad(heightField);
        DontDestroyOnLoad(mailField);
        DontDestroyOnLoad(weightField);
    }
    */

}
