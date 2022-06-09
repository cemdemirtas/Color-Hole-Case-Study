using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DoTweenManager : MonoBehaviour
{
    public static DoTweenManager instance;
    [SerializeField] Transform getFirstPart, getSecondPart;
    [SerializeField] PathMode pathMode;
    [SerializeField] PathType pathType;
    [SerializeField] Vector3[] path;
    bool IsTargetOver;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        if (getFirstPart.childCount <= 0)
        {
            GetFirstPart();
            IsTargetOver = true;
        }
        void GetFirstPart()
        {
            //First hole come on the vector3(0,0,0) and cross the bridge by doTween.
            if (!IsTargetOver)
            {
                transform.DOMove(Vector3.zero, 3f).OnComplete(()=>
                transform.DOPath(path, 5f, pathType, pathMode));
            }
        }  
    }
}
