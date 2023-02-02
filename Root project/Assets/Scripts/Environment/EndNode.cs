using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndNode : Node
{
    public override void OnClick()
    {
        base.OnClick();
    }

    public override void PlayerCollision()
    {
        base.PlayerCollision();
        print("Win");
    }
}
