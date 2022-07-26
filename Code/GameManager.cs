using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public SpellBook spellBook;
    public PlayerData playerData;
    public GameObject masterRune;
    public GameObject spellHolder;
    public Text playerFavorText;

    void Start()
    {

        // playerFavorText.text = playerData.playerFavor.ToString();

        GenerateNewSpells();

    }
    public void GenerateNewSpells()
    {

        foreach(Spell spell in spellBook.spells)
        {
            // Create Rune Array at Runtime
            GameObject newRune = Instantiate(masterRune);
            
            RuneButton runeButton = newRune.GetComponent<RuneButton>();

            // Change Spell Name Text on Prefab
            runeButton.spellNameLabel.text = spell.spellNameLabel;
            runeButton.spell = spell;

            // Set Prefab Parent
            newRune.transform.SetParent(spellHolder.transform);

        }

        

    }

}
