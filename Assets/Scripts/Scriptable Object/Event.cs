using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Event", menuName = "ScriptableObjects/New Event", order = 0)]
public class Event : ScriptableObject
{
    [SerializeField] string EventName;
    [SerializeField] List<string> Text;
    [SerializeField] Sprite Art;
}
