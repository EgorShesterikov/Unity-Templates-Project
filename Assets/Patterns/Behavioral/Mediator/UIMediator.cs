using System;
using UnityEngine;

namespace Mediator
{
    public class UIMediator : IDisposable
    {
        private MainMenu _mainMenu;
        private PlayMenu _playMenu;

        public UIMediator(MainMenu mainMenu, PlayMenu playMenu)
        {
            _mainMenu = mainMenu;
            _mainMenu.ClickedPlayButton += EnterPlayMenu;

            _playMenu = playMenu;
            _playMenu.ClickedMenuButton += EnterMainMenu;
        }

        public void Dispose()
        {
            _mainMenu.ClickedPlayButton -= EnterPlayMenu;

            _playMenu.ClickedMenuButton -= EnterMainMenu;
        }

        private void EnterMainMenu()
        {
            Debug.Log("Enter Main Menu");

            _mainMenu.Open();
            _playMenu.Close();
        }

        private void EnterPlayMenu()
        {
            Debug.Log("Enter Play Menu");

            _mainMenu.Close();
            _playMenu.Open();
        }
    }
}