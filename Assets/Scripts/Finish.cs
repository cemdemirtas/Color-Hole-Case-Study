using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] Transform getSecondPart;
    bool IsTargetOver;
    private void Update()
    {
        if (getSecondPart.childCount <= 0)
        {
            GetFirstPart();
            IsTargetOver = true;
        }
        void GetFirstPart()
        {
            //First hole come on the vector3(0,0,0) and cross the bridge by doTween.
            if (!IsTargetOver)
            {
                EffectController.instance.FinishEffect();
                //Singleton
                //When we obtain whole white object, show next level panel
                GameManager.Instance.gamestate = GameManager.GameState.Next;
            }
        }
    }
}
