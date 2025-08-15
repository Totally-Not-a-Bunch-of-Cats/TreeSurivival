using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    //primary Resources
    [SerializeField] int Water;
    public int MaxWater;
    [SerializeField] int Energy;
    public int MaxEnergy;

    //Secondary Resources
    [SerializeField] int Phosphorus;
    [SerializeField] int Potassium;
    [SerializeField] int Nitrogen;
    [SerializeField] int TertiaryResources;

    public int WaterLevel()
    {
        return Water;
    }
    public int EnergyLevel()
    {
        return Energy;
    }
    public int PhosphorusLevel()
    {
        return Phosphorus;
    }
    public int PotassiumLevel()
    {
        return Potassium;
    }
    public int NitrogenLevel()
    {
        return Nitrogen;
    }
    public int TertiaryResourcesLevel()
    {
        return TertiaryResources;
    }

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
