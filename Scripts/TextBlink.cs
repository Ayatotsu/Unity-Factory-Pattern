using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBlink : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMessage;
    [SerializeField] private float blinkInterval = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        if(textMessage == null)
        {
            textMessage = GetComponent<TextMeshProUGUI>();
        }

        StartCoroutine(BlinkText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator BlinkText()
    {
        while(true)
        {
            textMessage.enabled = !textMessage.enabled; //Toggle visibility
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
