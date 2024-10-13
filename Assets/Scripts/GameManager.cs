using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;

    public static GameManager Instance;
    public CharacterType playerCharacter = CharacterType.Penguin;

    private string playerName; // backing field

    public event PlayerNameChange PlayerNameChanged;
    public string PlayerName
    {
        get
        {
            if (playerName.Length == 0)
                return "Hi";

            return playerName;
        }
        set
        {
            playerName = value;
            PlayerNameChanged?.Invoke();
        }
    }


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayer(Player player)
    {
        this.player = player;

        PlayerNameChanged += player.SetName;
    }
}

public delegate void PlayerNameChange();
public enum CharacterType
{
    Penguin,
    DeathBringer
}