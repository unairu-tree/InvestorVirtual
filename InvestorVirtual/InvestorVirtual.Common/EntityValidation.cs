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
        public const int TermNameMaxLength = 100;
    }
}