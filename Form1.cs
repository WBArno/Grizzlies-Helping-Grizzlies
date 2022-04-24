using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grizzlies_Helping_Grizzlies
{
    public partial class GHGForm : Form
    {
        public GHGForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GHGForm
            // 
            this.ClientSize = new System.Drawing.Size(989, 646);
            this.Font = new System.Drawing.Font("Yu Mincho", 11F);
            this.Name = "GHGForm";
            this.Text = "Grizzlies Helping Grizzlies";
            this.ResumeLayout(false);

        }
    }
}
