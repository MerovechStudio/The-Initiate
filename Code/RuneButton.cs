using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuneButton : MonoBehaviour
{

    [Header("Text Elements")]

    public Text buyPrice;
    public TMP_Text spellNameLabel;
    public Text levelCounter;
    public Text countdownText;

    [Header("UI Elements")]
    // public GameObject castButton;
    public Button castButton;
    public GameObject buyButton;
    public GameObject progressBar;
    public Image runeImage;
    public Spell spell;
    public bool spellCasting;

    public void Setup(Spell spell) {

        spellCasting = false;
        spellNameLabel.text = spell.spellNameLabel;
        this.spell = spell;
        ResetSpellTime();

    }
    

    public void SetCastTime(int timeLeftInSeconds) {

        TimeSpan spellDuration = new TimeSpan(0, 0, timeLeftInSeconds);
        countdownText.text = spellDuration.ToString("c");
    }

    public void ResetSpellTime() {

        TimeSpan spellDuration  = new TimeSpan(0, 0, spell.spellDurationInSeconds);
        countdownText.text = spellDuration.ToString("c");

}

}
