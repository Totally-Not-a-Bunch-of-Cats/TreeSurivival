using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    //primary Resources
    [SerializeField] int Water;
    [SerializeField] GameObject WaterObjBackGround;
    [SerializeField] GameObject WaterObjIcon;
    [SerializeField] int Energy;
    [SerializeField] GameObject EnergyObjBackGround;
    [SerializeField] GameObject EnergyObjIcon;

    //Secondary Resources
    [SerializeField] int Phosphorus;
    [SerializeField] GameObject PhosphorusObj;
    [SerializeField] int Potassium;
    [SerializeField] GameObject PotassiumObj;
    [SerializeField] int Nitrogen;
    [SerializeField] GameObject NitrogenObj;
    [SerializeField] int TertiaryResources;
    [SerializeField] GameObject TertiaryResourcesObj;

    public void ChangeWater(int water)
    {
        Water += water;
    }
    public void ChangeEnergy(int energy)
    {
        Energy += energy;
    }
    public void ChangePhosphorus(int phosphorus)
    {
        Phosphorus += phosphorus;
    }
    public void ChangePotassium(int potassium)
    {
        Potassium += potassium;
    }
    public void ChangeNitrogen(int nitrogen)
    {
        Nitrogen += nitrogen;
    }
    public void ChangeTertiaryResources(int tertiaryResources)
    {
        TertiaryResources += tertiaryResources;
    }
}
