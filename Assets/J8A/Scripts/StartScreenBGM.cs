using UnityEngine;

public class StartScreenBGM : MonoBehaviour
{
    private AudioSource _audioSource;

    // animate the game object from -1 to +1 and back
    [SerializeField] private float minimum = -.81F;
    [SerializeField] private float maximum =  .81F;

    [SerializeField] private float speed = 0.05f;

    // starting value for the Lerp
    static float t;

    private void OnEnable()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // animate the position of the game object...
        _audioSource.panStereo = Mathf.Lerp(minimum, maximum, t);

        // .. and increase the t interpolater
        t += speed * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f)
        {
            (maximum, minimum) = (minimum, maximum);
            t = 0.0f;
        }
    }
}
