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
        consoleTexts.text = "";
        
    }
    [ContextMenu("Start")]
    public void AddEvent(string message)
    {
        events.Add(message);
        if(events.Count > maxLines)
        {
            events.RemoveAt(0);
        }

        consoleTexts.text = null;
        foreach (string msg in events)
        {
            consoleTexts.text += $"{msg}\n";
        }
        
        
    }


}
