using System;
using System.Collections;
using UnityEngine;


public abstract class BaddieBaseState
{
    public abstract void EnterState(BaddieStateManager baddie);

    public abstract void UpdateState(BaddieStateManager baddie);

    public abstract IEnumerator ImpatientTimer(BaddieStateManager baddie);


}
