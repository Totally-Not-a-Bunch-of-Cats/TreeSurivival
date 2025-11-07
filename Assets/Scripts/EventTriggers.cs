using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventTriggures
{

    //add of lose tree health
    public void TreeHealth(int hpchange)
    {
        GameManager.Instance._treeManager.ChangeTreeHP(hpchange);
    }
    //add of spend energy
    public void Energy()
    {

    }
    //add or spend water
    public void Water()
    {

    }
    //add or spend Phosphorus
    public void Phosphorus()
    {

    }
    //add or spend Potassium
    public void Potassium()
    {

    }
    //add or spend nitrogen
    public void Nitrogen()
    {

    }
}
