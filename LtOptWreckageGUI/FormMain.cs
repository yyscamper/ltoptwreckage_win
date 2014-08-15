using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LtOptWreckageGUI
{
    public partial class FormMain : Form
    {
        private int mLastTarget;
        private int mLastAllowedError;
        private Wreckage[] mLastSelectedWreckages;
        private List<WreckageResult> mLastResult;

        public FormMain()
        {
            InitializeComponent();
            String[] wreckageValues = new String[] { "115200", "47728", "28800", "11936", "9648", "9600", "8440", "7232", "6024", "5996", "5328", "4816", "4800", "4660", "3992", "3324", "2756", "2656", "2448", "2140", "1832", "1524", "1216", "400" };
            comboxWreckagesList.Items.AddRange(wreckageValues);

            comboxTargetValue.Items.AddRange(new String[] { "21360", "37800", "59160", "81560", "93160", "105510", "118610", "132460", "147060", "287760", "346920"});

            nudAllowedError.Minimum = 0;
            nudAllowedError.Maximum = 2000;
            nudAllowedError.Increment = 100;
            nudAllowedError.Value = 200;

            listViewResult.FullRowSelect = true;

            comboxTargetValue.Text = "59160";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AddWreckageRow(4660);
            AddWreckageRow(5328);
            AddWreckageRow(5996);
            AddWreckageRow(6024);
            AddWreckageRow(8440);
            AddWreckageRow(9648);
        }

        private void AddWreckageRow(int value)
        {
            DataGridViewComboBoxCell cellMaxNum = new DataGridViewComboBoxCell();
            for (int i = 0; i <= 32; i++)
            {
                cellMaxNum.Items.Add(i.ToString());
            }
            if (value == 400 || value == 9600 || value == 4800)
            {
                cellMaxNum.Value = "1";
            }
            else if (value == 8440 || value == 9648 || value == 6024)
            {
                cellMaxNum.Value = "6";
            }
            else
            {
                cellMaxNum.Value = "10";
            }
            cellMaxNum.MaxDropDownItems = cellMaxNum.Items.Count;

            DataGridViewTextBoxCell cellIndex = new DataGridViewTextBoxCell();
            cellIndex.Value = dgvWreckagesTable.RowCount + 1;

            DataGridViewTextBoxCell cellValue = new DataGridViewTextBoxCell();
            cellValue.Value = value;

            DataGridViewButtonCell cellDelete = new DataGridViewButtonCell();
            cellDelete.Value = "删除";

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Clear();
            row.Cells.AddRange(new DataGridViewCell[] { cellIndex, cellValue, cellMaxNum, cellDelete});

            dgvWreckagesTable.Rows.Add(row);
        }

        private static int CompareWreckage(Wreckage w1, Wreckage w2)
        {
            if (w1.Value < w2.Value)
                return 1;
            else if (w1.Value > w2.Value)
                return -1;
            else
                return 0;
        }

        private Wreckage[] GetSelectedWreckages()
        {
            List<Wreckage> selList = new List<Wreckage>();
            for (int i = 0; i < dgvWreckagesTable.Rows.Count; i++)
            {
                DataGridViewRow row = dgvWreckagesTable.Rows[i];
                int maxNum = int.Parse(row.Cells[2].Value.ToString());
                if (maxNum > 0)
                {
                    Wreckage wreckage = new Wreckage((int)row.Cells[1].Value, maxNum);
                    selList.Add(wreckage);
                }
            }
            selList.Sort(CompareWreckage);

            Wreckage[] arr = new Wreckage[selList.Count];
            selList.CopyTo(arr);
            return arr;
        }

        private void dgvWreckagesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateResultView()
        {
            if (mLastResult == null)
                return;

            listViewResult.Items.Clear();

            if (mLastResult.Count == 0)
            {
                MessageBox.Show("未能找到合适的残骸组合，你可以将\"允许的最大多余经验\"调大后再重新计算。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (radioBtnOrderDelta.Checked)
            {
                WreckageCalculator.Sort(mLastResult, ResultOrder.Delta);
            }
            else if (readioBtnBodyPoint.Checked)
            {
                WreckageCalculator.Sort(mLastResult, ResultOrder.BodyPoint);
            }
            else
            {
                WreckageCalculator.Sort(mLastResult, ResultOrder.TotalNum);
            }

            foreach (WreckageResult result in mLastResult)
            {
                AddResultRow(result, mLastSelectedWreckages, mLastTarget);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int allowedError = (int)nudAllowedError.Value;
            int target = 0;
            try
            {
                target = int.Parse(comboxTargetValue.Text.Trim());
            }
            catch
            {
                MessageBox.Show("输入的目标经验值必须是大于零的整数！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Wreckage[] wreckages = GetSelectedWreckages();
            if (wreckages.Length == 0)
            {
                MessageBox.Show("你必须选择至少一种残骸!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<WreckageResult> results = WreckageCalculator.DoCalc(wreckages, target, allowedError);

            mLastResult = results;
            mLastSelectedWreckages = wreckages;
            mLastTarget = target;
            mLastAllowedError = allowedError;

            UpdateResultView();
        }

        private void AddResultRow(WreckageResult result, Wreckage[] wreckages, int target)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems[0].Text = (listViewResult.Items.Count + 1).ToString();
            lvi.SubItems.Add((result.Value - target).ToString());
            lvi.SubItems.Add(result.GetTotalNumOfWreckage().ToString());
            lvi.SubItems.Add(result.EstimateBodyPoint.ToString());
            lvi.SubItems.Add(WreckageCalculator.GetResultString(result, wreckages, target));
            listViewResult.Items.Add(lvi);
        }

        private void dgvWreckagesTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 2)
                e.Cancel = true;
        }

        private void dgvWreckagesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 3) //delete cell
            {
                for (int i = e.RowIndex + 1; i < dgvWreckagesTable.Rows.Count; i++ )
                {
                    dgvWreckagesTable.Rows[i].Cells[0].Value = i;
                }
                dgvWreckagesTable.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAddWreckage_Click(object sender, EventArgs e)
        {
            String str = comboxWreckagesList.Text;
            int num = 0;
            try
            {
                num = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("输入的残骸经验值不正确，它必须是大于零的整数。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (num <= 0)
            {
                MessageBox.Show("输入的残骸经验值不正确，它必须是大于零的整数。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dgvWreckagesTable.Rows)
            {
                if (str.Equals(row.Cells[1].Value.ToString()))
                {
                    return;
                }
            }

            AddWreckageRow(num);
        }

        private void nudAllowedError_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.PerformClick();
            }
        }

        private void comboxTargetValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)(e.KeyChar) == 8 || (int)(e.KeyChar) == 13);
        }

        private void comboxWreckagesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddWreckage.PerformClick();
        }

        private void SetSize()
        {
            dgvWreckagesTable.Height = this.Height - dgvWreckagesTable.Location.Y - 46;
            listViewResult.Height = this.Height - listViewResult.Location.Y - 46;
            listViewResult.Width = this.Width - listViewResult.Location.X - 24;
            int sumWidth = 0;
            for (int i = 0; i < listViewResult.Columns.Count - 1; i++)
                sumWidth += listViewResult.Columns[i].Width;
            listViewResult.Columns[listViewResult.Columns.Count - 1].Width = listViewResult.Width - sumWidth - 24;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void radioBtnOrderDelta_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResultView();
        }

        private void menuItemSelectResult_Click(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count <= 0)
                return;

            int selIndex = listViewResult.SelectedIndices[0];

            ListViewItem item = listViewResult.SelectedItems[0];
        }
    }
}
