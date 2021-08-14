using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LocalizationSystem
{
    [System.Serializable]
    public class Translation
    {
        public Languages Language;
        [TextArea] public string Text;
    }
}