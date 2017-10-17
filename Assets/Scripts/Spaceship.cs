using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spaceship : MonoBehaviour
{
    public SpriteRenderer SpaceshipSprite;
    public Image imageVida;
   public float moveHorizontal;
   public float moveVertical;
   
   


    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
        set
        {
            transform.position = value;
        }
    }
    public Image image
    {
        get
        {
            return imageVida;
        }
   
    }
    public Rigidbody2D Rigidbody
    {
        get
        {
            return GetComponent<Rigidbody2D>();
        }
     
    }
    
    public Quaternion Rotation
    {
        get
        {
            return transform.rotation;
        }
        set
        {
            transform.rotation = value;
        }
    }

    public Vector3 Scale
    {
        get
        {
            return transform.localScale;
        }
        set
        {
            transform.localScale = value;
        }
    }

    public Color Color
    {
        get
        {
            return SpaceshipSprite.color;
        }
        set
        {
            SpaceshipSprite.color = value;
        }
    }



  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
           
            imageVida.fillAmount= imageVida.fillAmount - 0.2f;
        }
      
      
    }

    // Use this for initialization
    void Start()
    {
        GameObject gameObjectimageVida = GameObject.Find("BarraDeVida");
        imageVida=gameObjectimageVida.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
