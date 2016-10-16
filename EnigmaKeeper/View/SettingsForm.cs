using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaKeeper.Encryptor;
using EnigmaKeeper.BL;

namespace EnigmaKeeper.View
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public object StorageControler { get; set; }
        public object EncryptorController { get; set; }

        

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SetComboBoxes(Dictionary<string, object> storageControlerList,
                                   Dictionary<string, object> encryptorControlerList)
        {
            foreach (var item in storageControlerList)
            {
                cbStorageMethods.Items.Add(item.Key);
            }

            foreach (var item in encryptorControlerList)
            {
                cbEncryptMethods.Items.Add(item.Key);
            }

        }


        



    }
}
