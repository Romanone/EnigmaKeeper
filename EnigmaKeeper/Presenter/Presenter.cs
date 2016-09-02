using System;
using EnigmaKeeper.BL;

namespace EnigmaKeeper
{
    class Presenter
    {
        private readonly IMainForm _mainForm;
        private readonly IModel _model;

        public Presenter(IMainForm mainForm, IModel model)
        {
            this._mainForm = mainForm;
            this._model = model;

            this._mainForm.AddPasswordEvent += _mainForm_AddPasswordEvent;
            this._mainForm.GetPasswordCountEvent += _mainForm_GetPasswordCountEvent;
            this._mainForm.LoadPasswordByIndexEvent += _mainForm_LoadPasswordByIndexEvent;
            this._mainForm.LoadPasswordByNameEvent += _mainForm_LoadPasswordByNameEvent;
            this._mainForm.SetGodPasswordEvent += _mainForm_SetGodPasswordEvent;
            this._mainForm.EncryptAllEvent += _mainForm_EncryptAllEvent;
            this._mainForm.DecryptAllEvent += _mainForm_DecryptAllEvent;
            this._mainForm.WritePasswordsToFileEvent += _mainForm_WritePasswordsToFileEvent;
            this._mainForm.ReadPasswordsFromFileEvent += _mainForm_ReadPasswordsFromFileEvent;
        }

        private void _mainForm_ReadPasswordsFromFileEvent(object sender, EventArgs e)
        {
            _model.ReadFromFile(_mainForm.Path);
        }

        private void _mainForm_WritePasswordsToFileEvent(object sender, EventArgs e)
        {
            _model.WriteToFile(_mainForm.Path);
        }

        private void _mainForm_DecryptAllEvent(object sender, EventArgs e)
        {
            _model.DecryptAll();
        }

        private void _mainForm_EncryptAllEvent(object sender, EventArgs e)
        {
            _model.EncryptAll();
        }

        private void _mainForm_SetGodPasswordEvent(object sender, EventArgs e)
        {
            _model.SetGodPassword(_mainForm.GodPassword, "");
        }

        private void _mainForm_LoadPasswordByNameEvent(string name)
        {
            _mainForm.Name = _model.GetPassword(name).Name;
            _mainForm.Login = _model.GetPassword(name).Login;
            _mainForm.Password = _model.GetPassword(name).Password;
        }

        private void _mainForm_LoadPasswordByIndexEvent(int index)
        {
            _mainForm.Name = _model.GetPassword(index).Name;
            _mainForm.Login = _model.GetPassword(index).Login;
            _mainForm.Password = _model.GetPassword(index).Password;
        }

        private void _mainForm_GetPasswordCountEvent(object sender, EventArgs e)
        {
            _mainForm.PasswordCount = _model.GetPasswordCount();
        }

        private void _mainForm_AddPasswordEvent(object sender, EventArgs e)
        {
            _model.AddPassword(_mainForm.Name, _mainForm.Login, _mainForm.Password);
        }
    }
}
