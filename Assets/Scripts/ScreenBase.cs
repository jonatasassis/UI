using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;

namespace Screens
{
    public class ScreenBase : MonoBehaviour
    {
        public enum screenTipe
        {
            MenuInicial,
            Jogar,
            Sobre,
            Sair
        }

        public screenTipe screen;
        public List<Transform> objetosTela;
        public bool startDisabled;

        [Header("Animacao dos botoes")]
        public static float delayAnimacaoBotoes=1;
        public static float duracaoAnimacaoBotoes=0.2f;
        public Typer frase;
        
     

        // Start is called before the first frame update

        private void Start()
        {
            frase.Escrever();
            if (startDisabled)
            {
                Esconder();
                
            }

            
        }

      

        [Button]
        protected virtual void Mostrar()
        {
            MostrarObjetos();
            
        }

        [Button]
        protected virtual void Esconder()
        {
            EsconderObjetos();
        }

        private void EsconderObjetos()
        {
            objetosTela.ForEach(t => t.gameObject.SetActive(false));
            
            
        }

       

        public void MostrarObjetos()
        {
            
            for (int i=0; i<objetosTela.Count;i++)
            {
                var botao= objetosTela[i];
                botao.gameObject.SetActive(true);
                botao.DOScale(0, duracaoAnimacaoBotoes).From().SetDelay(i*delayAnimacaoBotoes) ;
                
            }
            
            //objetosTela.ForEach(t => t.gameObject.SetActive(true));
        }

      

    }
}
