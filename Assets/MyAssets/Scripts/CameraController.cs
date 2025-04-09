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
        MainCamera.transform.DOShakePosition(1.0f, 2f, 10, 90f);
        Debug.Log("Shake");
    }
}

