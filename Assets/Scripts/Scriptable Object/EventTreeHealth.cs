using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Event", menuName = "ScriptableObjects/Event/EventTreeHealth", order = 1)]
public class EventTreeHealth : EventAction
{
    public int TreeHPChange = 0;


    public override void DoAction()
    {
        GameManager.Instance._treeManager.ChangeTreeHP(TreeHPChange);
    }
}
