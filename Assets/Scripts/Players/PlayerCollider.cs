using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    #region Global Members

    [Header("PlayerCollider")]
    [SerializeField] private Player m_player;

    #endregion

    #region Public Accessors

    public Player Player => m_player;

    #endregion
}
