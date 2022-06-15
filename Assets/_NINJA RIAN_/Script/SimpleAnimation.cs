using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SimpleAnimation : MonoBehaviour
{
    
    public Transform coinTransform;
    public float animTime = 1;

    void Start()
    {
        transform.DOMoveY(transform.position.y+0.09f,animTime).SetLoops(-1,LoopType.Yoyo);
    }


}
