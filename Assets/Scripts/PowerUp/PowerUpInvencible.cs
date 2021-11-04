using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInvencible : PowerUpBase
{
    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.SetInvencilbe();
    }

    protected override void EndPowerUp()
    {
        base.EndPowerUp();
        PlayerController.Instance.SetInvencilbe(false);
    }
}
