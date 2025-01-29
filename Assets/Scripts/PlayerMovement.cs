using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Private Attributes
    private PlayerDetections _playerDetections;
    private float _speedWalk = 5;
    public bool _changeSide;
    public bool canRun;

    private void Awake()
    {
        _playerDetections = GetComponent<PlayerDetections>();
    }

    void Update()
    {
        //Left/Right Movement
        if (_playerDetections.IsGrounded)
        {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * _speedWalk);
        }

        if (_changeSide == true) // LOOK AT THE RIGHT -->
            transform.localScale = new Vector2(2.321854f, 2.321854f);

        if (_changeSide == false) //LOOK AT THE LEFT <--
            transform.localScale = new Vector2(-2.321854f, 2.321854f);
    }
}
