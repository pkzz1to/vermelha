using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManeger : MonoBehaviour
{
    public TextMeshProUGUI hud, menvitoria;
    public int restantes; 
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"Moedas: {restantes}";
    }

    public void Submoedas(int valor)
    {
        restantes = restantes - valor;
        hud.text = $"Moedas: {restantes}";

        if (restantes <= 0)
        {
            //ganhou jogo
            menvitoria.text = "Parabens";
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
