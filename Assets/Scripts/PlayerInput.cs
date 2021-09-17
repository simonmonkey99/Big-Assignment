using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 movementInput {get; private set;}
    public float cooldown = 1f;
    public float theTimerguy=0;
    PlayerAnimation playerAnimation; 
    private Points _points;

    [SerializeField] private GameObject prefab;

    void Awake()
    {

        playerAnimation = GetComponent<PlayerAnimation>();
        _points = GameObject.Find("Text").GetComponent<Points>();


    }
    // Update is called once per frame
    void Update()
    {
      
       movementInput= new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

      

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BulletFunction(3, 200);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BulletFunction(2, -200);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            BulletFunction(1,0 , 200);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            BulletFunction(0, 0, -200);

        }
     



    }



    void BulletFunction(int i, int x, int y = 0)
    {
        if (Time.time > theTimerguy)
        {
            GameObject ger = GameObject.Instantiate(prefab);
            ger.transform.position = transform.position + new Vector3(0, 0.2f);
            ger.GetComponent<Rigidbody2D>().AddForce(new Vector3(x, y));
            playerAnimation.Sprite(i);

            theTimerguy = Time.time + cooldown;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemyguy"))
        {
            
            SceneManager.LoadScene(0);
            Points.points = 0;

        }
    }
}
