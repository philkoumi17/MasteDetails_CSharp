using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MasterDetailsApp
{
    public partial class FormMain : Form
    {
        int inEmpID = 0;
        bool isDefaultImage = true;
        string connectString = @"Data Source=(local);Initial Catalog=MasterDetailsDB;Persist Security Info=True;User ID=sa;Password=localhost", strPreviousImage = "";
        OpenFileDialog ofd = new OpenFileDialog();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtBoxCode.Text = txtBoxNom.Text = "";
            cmbPosition.SelectedIndex = cmbGenre.SelectedIndex = 0;
            dateTimeDDN.Value = DateTime.Now;
            rbtnRegular.Checked = true;

            if(dgvEmployéSociété.DataSource == null)
            {
                dgvEmployéSociété.Rows.Clear();
            }
            else
            {
                dgvEmployéSociété.DataSource = (dgvEmployéSociété.DataSource as DataTable).Clone();
            }

            inEmpID = 0;
            btnEnregister.Text = "Enregistrer";
            btnSupprimer.Enabled = false;
            pbxPhoto.Image = Image.FromFile(Application.StartupPath + "\\Images\\defaultImage.png");
            isDefaultImage = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PositionComboBoxFill();
            FillEmployéDataGridView();
            Clear();
        }

        void PositionComboBoxFill()
        {
            using(SqlConnection oConnect = new SqlConnection(connectString))
            {
                oConnect.Open();
                SqlDataAdapter oData = new SqlDataAdapter("SELECT * FROM Position", oConnect);
                DataTable oTable = new DataTable();
                oData.Fill(oTable);
                DataRow topItem = oTable.NewRow();
                topItem[0] = 0;
                topItem[1] = "-SELECT-";
                oTable.Rows.InsertAt(topItem, 0);
                cmbPosition.ValueMember = dgvcmbPosition.ValueMember = "POS_ID";
                cmbPosition.DisplayMember = dgvcmbPosition.DisplayMember = "POS_Position";
                cmbPosition.DataSource = oTable;
                dgvcmbPosition.DataSource = oTable.Copy();
            }
        }

        private void btnImageParcourir_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = new Bitmap(ofd.FileName);
                isDefaultImage = false;
                strPreviousImage = "";
            }
        }

        private void btnImageClear_Click(object sender, EventArgs e)
        {
            pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\defaultImage.png");
            isDefaultImage = true;
            strPreviousImage = "";
        }

        private void btnEnregister_Click(object sender, EventArgs e)
        {
            if(ValiderMasterDetailForm())
            {
                int _EMP_ID = 0;

                // Master
                using(SqlConnection oConnect = new SqlConnection(connectString))
                {
                    oConnect.Open();
                    SqlCommand oCmd = new SqlCommand("AddOrEditEmployé", oConnect);
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("@EMP_ID", inEmpID);
                    oCmd.Parameters.AddWithValue("@EMP_Code", txtBoxCode.Text.Trim());
                    oCmd.Parameters.AddWithValue("@EMP_Nom", txtBoxNom.Text.Trim());
                    oCmd.Parameters.AddWithValue("@EMP_POS_ID", Convert.ToInt32(cmbPosition.SelectedValue));
                    oCmd.Parameters.AddWithValue("@EMP_DOB", dateTimeDDN.Value);
                    oCmd.Parameters.AddWithValue("@EMP_Genre", cmbGenre.Text);
                    oCmd.Parameters.AddWithValue("@EMP_EtatEmployé", rbtnRegular.Checked ? "Regulier" : "Contractuel");

                    if(isDefaultImage)
                    {
                        oCmd.Parameters.AddWithValue("@EMP_ImagePath", DBNull.Value);
                    }
                    else if(inEmpID > 0 && strPreviousImage != "")
                    {
                        oCmd.Parameters.AddWithValue("@EMP_ImagePath", strPreviousImage);
                    }
                    else
                    {
                        oCmd.Parameters.AddWithValue("@EMP_ImagePath", SauverImage(ofd.FileName));
                    }
                    _EMP_ID = Convert.ToInt32(oCmd.ExecuteScalar());
                }

                // Détails
                using(SqlConnection oConnect = new SqlConnection(connectString))
                {
                    oConnect.Open();

                    foreach(DataGridViewRow dgvRow in dgvEmployéSociété.Rows)
                    {
                        if(dgvRow.IsNewRow)
                        {
                            break;
                        }
                        else
                        {
                            SqlCommand oCmd = new SqlCommand("AddOrEditEmployéSociété", oConnect);
                            oCmd.CommandType = CommandType.StoredProcedure;
                            oCmd.Parameters.AddWithValue("@EMPSOC_ID", Convert.ToInt32(dgvRow.Cells["dgvtxtEmpCompID"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtEmpCompID"].Value));
                            oCmd.Parameters.AddWithValue("@EMPSOC_EMP_ID", _EMP_ID);
                            oCmd.Parameters.AddWithValue("@EMPSOC_Nom", dgvRow.Cells["dgvtxtNomSociété"].Value == DBNull.Value ? "" : dgvRow.Cells["dgvtxtNomSociété"].Value);
                            oCmd.Parameters.AddWithValue("@EMPSOC_POS_ID", Convert.ToInt32(dgvRow.Cells["dgvcmbPosition"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbPosition"].Value));
                            oCmd.Parameters.AddWithValue("@EMPSOC_AnneeExp", Convert.ToInt32(dgvRow.Cells["dgvtxtAnnée"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtAnnée"].Value));
                            oCmd.ExecuteNonQuery();
                        }
                    }
                }
                FillEmployéDataGridView();
                Clear();
                MessageBox.Show("Enregitré avec succès");
            }
        }

        bool ValiderMasterDetailForm()
        {
            bool _estValide = true;
            if(txtBoxNom.Text.Trim() == "")
            {
                MessageBox.Show("Le nom de l'employé est obligatoire");
                _estValide = false;
            }

            // Ajouter plus de validations si nécessaire
            return _estValide;
        }

        string SauverImage(string _imagePath)
        {
            string _nomFichier = Path.GetFileNameWithoutExtension(_imagePath);
            string _extension = Path.GetExtension(_imagePath);

            // Nom de fichiers court
            _nomFichier = _nomFichier.Length <= 15 ? _nomFichier : _nomFichier.Substring(0, 15);
            _nomFichier = _nomFichier + DateTime.Now.ToString("yymmssff") + _extension;
            pbxPhoto.Image.Save(Application.StartupPath + "\\Images\\" + _nomFichier);
            return _nomFichier;
        }

        void FillEmployéDataGridView()
        {
            using(SqlConnection oConnect = new SqlConnection(connectString))
            {
                oConnect.Open();
                SqlDataAdapter oData = new SqlDataAdapter("SelectEmployéViewAll", oConnect);
                oData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable oTable = new DataTable();
                oData.Fill(oTable);
                dgvEmployés.DataSource = oTable;
                dgvEmployés.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEmployés.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvEmployés.Columns[0].Visible = false;
            }
        }

        private void dgvEmployés_DoubleClick(object sender, EventArgs e)
        {
            if(dgvEmployés.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dgvEmployés.CurrentRow;
                inEmpID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);
                using(SqlConnection oConnect = new SqlConnection(connectString))
                {
                    oConnect.Open();
                    SqlDataAdapter oData = new SqlDataAdapter("EmployéViewByID", oConnect);
                    oData.SelectCommand.CommandType = CommandType.StoredProcedure;
                    oData.SelectCommand.Parameters.AddWithValue("@EMP_ID", inEmpID);
                    DataSet oDataSet = new DataSet();
                    oData.Fill(oDataSet);

                    // Master - Fill
                    DataRow oDataLigne = oDataSet.Tables[0].Rows[0];
                    txtBoxCode.Text = oDataLigne["EMP_Code"].ToString();
                    txtBoxNom.Text = oDataLigne["EMP_Nom"].ToString();
                    cmbPosition.SelectedValue = Convert.ToInt32(oDataLigne["EMP_POS_ID"].ToString());
                    dateTimeDDN.Value = Convert.ToDateTime(oDataLigne["EMP_DOB"].ToString());
                    cmbGenre.Text = oDataLigne["EMP_Genre"].ToString();
                    
                    if(oDataLigne["EMP_EtatEmployé"].ToString() == "Régulier")
                    {
                        rbtnRegular.Checked = true;
                    }
                    else
                    {
                        rbtnContractual.Checked = true;
                    }

                    if(oDataLigne["EMP_ImagePath"] == DBNull.Value)
                    {
                        pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\defaultImage.png");
                        isDefaultImage = true;
                    }
                    else
                    {
                        pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\" + oDataLigne["EMP_ImagePath"].ToString());
                        strPreviousImage = oDataLigne["EMP_ImagePath"].ToString();
                        isDefaultImage = false;
                    }

                    dgvEmployéSociété.AutoGenerateColumns = false;
                    dgvEmployéSociété.DataSource = oDataSet.Tables[1];
                    btnSupprimer.Enabled = true;
                    btnEnregister.Text = "Mettre à jour";
                    tabCtrlDataEmployés.SelectedIndex = 0;
                }
            }
        }

        private void dgvEmployéSociété_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvEmployéSociété.CurrentRow;

            if(dgvRow.Cells["dgvtxtEmpCompID"].Value != DBNull.Value)
            {
                if(MessageBox.Show("Etes-vous sûr de supprimer cet enregistrement ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using(SqlConnection oConnect = new SqlConnection(connectString))
                    {
                        oConnect.Open();
                        SqlCommand oCmd = new SqlCommand("EmployéSociétéDelete", oConnect);
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.AddWithValue("@EMPSOC_ID", Convert.ToInt32(dgvRow.Cells["dgvtxtEmpCompID"].Value));
                        oCmd.ExecuteNonQuery();
                    };
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes-vous sûr de supprimer cet enregistrement ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(SqlConnection oConnect = new SqlConnection(connectString))
                {
                    oConnect.Open();
                    SqlCommand oCmd = new SqlCommand("EmployéDelete", oConnect);
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("@EMP_ID", inEmpID);
                    oCmd.ExecuteNonQuery();
                    Clear();
                    FillEmployéDataGridView();
                    MessageBox.Show("Elément supprimé avec succès");
                };
            }
        }
    }
}