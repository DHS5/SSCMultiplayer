using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    #region Loot

    public virtual bool CanGrabLoot(BaseLoot loot)
    {
        switch (loot.Type)
        {
            case LootType.NONE:
                return false;
        }
        return false;
    }

    public virtual void GrabLoot(BaseLoot loot)
    {
        if (loot == null) return;

        switch (loot.Type)
        {
            case LootType.NONE:
                break;
        }
    }

    #endregion
}
