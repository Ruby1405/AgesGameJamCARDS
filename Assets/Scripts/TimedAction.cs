using UnityEngine;
using UnityEngine.Events;

public class TimedAction : MonoBehaviour
{
    [SerializeField] private float delay = 1f;
    [SerializeField] private UnityEvent onTimeElapsed;

    void FixedUpdate()
    {
        delay -= Time.fixedDeltaTime;
        if (delay <= 0f)
        {
            onTimeElapsed?.Invoke();
            Destroy(gameObject);
        }
    }
}
