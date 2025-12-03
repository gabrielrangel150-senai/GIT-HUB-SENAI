using UnityEngine;
using TMPro;

public class ObjectManager : MonoBehaviour
{
    // Referência para o texto da UI
    public TextMeshProUGUI clickerCountText;

    // Contador de cliques
    public int clickCount = 0;

    // Ponto de spawn
    public Transform spawnPoint;

    // Objeto que será instanciado
    public GameObject spawnObject;

    // Referência ao Timer
    [SerializeField] private Timer meuTimer;

    void OnMouseDown()
    {
        // Só permite clicar se o timer não acabou
        if (meuTimer != null && meuTimer.acabou == false)
        {
            // Soma clique
            clickCount++;

            // Atualiza texto
            clickerCountText.text = clickCount.ToString();

            // Instancia o objeto no ponto de spawn
            Instantiate(spawnObject, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
