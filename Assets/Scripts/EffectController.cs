using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectController : MonoBehaviour
{
    public static EffectController instance;
    [SerializeField] ParticleSystem[] Confetti;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        foreach (var item in Confetti)
        {
            item.Stop();
        }
    }

    public void FinishEffect()
    {
        foreach (var item in Confetti)
        {
            item.Play();
        }
    }


}
