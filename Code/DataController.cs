using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataController : MonoBehaviour
{
    public PlayerData playerData;
    public GameManager gameManager;

    public void ResetData()
    { 
        playerData.playerFavor = 0;
        gameManager.playerFavorText.text = "0";
    }
}
