using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartGame : MonoBehaviour
{
    public void StartGameButtonClicked()
    {
        SceneManager.LoadScene("World Scene");
    }
}
