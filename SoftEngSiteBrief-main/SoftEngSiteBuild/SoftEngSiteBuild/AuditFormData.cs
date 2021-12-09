using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftEngSiteBuild
{
    public partial class AuditFormData
    {

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        static string workAtHeightIntervention;
        static string workAtHeightComment;
        static string workatHeightCompleted;
        static string workatHeightAction;
        static string liftingOperationsIntervention;
        static string liftingOperationsComment;
        static string liftingOperationsCompleted;
        static string liftingOperationsAction;
        static string certificationIntervention;
        static string certificationComment;
        static string certificationCompleted;
        static string certificationAction;
        static string confinedSpaceWorkIntervention;
        static string confinedSpaceWorkComment;
        static string confinedSpaceWorkCompleted;
        static string confinedSpaceWorkAction;
        static string electricalWorkIntervention;
        static string electricalWorkComment;
        static string electricalWorkCompleted;
        static string electricalWorkAction;
        static string siteSetupIntervention;
        static string siteSetupComment;
        static string siteSetupCompleted;
        static string siteSetupAction;
        static string paperworkIntervention;
        static string paperworkComment;
        static string paperworkCompleted;
        static string paperworkAction;
        static string certificationTrainingIntervention;
        static string certificationTrainingComment;
        static string certificationTrainingCompleted;
        static string certificationTrainingAction;
        static string hotWorkIntervention;
        static string hotWorkComment;
        static string hotWorkCompleted;
        static string hotWorkAction;
        static string isolationIntervention;
        static string isolationComment;
        static string isolationCompleted;
        static string isolationAction;
        static string fireExitIntervention;
        static string fireExitComment;
        static string fireExitCompleted;
        static string fireExitAction;
        static string awarenessIntervention;
        static string awarenessComment;
        static string awarenessCompleted;
        static string awarenessAction;
        static string wasteManagementIntervention;
        static string wasteManagementComment;
        static string wasteManagementCompleted;
        static string wasteManagementAction;
        static string productContaminationIntervention;
        static string productContaminationComment;
        static string productContaminationCompleted;
        static string productContaminationAction;
        static string cOSHHAsbestosIntervention;
        static string cOSHHAsbestosComment;
        static string cOSHHAsbestosCompleted;
        static string cOSHHAsbestosAction;


        public string WorkAtHeightIntervention { get => workAtHeightIntervention; set => workAtHeightIntervention = value; }
        public string WorkAtHeightComment { get => workAtHeightComment; set => workAtHeightComment = value; }
        public string WorkatHeightCompleted { get => workatHeightCompleted; set => workatHeightCompleted = value; }
        public string WorkatHeightAction { get => workatHeightAction; set => workatHeightAction = value; }
        public string LiftingOperationsIntervention { get => liftingOperationsIntervention; set => liftingOperationsIntervention = value; }
        public string LiftingOperationsComment { get => liftingOperationsComment; set => liftingOperationsComment = value; }
        public string LiftingOperationsCompleted { get => liftingOperationsCompleted; set => liftingOperationsCompleted = value; }
        public string LiftingOperationsAction { get => liftingOperationsAction; set => liftingOperationsAction = value; }
        public string CertificationIntervention { get => certificationIntervention; set => certificationIntervention = value; }
        public string CertificationComment { get => certificationComment; set => certificationComment = value; }
        public string CertificationCompleted { get => certificationCompleted; set => certificationCompleted = value; }
        public string CertificationAction { get => certificationAction; set => certificationAction = value; }
        public string ConfinedSpaceWorkIntervention { get => confinedSpaceWorkIntervention; set => confinedSpaceWorkIntervention = value; }
        public string ConfinedSpaceWorkComment { get => confinedSpaceWorkComment; set => confinedSpaceWorkComment = value; }
        public string ConfinedSpaceWorkCompleted { get => confinedSpaceWorkCompleted; set => confinedSpaceWorkCompleted = value; }
        public string ConfinedSpaceWorkAction { get => confinedSpaceWorkAction; set => confinedSpaceWorkAction = value; }
        public string ElectricalWorkIntervention { get => electricalWorkIntervention; set => electricalWorkIntervention = value; }
        public string ElectricalWorkComment { get => electricalWorkComment; set => electricalWorkComment = value; }
        public string ElectricalWorkCompleted { get => electricalWorkCompleted; set => electricalWorkCompleted = value; }
        public string ElectricalWorkAction { get => electricalWorkAction; set => electricalWorkAction = value; }
        public string SiteSetupIntervention { get => siteSetupIntervention; set => siteSetupIntervention = value; }
        public string SiteSetupComment { get => siteSetupComment; set => siteSetupComment = value; }
        public string SiteSetupCompleted { get => siteSetupCompleted; set => siteSetupCompleted = value; }
        public string SiteSetupAction { get => siteSetupAction; set => siteSetupAction = value; }
        public string PaperworkIntervention { get => paperworkIntervention; set => paperworkIntervention = value; }
        public string PaperworkComment { get => paperworkComment; set => paperworkComment = value; }
        public string PaperworkCompleted { get => paperworkCompleted; set => paperworkCompleted = value; }
        public string PaperworkAction { get => paperworkAction; set => paperworkAction = value; }
        public string CertificationTrainingIntervention { get => certificationTrainingIntervention; set => certificationTrainingIntervention = value; }
        public string CertificationTrainingComment { get => certificationTrainingComment; set => certificationTrainingComment = value; }
        public string CertificationTrainingCompleted { get => certificationTrainingCompleted; set => certificationTrainingCompleted = value; }
        public string CertificationTrainingAction { get => certificationTrainingAction; set => certificationTrainingAction = value; }
        public string HotWorkIntervention { get => hotWorkIntervention; set => hotWorkIntervention = value; }
        public string HotWorkComment { get => hotWorkComment; set => hotWorkComment = value; }
        public string HotWorkCompleted { get => hotWorkCompleted; set => hotWorkCompleted = value; }
        public string HotWorkAction { get => hotWorkAction; set => hotWorkAction = value; }
        public string IsolationIntervention { get => isolationIntervention; set => isolationIntervention = value; }
        public string IsolationComment { get => isolationComment; set => isolationComment = value; }
        public string IsolationCompleted { get => isolationCompleted; set => isolationCompleted = value; }
        public string IsolationAction { get => isolationAction; set => isolationAction = value; }
        public string FireExitIntervention { get => fireExitIntervention; set => fireExitIntervention = value; }
        public string FireExitComment { get => fireExitComment; set => fireExitComment = value; }
        public string FireExitCompleted { get => fireExitCompleted; set => fireExitCompleted = value; }
        public string FireExitAction { get => fireExitAction; set => fireExitAction = value; }
        public string AwarenessIntervention { get => awarenessIntervention; set => awarenessIntervention = value; }
        public string AwarenessComment { get => awarenessComment; set => awarenessComment = value; }
        public string AwarenessCompleted { get => awarenessCompleted; set => awarenessCompleted = value; }
        public string AwarenessAction { get => awarenessAction; set => awarenessAction = value; }
        public string WasteManagementIntervention { get => wasteManagementIntervention; set => wasteManagementIntervention = value; }
        public string WasteManagementComment { get => wasteManagementComment; set => wasteManagementComment = value; }
        public string WasteManagementCompleted { get => wasteManagementCompleted; set => wasteManagementCompleted = value; }
        public string WasteManagementAction { get => wasteManagementAction; set => wasteManagementAction = value; }
        public string ProductContaminationIntervention { get => productContaminationIntervention; set => productContaminationIntervention = value; }
        public string ProductContaminationComment { get => productContaminationComment; set => productContaminationComment = value; }
        public string ProductContaminationCompleted { get => productContaminationCompleted; set => productContaminationCompleted = value; }
        public string ProductContaminationAction { get => productContaminationAction; set => productContaminationAction = value; }
        public string COSHHAsbestosIntervention { get => cOSHHAsbestosIntervention; set => cOSHHAsbestosIntervention = value; }
        public string COSHHAsbestosComment { get => cOSHHAsbestosComment; set => cOSHHAsbestosComment = value; }
        public string COSHHAsbestosCompleted { get => cOSHHAsbestosCompleted; set => cOSHHAsbestosCompleted = value; }
        public string COSHHAsbestosAction { get => cOSHHAsbestosAction; set => cOSHHAsbestosAction = value; }
    }
}
