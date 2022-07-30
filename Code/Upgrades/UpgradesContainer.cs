using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeContainer", menuName = "ScriptableObjects/UpgradeContainer", order = 1)]

public class UpgradesContainer : ScriptableObject
{
    public Upgrade[] upgrades;

}
