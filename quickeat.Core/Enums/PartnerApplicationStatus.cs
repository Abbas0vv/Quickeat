using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickeat.Core.Enums;

public enum PartnerApplicationStatus
{
    [Display(Name = "Pending Review")]
    Pending,
    [Display(Name = "Under Review")]
    UnderReview,
    [Display(Name = "Info Requested")]
    RequiresMoreInfo,
    [Display(Name = "Approved")]
    Approved,
    [Display(Name = "Rejected")]
    Rejected,
    [Display(Name = "Withdrawn")]
    Withdrawn,
    [Display(Name = "Active Partner")]
    ActivePartner
}
