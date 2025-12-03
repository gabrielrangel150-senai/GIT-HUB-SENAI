using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoTimer;
    [SerializeField] float tempoRestante;

    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
        }
        else
        {
            tempoRestante = 0;
        }

        
        textoTimer.color = Color.red;
	//GameOver();
	Time.timeScale = 0f;	

        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);

        textoTimer.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
