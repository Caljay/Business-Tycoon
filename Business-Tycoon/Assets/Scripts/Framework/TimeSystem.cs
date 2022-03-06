using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    int year = 0;
    int month = 1;
    [SerializeField] float monthTimer = 5f;
    [SerializeField] TMPro.TextMeshProUGUI dateText;

    private void Start()
    {
        if (month <= 0)
        {
            month = 1;
        }
        if (month > 12)
        {
            year++;
            month = 1;
        }
        Display();
    }

    private void Update()
    {
        monthTimer -= Time.deltaTime;
        if (monthTimer <= 0)
        {
            EndMonth();
            monthTimer = 5f;
        }
    }



    public void EndMonth()
    {
        month++;
        if (month > 12)
        {
            year++;
            month = 1;
        }

        Display();
        string msg = $"Current date {year}/{month}";
        FindObjectOfType<EventConsole>().AddEvent(msg);
        FindObjectOfType<ProfitsManager>().EndMonth();



        monthTimer = 5f;
    }

    void Display()
    {
        dateText.text = $"Year: {year}\nMonth: {month}";


    }
}

