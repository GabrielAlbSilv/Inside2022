using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public string[] speechTxt; //vetor de strings para o texto dos diálogos
    DialogControl obj;
    public LayerMask playerlayer;  //Layer (camada) onde o collider irá atuar, essa camada é criada dentro da Unity
    public float radious; //variável que define o tamanho do collider
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

    /*caso o jogador pressione espaço e esteja na área de colisão,
    a janela de diálogo vai abrir*/


    private int count = 0; //varíavel para proteger a exibição do texto
    
    private void Update()
    {
        Texto();
    }

    void Texto()
    {
        if (count < 1)
        {  //a frase só é exibida caso o contador for menor que 1
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

  
    public void Interact() //Detecção da colisão entre o player e o objeto de diálogo
    {
        //Collider 2D (em formato circular)       ponto onde collider será desenhado (centro do objeto), tamanho e layer (camada)
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerlayer);

        if (hit != null)
        {
            onradius = true; //Colisão ocorre caso o player entre na área de colisão
        }
        else
        {
            onradius = false;   //Caso o player não entre na área de colisão ela não ocorrerá
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radious); //Desenha uma esfera de colisão em um objeto
    }
}
