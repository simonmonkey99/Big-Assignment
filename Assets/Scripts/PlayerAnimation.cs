using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private string spriteNames = "part_explosion";
    private Rect buttonPos;
    private int spriteVersion = 0;
    private SpriteRenderer spriteR;
    [SerializeField] private Sprite[] sprites = new Sprite[10];
    // Start is called before the first frame update
    void Start()
    {
       
        spriteR = gameObject.GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
      


    }
    public void Sprite(int i)
    {

        
       spriteR.sprite = sprites[i];

    }
    void OnGUI()
    {
        if (GUI.Button(buttonPos, "Choose next sprite"))
        {
            spriteVersion += 1;
            if (spriteVersion > 3)
                spriteVersion = 0;
            spriteR.sprite = sprites[spriteVersion];
        }
    }

}
