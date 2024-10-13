using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Join : MonoBehaviour
{
    [SerializeField] private Transform playerNameChangeUI;

    public TMP_InputField inputName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckName()
    {
        if (inputName.text.Length < 2)
        {
            return;
        }
        else
        {
            GameManager.Instance.PlayerName = inputName.text;
            SceneManager.LoadScene("MainScene");
        }
    }

    public void CheckNameNotLoadScene()
    {
        if (inputName.text.Length < 2)
        {
            return;
        }
        else
        {
            playerNameChangeUI.gameObject.SetActive(false);
            GameManager.Instance.PlayerName = inputName.text;
        }
    }
}
