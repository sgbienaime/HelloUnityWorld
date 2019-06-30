using System.Collections;
using UnityEngine;
using TMPro;

public class ChangeName : MonoBehaviour
{
  
    void Update()
    {
         if (Input.GetKeyDown("space"))
        {
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText("Hello World from Sara"); 
        }
    }
}
