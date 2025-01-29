using UnityEngine;

public class PropulsorAudioController : MonoBehaviour
{
    private AudioSource propulsorAudio;
    private Animator _animator;

    void Start()
    {
        propulsorAudio = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        AnimatorStateInfo stateInfo = _animator.GetCurrentAnimatorStateInfo(0);

        bool isFlying = Input.GetKey(KeyCode.W);
        bool sidePropulsionL = stateInfo.IsName("SidePropulsorLeft");
        bool sidePropulsionR = stateInfo.IsName("SidePropulsorRight");

        bool shouldPlayAudio = isFlying || sidePropulsionL || sidePropulsionR;

        if (shouldPlayAudio && !propulsorAudio.isPlaying)
        {
            propulsorAudio.Play();
        }
        else if (!shouldPlayAudio && propulsorAudio.isPlaying)
        {
            propulsorAudio.Stop();
        }
    }
}
