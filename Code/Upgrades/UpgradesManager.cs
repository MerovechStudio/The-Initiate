using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesManager : MonoBehaviour
{
    public UpgradesContainer upgradesContainer;
    public PlayerData playerData;
    public GameObject upgradeCanvas;
    public GameObject upgradeHolder;



    public void GenerateNewSpells()
    {

        foreach (Upgrade upgrade in upgradesContainer.upgrades)

        {
               // Create Rune Array at Runtime
            GameObject newUpgrade = Instantiate(upgradeHolder);
            UpgradeInstance upgradeInstance = newUpgrade.GetComponent<UpgradeInstance>();

               // Set Up Components
               // runeButton.Setup(spell);
            upgradeInstance.upgradeNameLabel.text = upgrade.upgradeNameLabel;
            upgradeInstance.upgrade = upgrade;

               // Set Prefab Parent
            newUpgrade.transform.SetParent(upgradeCanvas.transform);

            upgradeInstance.buyUpgradeButton.onClick.AddListener(delegate { BuyUpgrade(upgradeInstance); });


        }
    }

    void CastSpell()
    {
        Console.Write("Bought Upgrade");
    }

}
