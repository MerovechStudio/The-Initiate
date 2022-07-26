using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Spell", menuName = "ScriptableObjects/Spell", order = 1)]

public class Spell : ScriptableObject
{
    public string spellNameLabel;
    public int spellDurationInSeconds;
    public long spellValue;
    public long spellCost;
    public long spellCostMultiplier;
    [SerializeField] public Sprite newSpellGem;

    public bool inProgress;

}
