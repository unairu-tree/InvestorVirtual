namespace InvestorVirtual.Data.Models.Enums;

using System.ComponentModel.DataAnnotations;

// These categories are used to classify the terms in the learning section of the application
public enum TermCategory
{
    [Display(Name = "General")]
    General = 1,

    [Display(Name = "Technical Indicator")]
    TechnicalIndicator = 2,

    [Display(Name = "Chart Pattern")]
    ChartPattern = 3,

    [Display(Name = "Fundamental Analysis")]
    FundamentalAnalysis = 4
}