using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;

    [SerializeField] private GameObject penguin;
    [SerializeField] private GameObject deathBringer;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance != null)
            nameText.text = GameManager.Instance.PlayerName;

        SetPlayerSprite();

        GameManager.Instance.SetPlayer(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName()
    {
        nameText.text = GameManager.Instance.PlayerName;
    }

    public void SetPlayerSprite()
    {
        var type = GameManager.Instance.playerCharacter;

        switch (type)
        {
            case CharacterType.Penguin:
                penguin.gameObject.SetActive(true);
                deathBringer.gameObject.SetActive(false);
                break;

            case CharacterType.DeathBringer:
                penguin.gameObject.SetActive(false);
                deathBringer.gameObject.SetActive(true);
                break;
        }
    }
}
