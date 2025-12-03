using UnityEngine;
using TMPro;

public class ObjectManager : MonoBehaviour
{
    
    public TextMeshProUGUI clickerCountText;

    
    public int clickCount = 0;

    
    public Transform spawnPoint;

    
    public GameObject spawnObject;

    
    [SerializeField] private Timer meuTimer;

    void OnMouseDown()
    {
        // Só permite clicar se o timer não acabou
        if (meuTimer != null && meuTimer.acabou == false)
        {
            
            clickCount++;

           
            clickerCountText.text = clickCount.ToString();

            
            Instantiate(spawnObject, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
