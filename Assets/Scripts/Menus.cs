using Screens;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menus : MonoBehaviour
{
    public List<GameObject> menus;
    public int proximaTela;
    public ScreenBase screen;
    public ParticleSystem efeitoBotao;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void TrocarCena()
    {
       for(int t=0;t<menus.Count;t++) 
        {
            if (t != proximaTela)
            {
                menus[t].SetActive(false);
                
            }
            else
            {
                menus[t].SetActive(true);
                screen.MostrarObjetos();
                
            }

        }
    }

    public void AtivarEfeitoBotao()
    {
        efeitoBotao.Play();
        StartCoroutine(DelayTrocarTela());
    }
    IEnumerator DelayTrocarTela()
    {

        yield return new WaitForSeconds(0.5f);
        TrocarCena();

    }
}
