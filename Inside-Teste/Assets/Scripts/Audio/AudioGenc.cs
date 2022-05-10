using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //biblioteca para gerenciar cenas



public class AudioGenc : MonoBehaviour
{
    void Update() //Void Uptade atualiza o script e checa do toda hora suas funções
    {
        if (SceneManager.GetActiveScene().buildIndex == 3) //Verficando se a cena 3 está ativa
        {
            Destroy(this.gameObject); //caso esteja o Objeto Maintheme será destruido
        }
        else
        {
            DontDestroyOnLoad(this.gameObject); //caso não esteja o Objeto Maintheme não será destruido
        }
    }

}
