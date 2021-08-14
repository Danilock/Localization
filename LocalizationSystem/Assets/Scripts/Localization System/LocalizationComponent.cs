using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace LocalizationSystem
{
    public class LocalizationComponent : MonoBehaviour
    {
        [SerializeField] private Text _UIText;
        [SerializeField] private LocalizationText _locText;

        private void OnEnable()
        {
            LocalizationManager.OnChangeLanguage += SetTextLanguage;
        }

        private void OnDisable()
        {
            LocalizationManager.OnChangeLanguage -= SetTextLanguage;
        }

        /// <summary>
        /// Sets the language of the text specified in the parameter.
        /// </summary>
        /// <param name="currentLanguage"></param>
        public void SetTextLanguage(Languages currentLanguage)
        {
            if (_locText == null || _UIText == null)
                return;

            _UIText.text = _locText.Translations.Find(t => t.Language == currentLanguage).Text;
        }
    }
}