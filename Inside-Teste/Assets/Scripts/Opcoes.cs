using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //biblioteca da Unity para gerenciar cenas :)

public class Opcoes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveMenu()
    {
        SceneManager.LoadScene(1); //carregando outra cena, usando o valor de Build dela :)
    }

    public void VoltaInicio()
    {
        SceneManager.LoadScene(0);//carregando outra cena, usando o valor de Build dela :)
    }

    public void BtnJogar()
    {
        SceneManager.LoadScene(2);
    }

    public void BtnSair()
    {
        Application.Quit();
    }

    public void BtnEmJogo()
    {
        SceneManager.LoadScene(3);
    }

   public  void Pergunta1EscNao() 
    {
        SceneManager.LoadScene("EscolhaNao");
    }

    public void Pergunta1EscSim()
    {
        SceneManager.LoadScene("EscolhaSim");
    }
}
