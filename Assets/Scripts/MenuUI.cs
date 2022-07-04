using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUI : MonoBehaviour
{

    [SerializeField] private TMP_InputField usernameInput;

    public string username;


    public void StartPressed()
    {
        MenuManager.Instance.username = usernameInput.text;
        SceneManager.LoadScene(1);

        
    }
}
