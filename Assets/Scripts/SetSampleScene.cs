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
        Button btn = setButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
