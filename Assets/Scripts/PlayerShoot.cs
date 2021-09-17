using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{


 [SerializeField] private GameObject prefab;
    Rigidbody2D rigidbody;

private PlayerInput _playerInput;

       private void Awake() {
        _playerInput= GetComponent<PlayerInput>();
    }
    // Start is called before the first frame update
   // [SerializeField] private Transform parent;
    void Start()
    {
        //    var action = new Input.GetButtonDown("Fire1");
        //    action.AddCompositeBinding("Axis").With("Positive", "<Keyboard>/RightArrow")
        //.With("Negative", "<Gamepad>/LeftArrow");
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //  if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    GameObject ger = GameObject.Instantiate(prefab, transform);
        //    rigidbody.AddForce(new Vector3(100, 0));


        //}


    }
}
