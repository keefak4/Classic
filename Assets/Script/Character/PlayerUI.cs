using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Slider helthSliderMaxVal;
    [SerializeField] private Slider helthSliderVal;
    [SerializeField] private Slider energySliderMaxVal;
    [SerializeField] private Slider energySliderVal;
    [SerializeField] private PlayerManager playerManager;

    private void Update()
    {
        helthSliderMaxVal.maxValue = playerManager.helthMax;
        helthSliderVal.value = playerManager.helth;
        energySliderMaxVal.maxValue = playerManager.energyMax;
        energySliderVal.value = playerManager.energy;
    }
}
