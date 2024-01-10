using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum LootType
{
    NONE = 0,

}

public abstract class BaseLoot : MonoBehaviour
{
    #region Global Members

    [Header("Base Loot")]
    [SerializeField] private SphereCollider m_sphereCollider;

    #endregion

    #region Public Accessors

    public abstract LootType Type { get; }

    #endregion

    #region Editor

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (m_sphereCollider == null) m_sphereCollider = GetComponent<SphereCollider>();

        if (m_sphereCollider != null) m_sphereCollider.isTrigger = true;
    }
#endif

    #endregion

    #region Trigger

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerCollider playerCollider))
        {
            TryGrabbedByPlayer(playerCollider.Player);
        }
    }

    #endregion

    #region Behaviour

    private void TryGrabbedByPlayer(Player player)
    {
        if (player.CanGrabLoot(this))
        {
            player.GrabLoot(this);
            OnGrabbedByPlayer(player);
        }
    }

    protected virtual void OnGrabbedByPlayer(Player player)
    {
        // Disable Collider
        m_sphereCollider.enabled = false;

        // Destroy
        Destroy(gameObject);
    }

    #endregion
}
