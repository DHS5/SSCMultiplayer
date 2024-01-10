using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    #region Global Members

    [Header("Control Point")]
    [SerializeField] private SphereCollider m_sphereCollider;
    [SerializeField][Range(1f, 25f)] private float m_zoneRadius;

    #endregion

    #region Editor

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (m_sphereCollider == null) m_sphereCollider = GetComponent<SphereCollider>();

        if (m_sphereCollider != null)
        {
            m_sphereCollider.isTrigger = true;
            m_sphereCollider.radius = m_zoneRadius;
        }
    }
#endif

    #endregion

    #region Trigger

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out CharacterCollider charaCollider))
        {
            OnCharaEnter(charaCollider.Chara);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out CharacterCollider charaCollider))
        {
            OnCharaExit(charaCollider.Chara);
        }
    }

    #endregion

    #region Character Management

    private Dictionary<Team, List<Character>> m_currentCharactersDico = new();

    private void OnCharaEnter(Character character)
    {

    }
    private void OnCharaExit(Character character)
    {

    }

    #endregion
}
