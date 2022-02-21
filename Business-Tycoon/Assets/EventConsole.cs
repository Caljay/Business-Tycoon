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
        int i = 0;
        while (i < 6)
        {
            events.Add(consoleTexts.text = consoleTexts.text + $"\nThere is stuff here for sure... defenitly... 100%\n");
            // consoleTexts.text = consoleTexts.text + $"\nThere is stuff here for sure... defenitly... 100%\n";
            i++;
        }
        foreach (var item in events)
        {
            consoleTexts.text += item;
        }
        
    }
    [ContextMenu("Start")]
    public void AddEvent()
    {

        
        
    }


}
