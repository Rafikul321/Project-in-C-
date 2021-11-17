using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEngSiteBuild
{
    public partial class Form1 : Form
    {
        private AuditFormData auditFormData;
        public Form1()
        {
            InitializeComponent();
            auditFormData = new AuditFormData();
        }


        private void toolStripMenuItem113_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            (new DataB()).ShowDialog();
        }

        private void TbWorkAtHeightIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.WorkAtHeightIntervention = tbWorkAtHeightIntervention.Text;
        }

        private void TbWorkAtHeightComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.WorkAtHeightComment = tbWorkAtHeightComment.Text;
        }

        private void TbWorkatHeightCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.WorkatHeightCompleted = tbWorkatHeightCompleted.Text;
        }

        private void TbWorkatHeightAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.WorkatHeightAction = tbWorkatHeightAction.Text;
        }

        private void tbliftingOperationsIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.LiftingOperationsIntervention = tbliftingOperationsIntervention.Text;
        }

        private void tbliftingOperationsComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.LiftingOperationsComment = tbliftingOperationsComment.Text;
        }

        private void tbliftingOperationsCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.LiftingOperationsCompleted = tbliftingOperationsCompleted.Text;
        }

        private void tbliftingOperationsAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.LiftingOperationsAction = tbliftingOperationsAction.Text;
        }

        private void tbCertificationIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.CertificationIntervention = tbCertificationIntervention.Text;
        }

        private void tbCertificationComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.CertificationComment = tbCertificationComment.Text;
        }

        private void tbCertificationCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.CertificationCompleted = tbCertificationCompleted.Text;
        }

        private void tbCertificationAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.CertificationAction = tbCertificationAction.Text;
        }

        private void tbConfinedSpaceWorkIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.ConfinedSpaceWorkIntervention = tbConfinedSpaceWorkIntervention.Text;
        }

        private void tbConfinedSpaceWorkComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.ConfinedSpaceWorkComment = tbConfinedSpaceWorkComment.Text;
        }

        private void tbConfinedSpaceWorkCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.ConfinedSpaceWorkCompleted = tbConfinedSpaceWorkCompleted.Text;
        }

        private void tbConfinedSpaceWorkAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.ConfinedSpaceWorkAction = tbConfinedSpaceWorkAction.Text;
        }

        private void tbElectricalWorkIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.ElectricalWorkIntervention = tbElectricalWorkIntervention.Text;
        }

        private void tbElectricalWorkComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.ElectricalWorkComment = tbElectricalWorkComment.Text;
        }

        private void tbElectricalWorkCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.ElectricalWorkCompleted = tbElectricalWorkCompleted.Text;
        }

        private void tbElectricalWorkAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.ElectricalWorkAction = tbElectricalWorkAction.Text;
        }

        private void tbSiteSetupIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.SiteSetupIntervention = tbSiteSetupIntervention.Text;
        }

        private void tbSiteSetupComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.SiteSetupComment = tbSiteSetupComment.Text;
        }

        private void tbSiteSetupCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.SiteSetupCompleted = tbSiteSetupCompleted.Text;
        }

        private void tbSiteSetupAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.SiteSetupAction = tbSiteSetupAction.Text;
        }

        private void tbPaperworkIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.PaperworkIntervention = tbPaperworkIntervention.Text;
        }

        private void tbPaperworkComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.PaperworkComment = tbPaperworkComment.Text;
        }

        private void tbPaperworkCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.PaperworkCompleted = tbPaperworkCompleted.Text;
        }

        private void tbPaperworkAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.PaperworkAction = tbPaperworkAction.Text;
        }

        private void ToolStripTextBox13_TextChanged(object sender, EventArgs e)
        {
            auditFormData.CertificationTrainingIntervention = tbCertificationTrainingIntervention.Text;
        }

        private void tbCertificationTrainingComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.CertificationTrainingComment = tbCertificationTrainingComment.Text;
        }

        private void tbCertificationTrainingCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.CertificationTrainingCompleted = tbCertificationTrainingCompleted.Text;
        }

        private void tbCertificationTrainingAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.CertificationTrainingAction = tbCertificationTrainingAction.Text;
        }

        private void tbHotWorkIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.HotWorkIntervention = tbHotWorkIntervention.Text;
        }

        private void tbHotWorkComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.HotWorkComment = tbHotWorkComment.Text;
        }

        private void tbHotWorkCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.HotWorkCompleted = tbHotWorkCompleted.Text;
        }

        private void tbHotWorkAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.HotWorkAction = tbHotWorkAction.Text;
        }

        private void tbIsolationIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.IsolationIntervention = tbIsolationIntervention.Text;
        }

        private void tbIsolationComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.IsolationComment = tbIsolationComment.Text;
        }

        private void tbIsolationCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.IsolationCompleted = tbIsolationCompleted.Text;
        }

        private void tbIsolationAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.IsolationAction = tbIsolationAction.Text;
        }

        private void tbFireExitIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.FireExitIntervention = tbFireExitIntervention.Text;
        }

        private void tbFireExitComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.FireExitComment = tbFireExitComment.Text;
        }

        private void tbFireExitCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.FireExitCompleted = tbFireExitCompleted.Text;
        }

        private void tbFireExitAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.FireExitAction = tbFireExitAction.Text;
        }

        private void tbAwarenessIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.AwarenessIntervention = tbAwarenessIntervention.Text;
        }

        private void tbAwarenessComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.AwarenessComment = tbAwarenessComment.Text;
        }

        private void tbAwarenessCompleted_TextChanged(object sender, EventArgs e)
        {
            auditFormData.AwarenessCompleted = tbAwarenessCompleted.Text;
        }

        private void tbAwarenessAction_TextChanged(object sender, EventArgs e)
        {
            auditFormData.AwarenessAction = tbAwarenessAction.Text;
        }
    }
}
