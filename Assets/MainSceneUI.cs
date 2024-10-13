using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class MainSceneUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private GameObject penguin;
    [SerializeField] private GameObject deathBringer;

    [SerializeField] private GameObject selectCharacterUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }

    public void SetPlayerPenguin()
    {
        GameManager.Instance.playerCharacter = CharacterType.Penguin;
        penguin.gameObject.SetActive(true);
        deathBringer.SetActive(false);
        selectCharacterUI.SetActive(false);
        //selectUIButtonImage.GetComponent<Image>().sprite = penguinImage;
        //selectCharacterUI.gameObject.SetActive(false);
    }

    public void SetPlayerDeathBringer()
    {
        GameManager.Instance.playerCharacter = CharacterType.DeathBringer;
        penguin.gameObject.SetActive(false);
        deathBringer.SetActive(true);
        selectCharacterUI.SetActive(false);
        //selectUIButtonImage.GetComponent<Image>().sprite = deathBringerImage;
        //selectCharacterUI.gameObject.SetActive(false);
    }
}
