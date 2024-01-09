using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Botao : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public float tempoAnimacaoBotao;
    public float tamanhoFinalBotao;
    private Vector3 tamanhoPadraoBotao;
    private Tween tweenAtual;

    void Awake()
    {
        tamanhoPadraoBotao = new Vector3(1,1,1);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        tweenAtual = transform.DOScale(tamanhoPadraoBotao * tamanhoFinalBotao, tempoAnimacaoBotao);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tweenAtual.Kill();
        transform.localScale = tamanhoPadraoBotao;
    }

   
}
