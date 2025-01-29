using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private Jetpack _jetpack;
    [SerializeField] private PlayerMovement _playerMovement;

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            //Horizontal Fly
            _jetpack.FlyHorizontal(Jetpack.Direction.Right);

            //Moving while falling
            _jetpack.Falling(Jetpack.Direction.Right);

            //Look at the left/right
            _playerMovement._changeSide = true;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            //Horizontal Fly
            _jetpack.FlyHorizontal(Jetpack.Direction.Left);

            //Moving while falling
            _jetpack.Falling(Jetpack.Direction.Left);

            //Look at the left/right
            _playerMovement._changeSide = false;
        }

        //Vertical Fly
        if (Input.GetAxis("Vertical") > 0)
            _jetpack.FlyUp();
        else
            _jetpack.StopFlying();


        //Side Propulsors
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (_playerMovement._changeSide == false)
                _playerMovement._changeSide = true;

            _jetpack.SidePropulsorLeft();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_playerMovement._changeSide == true)
                _playerMovement._changeSide = false;
            _jetpack.SidePropulsorRight();
        }

    }
}
