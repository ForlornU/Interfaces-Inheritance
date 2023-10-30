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
            currentGun = pistol;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            currentGun = machineGun;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            currentGun = shotgun;
    }

    void TryToFire()
    {
        if (!Input.GetMouseButtonDown(0))
            return;

        currentGun.Shoot();
    }
}
