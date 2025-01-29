using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorController : MonoBehaviour
{
    private Jetpack _jetpack;
    private PlayerMovement _playerMovement;
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _jetpack = GetComponent<Jetpack>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        // Flying animation
        _anim.SetBool("Flying", _jetpack._flying);

        //Fall animation
        _anim.SetBool("Falling", _jetpack._fall);

        //Running animation
        if (Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Horizontal") > 0)
            _anim.SetBool("Running", true);
        else
            _anim.SetBool("Running", false);

        //Side Propulsor animation
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
        {
            _anim.SetTrigger("SidePropulsor");
        }
    }
}
