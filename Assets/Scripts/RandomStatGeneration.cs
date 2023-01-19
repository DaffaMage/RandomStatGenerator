using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class RandomStatGeneration : MonoBehaviour
{
    [SerializeField] TMP_InputField TotalDistributionField;
    [SerializeField] TMP_InputField StrengthDistributionField;
    [SerializeField] TMP_InputField AgilityDistributionField;
    [SerializeField] TMP_InputField IntelligenceDistributionField;
    [SerializeField] Button DistributionButton;

    // Start is called before the first frame update
    void Start()
    {
        if (TotalDistributionField == null) {
            Debug.LogError("Missing Distribution Field");
        }
        if (StrengthDistributionField == null) {
            Debug.LogError("Missing Strength Field");
        }
        if (AgilityDistributionField == null) {
            Debug.LogError("Missing Agility Field");
        }
        if (IntelligenceDistributionField == null) {
            Debug.LogError("Missing Intelligence Field");
        }
        if (DistributionButton == null) {
            Debug.LogError("Missing Distribution Button");
        }
        DistributionButton.onClick.AddListener(() => DistributeStats());
    }

    void DistributeStats() {
        int totalStat = Convert.ToInt32(TotalDistributionField.text);
        int strength, agility, intelligence;
        System.Random randomizer = new System.Random();

        strength = randomizer.Next(1, totalStat - 1);
        totalStat -= strength;
        agility = randomizer.Next(1, totalStat - 1);
        totalStat -= agility;
        intelligence = totalStat;

        StrengthDistributionField.text = strength.ToString();
        AgilityDistributionField.text = agility.ToString();
        IntelligenceDistributionField.text = intelligence.ToString();
    }
}
