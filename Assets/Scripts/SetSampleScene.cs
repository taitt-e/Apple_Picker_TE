using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetSampleScene : MonoBehaviour
{
    public Button setButton;
    // Start is called before the first frame update
    void Start()
    {
        //Setup task listener for button on click
        Button btn = setButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //If button is clicked set the scene to the main game scene
        SceneManager.LoadScene("SampleScene");
    }
}
