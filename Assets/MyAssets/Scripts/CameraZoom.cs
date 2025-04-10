using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] Cinemachine.CinemachineVirtualCamera VirtualCamera;
    [SerializeField] private float ZoomDuration = 2f;
    private bool hasZoomed = false;

    public void ZoomCamera()
    {
        if (hasZoomed) return;

        VirtualCamera.Priority = 100;
        StartCoroutine(ResetZoom());
        hasZoomed = true;
    }

    private System.Collections.IEnumerator ResetZoom()
    {
        yield return new WaitForSeconds(ZoomDuration);

        VirtualCamera.Priority = 0;
        this.enabled = false;
    }
}
