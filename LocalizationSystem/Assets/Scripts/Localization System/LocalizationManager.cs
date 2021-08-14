using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LocalizationSystem
{
    public class LocalizationManager : Singleton<LocalizationManager>
    {
        public static UnityAction<Languages> OnChangeLanguage;

        [SerializeField] private Languages _currentLanguage = Languages.English;
        public Languages CurrentLanguage
        {
            get => _currentLanguage;
            private set => _currentLanguage = value;
        }

        private void Awake()
        {
            #region Initialize Singleton
            if (_instance != null && _instance != this)
                Destroy(this.gameObject);
            else
            {
                _instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            #endregion
        }

        private void OnEnable()
        {
            SetLanguage(_currentLanguage);
        }

        public void SetLanguage(Languages newLanguage)
        {
            _currentLanguage = newLanguage;

            OnChangeLanguage?.Invoke(_currentLanguage);
        }

        private void OnValidate()
        {
            if (Application.isPlaying)
                SetLanguage(_currentLanguage);
        }
    }
    public enum Languages
    {
        English,
        Spanish
    }
}