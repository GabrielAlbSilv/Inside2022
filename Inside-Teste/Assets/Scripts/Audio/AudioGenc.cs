using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //biblioteca para gerenciar cenas



public class AudioGenc : MonoBehaviour
{
    void Update() //Void Uptade atualiza o script e checa do toda hora suas fun��es
    {
        if (SceneManager.GetActiveScene().buildIndex == 3) //Verficando se a cena 3 est� ativa
        {
            Destroy(this.gameObject); //caso esteja o Objeto Maintheme ser� destruido
        }
        else
        {
            DontDestroyOnLoad(this.gameObject); //caso n�o esteja o Objeto Maintheme n�o ser� destruido
        }
    }

}
