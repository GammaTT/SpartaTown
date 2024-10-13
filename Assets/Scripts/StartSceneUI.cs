using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneUI : MonoBehaviour
{
    [SerializeField] private Sprite deathBringerImage;
    [SerializeField] private Sprite penguinImage;

    [SerializeField] private Image selectUIButtonImage;
    [SerializeField] private Transform selectCharacterUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerPenguin()
    {
        GameManager.Instance.playerCharacter = CharacterType.Penguin;
        selectUIButtonImage.GetComponent<Image>().sprite = penguinImage;
        selectCharacterUI.gameObject.SetActive(false);
    }

    public void SetPlayerDeathBringer()
    {
        GameManager.Instance.playerCharacter = CharacterType.DeathBringer;
        selectUIButtonImage.GetComponent<Image>().sprite = deathBringerImage;
        selectCharacterUI.gameObject.SetActive(false);
    }

    public void ButtonTest()
    {
        Debug.Log("Boo");
    }
}
