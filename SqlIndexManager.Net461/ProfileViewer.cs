using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SqlIndexManager.Net461.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlIndexManager.Net461
{
    public partial class ProfileViewer : Form
    {
        private List<IndexProfileDto> _listIndexProfile;

        public ProfileViewer(List<IndexProfileDto> listIndexProfile)
        {
            InitializeComponent();
            _listIndexProfile = listIndexProfile;
            IndexProfileGrid.DataSource = _listIndexProfile;
        }

        private void IndexProfileGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
                gridView.RowHeadersWidth = 70;
            }
            IndexProfileGrid.Columns[0].Width = 200;
            IndexProfileGrid.Columns[1].Width = 225;
            IndexProfileGrid.Columns[7].Width = 225;
            IndexProfileGrid.Columns[8].Width = 225;

        }
    }
}
