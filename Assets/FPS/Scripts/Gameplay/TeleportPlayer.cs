using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    // Debug script, teleports the player across the map for faster testing
    public class TeleportPlayer : MonoBehaviour
    {
        public KeyCode ActivateKey = KeyCode.F12;

        PlayerCharacterController m_PlayerCharacterController;

        void Awake()
        {
            m_PlayerCharacterController = FindObjectOfType<PlayerCharacterController>();
            DebugUtility.HandleErrorIfNullFindObject<PlayerCharacterController, TeleportPlayer>(
                m_PlayerCharacterController, this);
        }

        void Update()
        {
            if (Input.GetKeyDown(ActivateKey))
            {
                TeleportToPosition(transform.position, transform.rotation);
            }
        }

        public void TeleportToPosition(Vector3 position, Quaternion rotation)
        {
            m_PlayerCharacterController.transform.SetPositionAndRotation(position, rotation);
            m_PlayerCharacterController.GetComponent<Rigidbody>().velocity = Vector3.zero; // 重置速度
            m_PlayerCharacterController.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; // 重置角速度

            Health playerHealth = m_PlayerCharacterController.GetComponent<Health>();
            if (playerHealth)
            {
                playerHealth.Heal(999);
            }
        }
    }
}