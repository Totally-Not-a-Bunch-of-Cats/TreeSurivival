using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    [SerializeField] int TreeHealth;

    [SerializeField] TrunkInfo Trunk;
    [SerializeField] List<RootInfo> Roots;
    [SerializeField] List<BranchInfo> Branches;


    public int TreeHP()
    {
        return TreeHealth;
    }
    public void ChangeTreeHP(int change)
    {
        TreeHealth += change;
    }

    public void GenerateResources()
    {
        GenerateBranchResources();
        GenerateRootResources();
    }

    void GenerateRootResources()
    {
        float Addwater = Roots[0].BaseWaterIncome + Roots[0].RootLevel/10 + Trunk.TrunkLevel * Roots[0].RootLevel;
        GameManager.Instance._resourceManager.ChangeWater(Addwater);
    }
    void GenerateBranchResources()
    {
        for (int i = 0; i < Branches.Count; i++)
        {
            float AddEnergy = Branches[i].BaseEnergyIncome + Branches[0].BranchLevel / 10 + Trunk.TrunkLevel * Branches[i].BranchLevel;
            //GameManager.Instance._resourceManager.ChangeEnergy(AddEnergy);
        }
    }
    
}
