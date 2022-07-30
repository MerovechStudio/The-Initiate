using System;
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

        playerFavorText.text = playerData.playerFavor.ToString();

        GenerateNewSpells();

    }
    public void GenerateNewSpells()
    {

        foreach(Spell spell in spellBook.spells)

        {
            // Create Rune Array at Runtime
            GameObject newRune = Instantiate(masterRune);
            RuneButton runeButton = newRune.GetComponent<RuneButton>();

            // Set Up Components
            runeButton.Setup(spell);
            runeButton.spellNameLabel.text = spell.spellNameLabel;
            runeButton.spell = spell;
            runeButton.runeImage.sprite = spell.newSpellGem;

            // Set Duration Text
            runeButton.countdownText.text = spell.spellDurationInSeconds.ToString();

            // Set Prefab Parent
            newRune.transform.SetParent(spellHolder.transform);

            runeButton.castButton.onClick.AddListener(delegate { CastSpell(runeButton); });
            spell.inProgress = false;

        }
        

    }

    void CastSpell(RuneButton runeButton) {

        if(runeButton.spell.inProgress) {
        return;
        }

        StartCoroutine(WaitForSpell(runeButton));

    }

    IEnumerator WaitForSpell(RuneButton runeButton) {

        Spell spell = runeButton.spell;
        spell.inProgress = true;

        int currentTimer = spell.spellDurationInSeconds;
        while(currentTimer > 0) {

            yield return new WaitForSeconds(1);
            currentTimer--;
            runeButton.SetCastTime(currentTimer);
        }

        playerData.playerFavor += spell.spellValue;
        runeButton.ResetSpellTime();
        playerFavorText.text = playerData.playerFavor.ToString();
        spell.inProgress = false;

    }

}
