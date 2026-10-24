namespace InvestorVirtual.Common;

public static class EntityValidation
{
    public static class Stock
    {
        public const int TickerMaxLength = 10;
        public const int CompanyNameMaxLength = 100;
        public const int ShortDescriptionMaxLength = 1000;
        public const int SectorMaxLength = 50;
        public const int LogoPathMaxLength = 100;
    }
    
    public static class News
    {
        public const int HeadlineMaxLength = 200;
        public const int SourceMaxLength = 100;
    }

    public static class Analysis
    {
        public const int ReasoningMaxLength = 200;
    }

    public static class Event
    {
        public const int TitleMaxLength = 100;
    }

    public static class LearningTerm
    {
        public const int SlugMinLength = 2;     // Shorter if the user wants to submit just acronyms
        public const int SlugMaxLength = 100;
        public const string SlugRegEx = @"^[a-z0-9-]+$";
        public const string SlugRegExErrorMessage = "The slug can only contain lowercase letters, numbers, and hyphens.";
        public const int TermNameMinLength = 2; // Shorter if the user wants to submit just acronyms
        public const int TermNameMaxLength = 100;
        public const int DescriptionMinLength = 50;
    }
}