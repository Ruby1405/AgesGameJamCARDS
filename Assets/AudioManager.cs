using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioManager : MonoBehaviour

{
    [field: Header("UI")]
    [field: SerializeField] public EventReference select { get; private set; }
    [field: SerializeField] public EventReference confirm { get; private set; }

    [field: Header("PLAYER")]
    [field: SerializeField] public EventReference Swim { get; private set; }
    [field: SerializeField] public EventReference projectile { get; private set; }
    [field: SerializeField] public EventReference powerUP { get; private set; }
    [field: SerializeField] public EventReference crash { get; private set; }

    [field: Header("MUSSCHHUK")]
    [field: SerializeField] public EventReference intro { get; private set; }
    [field: SerializeField] public EventReference mainMusic { get; private set; }


    public static AudioManager instance { get; private set; }
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("This game is only big enough for ONE audiomanager");
        }
        instance = this;
    }

}
