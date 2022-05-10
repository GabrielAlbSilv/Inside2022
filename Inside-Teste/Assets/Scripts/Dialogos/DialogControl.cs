using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogControl : MonoBehaviour
{
    [Header("Components")]          //Cabeçalho onde poderemos adicionar as frases dentro da Unity
    public GameObject dialgueObj; //Objeto que referencia a janela de dialogo
    public Text speechText;       // Variável que referencia o texto dos dialogo
    
    [Header("Settings")]
    public float typingSpeed;  //velocidade que o texto aperece
    private string[] sentences; //vetor de string que recebe as múltiplas frases
    private int index;

 

    //Método onde o diálogo é chamado dentro do objeto Texto (na Unity)
    public void Speech(string[]txt)
    {
        dialgueObj.SetActive(true);
        sentences = txt;
        StartCoroutine(TypeSentences());
    }

    //Velocidade que o texto é exibido 
    IEnumerator TypeSentences()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed); //espere por x segundos para exibir uma letra
        }
    }


    //função que chama a próxima frase
    public void NextSentence()
    {
        if(speechText.text == sentences[index])
        {
            if(index < sentences.Length - 1)
            {
                index++;
                speechText.text = "";
                StartCoroutine(TypeSentences());
            }
            else
            {
                speechText.text = "";
                index = 0;
                dialgueObj.SetActive(false);
            }
        }
    }
}
