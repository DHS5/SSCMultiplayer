using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    #region Global Members

    [Header("Grenade")]
    [SerializeField] private float m_explosionRange = 10f;
    [SerializeField] private float m_damages = 10f;
    [SerializeField] private LayerMask m_mask;

    #endregion

    private bool m_isThrow;

    private void OnCollisionEnter(Collision collision)
    {
        if (m_isThrow)
        {
            Explode();
        }
    }

    public void Throw()
    {
        if (m_isThrow) return; 
        m_isThrow = true;
    }

    private void Explode()
    {
        Explosion.Trigger(transform.position, m_explosionRange, m_mask, m_damages);
    }
}
