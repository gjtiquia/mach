using UnityEngine;

namespace GJ.Mach
{
    public class MachManager : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private bool _initOnAwake = true;

        [Header("References")]
        [SerializeField] private MachSettingsSO _settings;

        // MonoBehaviour INTERFACE
        private void OnValidate()
        {
            // TODO : use MachUtils.WarnIfNull 
            if (_settings == null)
                LogError("Warning: MachSettingsSO reference is not set.");
        }

        private void Awake()
        {
            if (_initOnAwake)
                Initialize();
        }

        // PUBLIC METHODS
        public void Initialize()
        {
            Log($"Initialize: setting.Link: {_settings.GoogleSheetsPublicLink}");
        }

        // PRIVATE METHODS
        private void Log(string message)
        {
            Debug.Log($"[MachManager] {message}");
        }

        private void LogWarning(string message)
        {
            Debug.LogWarning($"[MachManager] {message}");
        }

        private void LogError(string message)
        {
            Debug.LogError($"[MachManager] {message}");
        }
    }
}
