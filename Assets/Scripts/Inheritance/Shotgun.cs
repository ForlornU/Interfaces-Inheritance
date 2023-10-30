
using UnityEngine;

public class Shotgun : Gun
{
    public override void Shoot(Vector2 mousePosition)
    {
        base.Shoot(mousePosition);
        //Introduce unique quirk here
        //Pushes the player back
    }

}
