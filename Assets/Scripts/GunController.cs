using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    [SerializeField] Gun pistol, machineGun, shotgun;

    private Gun currentGun;

    private void Start()
    {
        currentGun = pistol;
    }

    void LateUpdate()
    {
        SelectGun();
        TryToFire();
    }

    void SelectGun()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Debug.Log("clicked 1");
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            Debug.Log("Clicled 2");
        else if (!Input.GetKeyDown(KeyCode.Alpha3))
            Debug.Log("");
    }

    void TryToFire()
    {
        if (!Input.GetMouseButton(0))
            return;


    }
}
