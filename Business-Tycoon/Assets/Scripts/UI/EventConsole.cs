using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class EventConsole : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI consoleTexts;

    List<string> events = new();
    int maxLines = 7;

    private void Start()
    {

        string lineToAdd = "\nthere is totally stuff here\n";
        events.Add(lineToAdd);

        foreach (var item in events)
        {

            consoleTexts.text += item;


        }
    }
    [ContextMenu("Start")]
    public void AddEvent(object eventName)
    {
        string eventToAdd = $"\n{eventName.ToString()}\n";

        consoleTexts.text = "";
      
        events.Add(eventToAdd);

        if(events.Count >= maxLines)
        {


            events.RemoveAt(0);

        }
        foreach (var item in events)
        {

            consoleTexts.text += item;

        }
        

    }


}
