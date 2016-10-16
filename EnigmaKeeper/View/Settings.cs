using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaKeeper.BL;
using EnigmaKeeper.Encryptor;


namespace EnigmaKeeper.View
{
    class Settings
    {
        public Settings()
        {
            CurrentStorageController = new FILE_StorageController();
            CurrentEncryptorController = new XOR_EncryptorController();
        }


        private Dictionary<string, object> storageControlerList = new Dictionary<string, object>();
        private Dictionary<string, object> encryptorControlerList = new Dictionary<string, object>();


        public void AddMethods()
        {
            storageControlerList.Add("Save to File", new FILE_StorageController());
            encryptorControlerList.Add("XOR Encryptor", new XOR_EncryptorController());
        }

        public object CurrentStorageController { get; set; }
        public object CurrentEncryptorController { get; set; }



    }
}
