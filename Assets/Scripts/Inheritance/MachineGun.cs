using UnityEngine;

public class MachineGun : Gun
{
    float startSpread;
    float maxSpread;
    float cooldownTime = 2f; // Time to cool down (adjust as needed)
    float overheatingTimer = 0;
    bool isOverheating = false;

    private void OnEnable()
    {
        startSpread = spread;
        maxSpread = 10f;
    }

    public override void Shoot(Vector2 mousePosition)
    {
        if (isOverheating)
        {
            Debug.Log("Overheating!");
            return; // Do not shoot while overheating
        }

        base.Shoot(mousePosition);

        spread += 0.005f; //Add a tiny value since this happens every frame

        if (spread >= maxSpread)
        {
            // The gun is overheating, start cooldown
            isOverheating = true;
            overheatingTimer = cooldownTime;
        }
    }

    private void Update()
    {
        if (isOverheating)
        {
            overheatingTimer -= Time.deltaTime;

            if (overheatingTimer <= 0)
            {
                // Gun is no longer overheating, reset spread
                isOverheating = false;
                spread = startSpread;
            }
        }
    }
}
