using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] ParticleSystem _confetti;
    private void OnTriggerEnter(Collider other)
    {
              

        if (other.TryGetComponent(out SnakeHead _head))
        {
            _confetti.Play();
            Debug.Log("WON");
            _head.ReachFinish();
        }
        
            
        
    }
}
