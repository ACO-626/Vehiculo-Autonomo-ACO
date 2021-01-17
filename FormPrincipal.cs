using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehículo_Autónomo_ACO
{
    public partial class FormPrincipal : Form
    {
        #region Variables globales
        
        #endregion

        #region Inicialización de componentes
        public FormPrincipal()
        {
            InitializeComponent();
        }


        #endregion
        
        #region Importar
        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void ImportarVideo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {

            }                                   
        }




    }
}
