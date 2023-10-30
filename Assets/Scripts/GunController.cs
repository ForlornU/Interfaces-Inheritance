using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] Gun pistol, machineGun, shotgun;
    private Gun currentGun;
    LineRenderer lineRenderer;

    private void Start()
    {
        currentGun = pistol;
        lineRenderer = GetComponent<LineRenderer>();
    }

    void LateUpdate()
    {
        RotateGun();
        SelectGun();
        TryToFire();
    }

    void RotateGun()
    {
        lineRenderer.SetPosition(0, currentGun.transform.position);
        lineRenderer.SetPosition(1, Camera.main.ScreenToWorldPoint(Input.mousePosition));
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
        if (!Input.GetMouseButton(0))
            return;

        currentGun.Shoot(DirectionToMousePos());
    }

    Vector2 DirectionToMousePos()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return mousePosition - new Vector2(currentGun.transform.position.x, currentGun.transform.position.y);
    }
}
