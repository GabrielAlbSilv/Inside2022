using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public string[] speechTxt; //vetor de strings para o texto dos di�logos
    DialogControl obj;
    public LayerMask playerlayer;  //Layer (camada) onde o collider ir� atuar, essa camada � criada dentro da Unity
    public float radious; //vari�vel que define o tamanho do collider
    private DialogControl dc;
    bool onradius;
    int esc;

    private void Start()
    {
        dc = FindObjectOfType<DialogControl>(); //busca na cena um objeto que tenha o script DialogControl anexado nele
   
    }

    public void FixedUpdate()
    {
        Interact();
    }

    /*caso o jogador pressione espa�o e esteja na �rea de colis�o,
    a janela de di�logo vai abrir*/


    private int count = 0; //var�avel para proteger a exibi��o do texto
    
    private void Update()
    {
        Texto();
    }

    void Texto()
    {
        if (count < 1)
        {  //a frase s� � exibida caso o contador for menor que 1
            if (Input.GetKeyDown(KeyCode.Space) && onradius)
            {
                dc.Speech(speechTxt);
                count++;
            }
            if (esc == 2)
            {
                obj.dialgueObj.SetActive(false);
            }
        }
    }

  
    public void Interact() //Detec��o da colis�o entre o player e o objeto de di�logo
    {
        //Collider 2D (em formato circular)       ponto onde collider ser� desenhado (centro do objeto), tamanho e layer (camada)
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerlayer);

        if (hit != null)
        {
            onradius = true; //Colis�o ocorre caso o player entre na �rea de colis�o
        }
        else
        {
            onradius = false;   //Caso o player n�o entre na �rea de colis�o ela n�o ocorrer�
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radious); //Desenha uma esfera de colis�o em um objeto
    }
}
