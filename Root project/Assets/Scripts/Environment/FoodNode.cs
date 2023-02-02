using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodNode : Node
{
    public override void OnClick()
    {
        base.OnClick();
    }

    public override void PlayerCollision()
    {
        base.PlayerCollision();
        Player.instance.haveFoods++;
    }
}
