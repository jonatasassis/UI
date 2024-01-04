using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using NaughtyAttributes;
using System;

public class Typer : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public float delayEscrita;
    public string frase;

    private void Awake()
    {
        
    }

    [Button]
    void Escrever()
    {
        StartCoroutine(DelayEscrever(frase));
    }

    IEnumerator DelayEscrever(string s) 
    {
        texto.text = "";

        foreach (char c in s.ToCharArray())
        {
            texto.text += c;
            yield return new WaitForSeconds(delayEscrita);
        }
    }
}
