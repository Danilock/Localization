using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LocalizationSystem
{
    [CreateAssetMenu(fileName = "Text", menuName = "Localization/Create Text")]
    public class LocalizationText : ScriptableObject
    {
        [Header("Set in which languages this text will be allowed to be used")]
        public List<Translation> Translations;
    }
}