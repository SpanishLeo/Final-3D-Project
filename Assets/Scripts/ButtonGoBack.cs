using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGoBack : MonoBehaviour
{
    public void GoBackButtonClicked()
    {
        SceneManager.LoadScene("End Scene");
    }
}
