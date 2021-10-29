using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftEngSiteBuild
{
    class AuditFormData
    {
        string workAtHeightIntervention;
        string workAtHeightComment;
        //string workatHeightCompleted;
        //string workatHeightAction;

        public string WorkAtHeightIntervention { get => workAtHeightIntervention; set => workAtHeightIntervention = value; }
        public string WorkAtHeightComment { get => workAtHeightComment; set => workAtHeightComment = value; }
    }
}
