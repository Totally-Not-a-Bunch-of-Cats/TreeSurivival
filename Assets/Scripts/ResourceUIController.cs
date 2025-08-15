using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourceUIController : MonoBehaviour
{
    //primary Resources
    [SerializeField] GameObject WaterObjBackGround;
    [SerializeField] GameObject WaterObjIcon;
    [SerializeField] GameObject WaterObjNum;

    [SerializeField] GameObject EnergyObjBackGround;
    [SerializeField] GameObject EnergyObjIcon;
    [SerializeField] GameObject EnergyObjNum;

    [SerializeField] GameObject TreeHealthObj;
    [SerializeField] GameObject TreeHealthObjFill;
    [SerializeField] GameObject TreeObjNum;

    //Secondary Resources
    [SerializeField] GameObject PhosphorusObj;
    [SerializeField] GameObject PotassiumObj;
    [SerializeField] GameObject NitrogenObj;
    [SerializeField] GameObject TertiaryResourcesObj;

    //Updates the UI 
    private void Update()
    {
        //Updates Water and Energy
        WaterObjNum.GetComponent<TMP_Text>().text = GameManager.Instance._resourceManager.WaterLevel().ToString();
        EnergyObjNum.GetComponent<TMP_Text>().text = GameManager.Instance._resourceManager.EnergyLevel().ToString();
        TreeObjNum.GetComponent<TMP_Text>().text = GameManager.Instance._treeManager.TreeHP().ToString();
        float tempWater = GameManager.Instance._resourceManager.WaterLevel();
        float tempEnergy = GameManager.Instance._resourceManager.EnergyLevel();
        float tempHP = GameManager.Instance._treeManager.TreeHP();
        tempWater /= GameManager.Instance._resourceManager.MaxWater;
        tempEnergy /= GameManager.Instance._resourceManager.MaxEnergy;
        tempHP /= 100;
        //min fill level
        if (tempWater < .1f)
        {
            tempWater = .1f;
        }
        if (tempEnergy < .1f)
        {
            tempEnergy = .1f;
        }
        TreeHealthObjFill.GetComponent<Image>().fillAmount = tempHP;
        TreeHealthObj.GetComponent<Image>().fillAmount = tempHP;
        WaterObjBackGround.GetComponent<Image>().fillAmount = tempWater;
        WaterObjIcon.GetComponent<Image>().fillAmount = tempWater;
        EnergyObjBackGround.GetComponent<Image>().fillAmount = tempEnergy;
        EnergyObjIcon.GetComponent<Image>().fillAmount = tempEnergy;
        //Updates the Secondary Resources
        PhosphorusObj.GetComponent<TMP_Text>().text = "Phosphorus: " + GameManager.Instance._resourceManager.PhosphorusLevel().ToString();
        PotassiumObj.GetComponent<TMP_Text>().text = "Potassium: " + GameManager.Instance._resourceManager.PotassiumLevel().ToString();
        NitrogenObj.GetComponent<TMP_Text>().text = "Nitrogen: " + GameManager.Instance._resourceManager.NitrogenLevel().ToString();
        TertiaryResourcesObj.GetComponent<TMP_Text>().text = "TertiaryResources: " + GameManager.Instance._resourceManager.TertiaryResourcesLevel().ToString();
    }
}
