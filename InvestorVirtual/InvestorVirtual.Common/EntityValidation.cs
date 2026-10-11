namespace InvestorVirtual.Common;

public static class EntityValidation
{
    // Stock validations
    public const int TickerMaxLength = 10;
    public const int CompanyNameMaxLength = 100;
    public const int ShortDescriptionMaxLength = 1000;
    public const int SectorMaxLength = 50;
    public const int LogoPathMaxLength = 100;

    // News validations
    public const int HeadlineMaxLength = 200;
    public const int SourceMaxLength = 100;

    // Analysis validations
    public const int ReasoningMaxLength = 200;

    // Event validations
    public const int TitleMaxLength = 100;

    // Term validations
    public const int TermNameMaxLength = 100;
}