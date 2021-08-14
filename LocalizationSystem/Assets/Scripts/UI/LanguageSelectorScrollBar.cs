using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LocalizationSystem;

namespace UI
{
    public class LanguageSelectorScrollBar : MonoBehaviour
    {
        public void ChangeLanguage(int index)
        {
            switch (index)
            {
                case 0:
                    LocalizationManager.Instance.SetLanguage(Languages.English);
                    break;

                case 1:
                    LocalizationManager.Instance.SetLanguage(Languages.Spanish);
                    break;
            }
        }
    }
}