using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rbody;
    bool verDerecha = true;
    public float fuerzaSalto;
    public bool pisando = false;
    public Transform pies;
    public LayerMask QueEsPiso;
    float radioPies = 0.2f;
   
    
    public AudioSource sfx;
    public AudioClip slide;
    //public AudioClip ;
    //public AudioClip attack2;
    public AudioClip jump;

    public Text personas;
    public Text comida;
    public Text agua;

    private bool inventoryEnabled;
    public GameObject inventory;

    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;
    public GameObject slotHolder;

    // Start is called before the first frame update
    void Start(){
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
        
        personas.text = "x"+GameObject.Find("GameManager").GetComponent<GameManager>().personas.ToString();
        comida.text = "x"+GameObject.Find("GameManager").GetComponent<GameManager>().comida.ToString();
        agua.text = "x"+GameObject.Find("GameManager").GetComponent<GameManager>().agua.ToString();

        allSlots = 16;
        slot = new GameObject[allSlots];
        for(int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update(){ 
        
        if (Input.GetKey(KeyCode.S) && pisando){
            anim.Play("Protagonista_deslizar");
            sfx.clip = slide;
            sfx.Play();
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && pisando){
            sfx.clip = jump;
            sfx.Play();           
            rbody.AddForce(new Vector2(0, fuerzaSalto));
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;
        }

        if(inventoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("movimiento", Mathf.Abs(move));
        rbody.velocity = new Vector2(move * 5f, rbody.velocity.y);

        pisando = Physics2D.OverlapCircle(pies.position,radioPies,QueEsPiso);
        // Overlap crea un circulo sobre el objeto en cuestión que en este caso es pies, pregunta si esta pisando y regresa un valor booleano

        anim.SetFloat("altura", rbody.velocity.y);
        anim.SetBool("piso", pisando);

        if (move > 0 && !verDerecha)
            Flip();
        else if (move < 0 && verDerecha)
            Flip();
    }

    void Flip()
    {
        verDerecha = !verDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item")
        {
            GameObject itemPickedUp = collision.gameObject;
            Item item = itemPickedUp.GetComponent<Item>();
            AddItem(item.ID, item.type, item.description, item.icon);
        }
    }

    void AddItem(int itemID, string itemType, string itemDescription, Texture2D itemIcon)
    {
        for(int i = 0; i < allSlots; i++)
        {

        }
    }

    private void OnCollision2D(Collider2D objeto)
    {
        string caso = objeto.gameObject.tag;
        switch (caso)
        {
            case "vida":
                break;
            default:

                break; 
               
        }
       

        


    }


}
