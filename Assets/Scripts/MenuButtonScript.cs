using UnityEngine;
using System.Collections;

public class MenuButtonScript : MonoBehaviour
{

    public void OnClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1");
    }

}