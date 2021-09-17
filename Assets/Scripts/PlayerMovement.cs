using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{

    private Vector2 screenBounds;
    // Start is called before the first frame update
    private PlayerInput _playerInput;
   [SerializeField]private float speed;
    private void Awake() {
        _playerInput= GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {


        Vector2 movement = _playerInput.movementInput;
        movement.Normalize();
        movement *= speed * Time.deltaTime;
        Debug.Log(movement.x);
        
        transform.Translate(movement.x,movement.y,0f);

    }
}
