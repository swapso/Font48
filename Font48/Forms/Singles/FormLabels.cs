using Font48.Classes;
using Font48.Models.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font48.Forms
{
  public partial class FormLabels : FormBaseLog
  {

    public FormLabels() : base()
    {
      InitializeComponent();
    }
    public FormLabels(ClassBL.AppTypeEnum appType) : base(appType)
    {
      InitializeComponent();

    }

    private void FormLabels_Load(object sender, EventArgs e)
    {

    }

    private void FormLabels_Shown(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }
  }
}
