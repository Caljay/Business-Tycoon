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
       
        
    }
    [ContextMenu("Start")]
    public void AddEvent()
    {

        
        
    }


}
