using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    [SerializeField]
    public GameObject MainCamera;

    public void ShakeCamera()
    {
        MainCamera.transform.DOShakePosition(1.3f, 2f, 12, 90f);
    }
}

