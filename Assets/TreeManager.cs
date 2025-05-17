using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    [SerializeField] int TreeHealth;

    [SerializeField] List<RootInfo> Roots;
    [SerializeField] List<RootInfo> Branches;


    public int TreeHP()
    {
        return TreeHealth;
    }

    public void GenerateResources()
    {

    }
}
