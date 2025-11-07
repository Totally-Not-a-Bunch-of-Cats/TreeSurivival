using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] float EventWaitTime = 60f;
    [SerializeField] int BadEventChance = 0;
    [SerializeField] List<Event> StandardEvents;
    [SerializeField] List<Event> StartingEvents;
    [SerializeField] List<Event> BadEvents;


    void RollStartingEvent()
    {



        StartCoroutine(EventCountDown());
    }

    void NextEvent()
    {
        BadEventChance += 1;
    }


    //counts down to next 
    IEnumerator EventCountDown()
    {
        yield return new WaitForSeconds(EventWaitTime);
        NextEvent();
    }
}
