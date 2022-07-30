using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade", menuName = "ScriptableObjects/Upgrade", order = 1)]

public class Upgrade : ScriptableObject
{

    [Header("Text Elements")]
    public string upgradeNameLabel;
    public string upgradeTitle;
    public string upgradeDescription;

    [Header("Numbers")]
    public int upgradeFavorMultiplier;
    public int upgradeTimeMultiplier;
    public int upgradeCost;

}
