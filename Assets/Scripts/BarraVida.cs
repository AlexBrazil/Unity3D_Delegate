using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class BarraVida : MonoBehaviour
{
    [SerializeField] private RectTransform barra;
    public Player player;

    private void OnEnable()
    {
        player.onHealthChanged += AtualizarBarra;
    }

    private void OnDisable()
    {
        player.onHealthChanged -= AtualizarBarra;
    }
    public void AtualizarBarra(float health)
    {
        float tamanhoAtual = barra.sizeDelta.x;
        float novoTanaho = (tamanhoAtual * health)/100;
        if (novoTanaho < 0)
            novoTanaho = 0;

        barra.sizeDelta = new Vector2(novoTanaho, barra.sizeDelta.y);
    }
}
