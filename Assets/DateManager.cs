using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DateManager : MonoBehaviour
{
    [SerializeField] GameObject DateText;
    [SerializeField] string CurrentDate;
    [SerializeField] int CurrentDay = 1;
    [SerializeField] int CurrentYear = 1;
    [SerializeField] float DayDuration = 5f;
    [SerializeField] List<string> Seasons;
    [SerializeField] int CurrentSeason = 0;
    [SerializeField] int SeasonsDuration = 90;



    private void Start()
    {
        StartCoroutine(AdvanceDate());
    }

    public void StartDate()
    {
        StartCoroutine(AdvanceDate());
    }

    void UpdateDate()
    {
        if(CurrentDay >= SeasonsDuration)
        {
            CurrentDay = 1;
            if (Seasons[CurrentSeason] == Seasons[3])
            {
                CurrentYear += 1;
                CurrentSeason = 0;
            }
            else
            {
                CurrentSeason += 1;
            }
        }
        else
        {
            CurrentDay += 1;
        }
        CurrentDate = Seasons[CurrentSeason] + ",  Year: " + CurrentYear + ",  " + "Day: " + CurrentDay;
        DateText.GetComponent<TMP_Text>().text = CurrentDate;
        StartCoroutine(AdvanceDate());
    }



    IEnumerator AdvanceDate()
    {
        yield return new WaitForSeconds(DayDuration);
        UpdateDate();
    }

}
