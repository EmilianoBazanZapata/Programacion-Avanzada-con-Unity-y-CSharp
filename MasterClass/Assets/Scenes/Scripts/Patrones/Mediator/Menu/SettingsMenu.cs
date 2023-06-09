using UnityEngine;
using UnityEngine.UI;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Mediator
{
    public class SettingsMenu : Menu
    {
        public Button backBtn;

        public override void Show() { }
        public override void Hide() { }

        private void Start()
        {
            backBtn.onClick.AddListener(() => mediator.GoToMainMenu());
        }
    }
}