using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCredits : MonoBehaviour
{
    public void CreditsButtonClicked()
    {
        SceneManager.LoadScene("Credits Scene");
    }
}
