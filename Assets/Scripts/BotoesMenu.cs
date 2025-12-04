using UnityEngine;
using UnityEngine.SceneManagement; 


public class BotoesMenu : MonoBehaviour
{
	public void IniciarJogo()
	{
	 SceneManager.LoadScene("GameScene");
	}

    	public void VoltarAoMenu()
    {
	ScenemManager.LoadScene("SampleScene");
    }

    	public void SairDoJogo()
    {
	Apllication.Quit(TitleScreen);
    }
        
    }
}
