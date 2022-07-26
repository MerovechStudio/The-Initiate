using System.Diagnostics;
using System.Security.AccessControl;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;


public class Controller : MonoBehaviour
{
public Text playerFavorText;
public PlayerData playerData;
public long playerFavor;
public Spell spell;

    // public void Update() {
        
    //     playerFavorText.text = playerFavor.ToString();
        
    // }

    // public void GenerateFavor() {

        
    //     playerFavor += 1;
    //     print("Cast");

    // }

    public void CastSpell() {

        playerData.playerFavor += spell.spellValue;
        playerFavorText.text = playerData.playerFavor.ToString();
    }

    public void CastSound () {

        var audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

}
