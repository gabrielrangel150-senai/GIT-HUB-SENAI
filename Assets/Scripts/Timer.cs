using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoTimer;
    [SerializeField] float tempoRestante;

    public bool acabou = false;

    void Update()
    {
        if (acabou == false)
        {
            if (tempoRestante > 0)
            {
                tempoRestante -= Time.deltaTime;
            }
            else
            {
                tempoRestante = 0;
                acabou = true;

                // PARA O JOGO SÓ QUANDO ACABAR
                Time.timeScale = 0f;
            }
        }

        // Cor do texto pode mudar normal
        textoTimer.color = Color.red;

        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);

        textoTimer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
