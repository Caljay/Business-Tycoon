using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    int year = 0;
    int month = 1;
    [SerializeField] float monthTimer = 60f;
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
            monthTimer = 60f;
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
        FindObjectOfType<ProfitsManager>().EndMonth();



        monthTimer = 60f;
    }

    void Display()
    {
        dateText.text = $"Year: {year}\nMonth: {month}";


    }
}

